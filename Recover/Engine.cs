﻿using StorageManagementKit.Core;
using StorageManagementKit.Core.Diagnostics;
using StorageManagementKit.Core.Restoring;
using System;
using System.Linq;

namespace StorageManagementKit.Recover
{
    public class Engine
    {
        #region Members
        private string[] _arguments;
        private ILogging _logger;
        private string _title = "SMK-Recover";
        #endregion

        #region Constructors
        public Engine(string[] args)
        {
            _arguments = args ?? throw new ArgumentNullException("args");

            Console.Title = _title;
            InitLogFile();
        }
        #endregion

        public void Process()
        {
            // Display the help
            if (_arguments.Any(a => a.Equals("?") || a.Equals("-help")))
                DisplayHelp();

            else if (!ConsoleHelpers.AllCommandExist(_arguments, typeof(Arguments)))
                return;

            Recover();
        }

        /// <summary>
        /// Init the log file
        /// </summary>
        private void InitLogFile()
        {
            try
            {
                var verboseLevel = _arguments.Any(a => a.ToLower() == $"/{Arguments.Debug}") ? VerboseLevel.Debug : VerboseLevel.User;

                string logfile = ConsoleHelpers.GetCommandArgValue(_arguments, Arguments.Log);

                if (string.IsNullOrEmpty(logfile)) // Set the default filename
                    logfile = "trace.log";

                string age = ConsoleHelpers.GetCommandArgValue(_arguments, Arguments.LogAge);
                if (string.IsNullOrEmpty(age))
                    age = "9";

                int iage;
                if (!int.TryParse(age, out iage))
                {
                    Console.WriteLine(ErrorResources.Engine_InvalidLogAge);
                    Environment.Exit(-1);
                }

                _logger = new Logger(logfile, iage, verboseLevel);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        private static void DisplayHelp()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Recover a file from a cloud service bucket
        /// </summary>
        private void Recover()
        {
            Console.Clear();
            DisplayHeader(true);

            string source = ConsoleHelpers.GetCommandArgValue(_arguments, Arguments.Source);
            string sourceFile = ConsoleHelpers.GetCommandArgValue(_arguments, Arguments.SourceFile);
            string sourcePath = ConsoleHelpers.GetCommandArgValue(_arguments, Arguments.SourcePath);
            string sourceApiKey = ConsoleHelpers.GetCommandArgValue(_arguments, Arguments.SourceApiKey);
            string cryptoKey = ConsoleHelpers.GetCommandArgValue(_arguments, Arguments.CryptoKey);
            string destFile = ConsoleHelpers.GetCommandArgValue(_arguments, Arguments.DestFile);
            string debug = ConsoleHelpers.GetCommandArgValue(_arguments, Arguments.Debug);
            string log = ConsoleHelpers.GetCommandArgValue(_arguments, Arguments.Log);
            string logAge = ConsoleHelpers.GetCommandArgValue(_arguments, Arguments.LogAge);


            // Requests a filename from the user if it was not provided...
            if (string.IsNullOrEmpty(sourceFile))
            {
                Console.WriteLine("Type the file name to restore and press enter:");
                sourceFile = Console.ReadLine().Replace("\\", "/");
            }
            else
                sourceFile = sourceFile.Replace("\\", "/");


            // Gets the list of versions about the requested object
            Console.Clear();
            DisplayHeader(false);
            _logger.WriteLine("Contacting the cloud storage service...");
            _logger.WriteLine();

            RestoringSettings settings = new RestoringSettings()
            {
                Repository = source.ConvertToSourceRepository(),
                ApiKey = sourceApiKey,
                Path = sourcePath,
                CryptoKey = cryptoKey
            };

            // Creates the restoring instance for the selected cloud service source
            IRestoring restorer = new RestoringFactory(_logger).Create(settings);

            // Requests the list of available versions for the given object
            ObjectVersion[] versions = restorer.GetVersions(sourceFile.ToLower());

            if (versions == null)
                return;

            DisplayList(versions, sourcePath, sourceFile);

            int choice = GetUserChoice(versions.Length);
            if (choice == -1)
                return;

            // The user has choosen the version, requests the file
            if (!restorer.Restore(versions[choice - 1], ref destFile))
                return;

            _logger.Write($"{destFile} successfully restored");
            _logger.WriteLine();

            DisplayFooter();
        }

        /// <summary>
        /// Requests a choice to the user. He must select an object version.
        /// </summary>
        private static int GetUserChoice(int count)
        {
            string choice;
            int ichoice = -1;

            do
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("Enter the desired object version and press enter or type 'exit' to cancel ");

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($"[1-{count}]: ");

                choice = Console.ReadLine();

                // The user can type 'exist' to cancel the workflow
                if (choice.ToLower().Equals("exit"))
                    return -1;

                // Be sure the user has provided a valid numeric choice
                if (int.TryParse(choice, out ichoice) && (ichoice >= 1) && (ichoice <= count))
                    return ichoice;
            }
            while (true);
        }

        /// <summary>
        /// Displays the list of existing versions
        /// </summary>
        private void DisplayList(ObjectVersion[] versions, string bucket, string filename)
        {
            Console.Clear();
            DisplayHeader(false);

            Console.ForegroundColor = ConsoleColor.Gray;
            _logger.Write("Object: ");

            Console.ForegroundColor = ConsoleColor.White;
            _logger.WriteLine($"gs://{bucket}/{filename.Replace("\\", " / ")}");
            _logger.WriteLine();

            Console.ForegroundColor = ConsoleColor.Gray;
            _logger.WriteLine("Choice\tTime created\t\tSize\tStorage\t\tGeneration");
            _logger.WriteLine("-------\t-----------------------\t-------\t--------------\t-----------------");

            // Enumerates each available version...
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < versions.Length; i++)
            {
                string size = Helpers.FormatByteSize(versions[i].Size);
                _logger.WriteLine($"[{i + 1}]\t{versions[i].TimeCreated}\t{size}\t{versions[i].StorageClass}\t{versions[i].Generation}");
            }

            _logger.WriteLine();
        }

        private void DisplayHeader(bool writeLog)
        {
            Console.Clear();

            if (writeLog)
            {
                _logger.WriteLine($"{_title} - Jimmy Bourque (GNU General Public License)");
                _logger.WriteLine("--------------------------------------------------------");
                _logger.WriteLine();
            }
            else
            {
                Console.WriteLine($"{_title} - Jimmy Bourque (GNU General Public License)");
                Console.WriteLine("--------------------------------------------------------");
                Console.WriteLine();
            }
        }

        private void DisplayFooter()
        {
            _logger.WriteLine();
            _logger.WriteLine("--------------------------------------------------------");
            _logger.WriteLine();
        }
    }
}
