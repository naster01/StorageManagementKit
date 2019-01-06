﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StorageManagementKit.Core {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class ErrorResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ErrorResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("StorageManagementKit.Core.ErrorResources", typeof(ErrorResources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Getting file list...
        /// </summary>
        public static string DirectoryDiscover_GettingFileList {
            get {
                return ResourceManager.GetString("DirectoryDiscover_GettingFileList", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The scan has been interrupted.
        /// </summary>
        public static string DirectorySync_ScanInterrupted {
            get {
                return ResourceManager.GetString("DirectorySync_ScanInterrupted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Scan interrupted because a cancellation has been detected.
        /// </summary>
        public static string Engine_CancellationDetected {
            get {
                return ResourceManager.GetString("Engine_CancellationDetected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Recovering {0}.
        /// </summary>
        public static string Engine_FileDecryption {
            get {
                return ResourceManager.GetString("Engine_FileDecryption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Securing {0}.
        /// </summary>
        public static string Engine_FileEncryption {
            get {
                return ResourceManager.GetString("Engine_FileEncryption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid log age value.
        /// </summary>
        public static string Engine_InvalidLogAge {
            get {
                return ResourceManager.GetString("Engine_InvalidLogAge", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The key file {0} has been generated.
        /// </summary>
        public static string Engine_KeyFileGenerated {
            get {
                return ResourceManager.GetString("Engine_KeyFileGenerated", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Operation &apos;{0}&apos; failed because the engine is synchronizing &apos;{1}&apos;.
        /// </summary>
        public static string Engine_OperationFailed_Busy {
            get {
                return ResourceManager.GetString("Engine_OperationFailed_Busy", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error while getting object list from GCS Bucket.
        /// </summary>
        public static string GcsBucketDestination_GettingListException {
            get {
                return ResourceManager.GetString("GcsBucketDestination_GettingListException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Getting object list...
        /// </summary>
        public static string GcsBucketDestination_GettingObjectList {
            get {
                return ResourceManager.GetString("GcsBucketDestination_GettingObjectList", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Only a secured transformation is supported.
        /// </summary>
        public static string GcsBucketDestination_UnsecuredNotSupported {
            get {
                return ResourceManager.GetString("GcsBucketDestination_UnsecuredNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Downloading object &apos;{0}&apos; failed.
        /// </summary>
        public static string GcsBucketSource_DownloadingError {
            get {
                return ResourceManager.GetString("GcsBucketSource_DownloadingError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Getting object list...
        /// </summary>
        public static string GcsBucketSource_GettingObjectList {
            get {
                return ResourceManager.GetString("GcsBucketSource_GettingObjectList", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Missing metadata for &apos;{0}&apos;.
        /// </summary>
        public static string GcsBucketSource_MissingMetadata {
            get {
                return ResourceManager.GetString("GcsBucketSource_MissingMetadata", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed while getting object versions from GCP.
        /// </summary>
        public static string GcsRestore_GetVersionsException {
            get {
                return ResourceManager.GetString("GcsRestore_GetVersionsException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Missing metadata for &apos;{0}&apos;.
        /// </summary>
        public static string GcsRestore_MissingMetadata {
            get {
                return ResourceManager.GetString("GcsRestore_MissingMetadata", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Object &apos;{0}&apos; not found.
        /// </summary>
        public static string GcsRestore_ObjectNotFound {
            get {
                return ResourceManager.GetString("GcsRestore_ObjectNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed while downloading object from GCP.
        /// </summary>
        public static string GcsRestore_RestoreObjectException {
            get {
                return ResourceManager.GetString("GcsRestore_RestoreObjectException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to delete the file &apos;{0}&apos;.
        /// </summary>
        public static string LocalDirectoryCleaner_FailedToDeleteFile {
            get {
                return ResourceManager.GetString("LocalDirectoryCleaner_FailedToDeleteFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Deletion failed of &apos;{0}&apos; to the destination.
        /// </summary>
        public static string LocalDirectoryDestination_DeletionFailed {
            get {
                return ResourceManager.GetString("LocalDirectoryDestination_DeletionFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to delete the directory &apos;{dir}&apos;.
        /// </summary>
        public static string LocalDirectoryDestination_DirectoryDeletionException {
            get {
                return ResourceManager.GetString("LocalDirectoryDestination_DirectoryDeletionException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid MD5 definition.
        /// </summary>
        public static string LocalDirectorySource_InvalidMD5File {
            get {
                return ResourceManager.GetString("LocalDirectorySource_InvalidMD5File", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to delete the artifact {0}.
        /// </summary>
        public static string LogHelpers_CleaningLogFailed {
            get {
                return ResourceManager.GetString("LogHelpers_CleaningLogFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error occured while securing the file {0}.
        /// </summary>
        public static string SecureTransform_ProcessException {
            get {
                return ResourceManager.GetString("SecureTransform_ProcessException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Deleting artefacts has begun.
        /// </summary>
        public static string SyncPhase_CleaningBegun {
            get {
                return ResourceManager.GetString("SyncPhase_CleaningBegun", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Deleting artefacts has ended.
        /// </summary>
        public static string SyncPhase_CleaningEnded {
            get {
                return ResourceManager.GetString("SyncPhase_CleaningEnded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cleaning phase has begun.
        /// </summary>
        public static string SyncPhase_DeletionBegun {
            get {
                return ResourceManager.GetString("SyncPhase_DeletionBegun", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cleaning phase has ended.
        /// </summary>
        public static string SyncPhase_DeletionEnded {
            get {
                return ResourceManager.GetString("SyncPhase_DeletionEnded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sending phase has begun.
        /// </summary>
        public static string SyncPhase_SendingBegun {
            get {
                return ResourceManager.GetString("SyncPhase_SendingBegun", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sending phase has ended.
        /// </summary>
        public static string SyncPhase_SendingEnded {
            get {
                return ResourceManager.GetString("SyncPhase_SendingEnded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Transformation instanciation failed.
        /// </summary>
        public static string TransformFactory_InstanciationFailed {
            get {
                return ResourceManager.GetString("TransformFactory_InstanciationFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to create a new key to the file &apos;{0}&apos;.
        /// </summary>
        public static string TripleDES_GenerateKey {
            get {
                return ResourceManager.GetString("TripleDES_GenerateKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid key from the file &apos;{0}&apos;.
        /// </summary>
        public static string TripleDES_InvalidKey {
            get {
                return ResourceManager.GetString("TripleDES_InvalidKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The key file &apos;{0}&apos; could not be found.
        /// </summary>
        public static string TripleDES_KeyfileNotFound {
            get {
                return ResourceManager.GetString("TripleDES_KeyfileNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid signature of data content for {0}.
        /// </summary>
        public static string UnsecureTransform_InvalidDataContentSignature {
            get {
                return ResourceManager.GetString("UnsecureTransform_InvalidDataContentSignature", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid signature of metadata for {0}.
        /// </summary>
        public static string UnsecureTransform_InvalidMetadataSignature {
            get {
                return ResourceManager.GetString("UnsecureTransform_InvalidMetadataSignature", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error occured while decrypting the {0} for {1}.
        /// </summary>
        public static string UnsecureTransform_ProcessException {
            get {
                return ResourceManager.GetString("UnsecureTransform_ProcessException", resourceCulture);
            }
        }
    }
}
