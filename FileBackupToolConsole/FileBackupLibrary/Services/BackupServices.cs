using System;
using System.Collections.Generic;
using System.IO;
using DirectoryHelperCL;
using FileBackupLibrary.Models;

namespace FileBackupLibrary.Services
{
    public class BackupServices
    {
        private void BackupFile(Models.FileInfo fileInfo)
        {
            // Basically copy a file from one location to another
            File.Copy(fileInfo.FilePath, fileInfo.FileBackupInfo.BackupLocation);
        }

        public void DeleteBackupFile(Models.FileInfo fileInfo)
        {
            File.Delete(fileInfo.FilePath);
        }   
        
        public void PerformBackup(Models.FileInfo fileInfo)
        {
            if(fileInfo.FileBackupInfo.CanBackup)
            {
                BackupFile(fileInfo);
                fileInfo.FileBackupInfo.NumberOfBackups++;
            }
        }
    }
}
