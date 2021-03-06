﻿namespace StorageManagementKit.Core.Copying.Sources
{
    public enum SourceRepository
    {
        Local,
        GCS,
        S3
    }

    public enum CheckLevel
    {
        LocalMD5,
        RemoteMD5,
        ArchiveFlag
    }
}
