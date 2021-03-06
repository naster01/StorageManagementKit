﻿using StorageManagementKit.Core.Crypto;
using StorageManagementKit.Core.Diagnostics;
using System;

namespace StorageManagementKit.Core.Restoring
{
    public class RestoringFactory
    {
        #region Members
        private ILogging _logger;
        #endregion

        #region Constructors
        public RestoringFactory(ILogging logger)
        {
            _logger = logger ?? throw new ArgumentNullException("logger");
        }
        #endregion

        #region Public methods
        /// <summary>
        /// Create a <see cref="IRestoring"/> instance in according to the command arguments
        /// </summary>
        public IRestoring Create(RestoringSettings settings)
        {
            settings = settings ?? throw new ArgumentNullException("settings");

            // Loads the 3-DES key to decrypt the file from GCS
            Helpers.MandatoryValue("Crypto key", settings.CryptoKey);
            byte[] crypto_key, crypto_iv;

            if (!TripleDES.LoadKeyFile(settings.CryptoKey, out crypto_key, out crypto_iv, _logger))
                throw new SmkException(ErrorResources.TransformFactory_InstanciationFailed);

            switch (settings.Repository)
            {
                case RestoringRepositorySource.GCS:
                    {
                        Helpers.MandatoryValue("source path", settings.Path);
                        Helpers.MandatoryValue("source API key", settings.ApiKey);

                        return new GcsRestore(settings.Path, settings.ApiKey, crypto_key, crypto_iv, _logger);
                    }

                case RestoringRepositorySource.S3:
                    {
                        return null;
                    }

                default:
                    throw new SmkException($"Unsupported repository source '{settings.Repository}");
            }
        }
        #endregion
    }
}
