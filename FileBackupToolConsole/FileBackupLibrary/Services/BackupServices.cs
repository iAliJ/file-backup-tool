using System;
using System.Collections.Generic;
using System.IO;
using DirectoryHelperCL;
using FileBackupLibrary.Models;

namespace FileBackupLibrary.Services
{
    public class BackupServices
    {
        string backupFilePath;
        private void BackupFile(Models.FileInfo fileInfo)
        {
            backupFilePath = Path.Combine(fileInfo.FileBackupInfo.BackupLocation, fileInfo.FileName);
            if (File.Exists(backupFilePath))
                ChangeFileName(ref fileInfo);
            File.Copy(fileInfo.FilePath, backupFilePath);
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

        private void ChangeFileName(ref Models.FileInfo fileInfo)
        {
            fileInfo.FileName = $"{Path.GetFileNameWithoutExtension(fileInfo.FilePath)}_{DateTime.Now:yyyyMMddHHmm}.{Path.GetExtension(fileInfo.FilePath)}";
            backupFilePath = Path.Combine(fileInfo.FileBackupInfo.BackupLocation, fileInfo.FileName);
        }
    }
}
