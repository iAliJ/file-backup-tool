using System;
using System.Collections.Generic;
using System.Text;

namespace FileBackupLibrary.Models
{
    public class BackupInfo
    {
        public string BackupLocation { get; set; }
        public int NumberOfBackups { get; set; } // Number of backups that have been performed
        public int MaxBackup { get; set; }  // Number of backups should not exceed this number
        public int BackupInterval { get; set; } // Backup interval in minutes
        public DateTime BackUpTimer { get; set; } // Time until the next backup
        public bool CanBackup
        {
            get
            {
                return NumberOfBackups <= MaxBackup;
            }
        }

        public BackupInfo()
        {
            this.BackupLocation = @"C:\Backup";
            this.NumberOfBackups = 0;
            this.MaxBackup = 5;
            this.BackupInterval = 15;
            this.BackUpTimer = new DateTime(0, 0, 0, 0, this.BackupInterval, 0);
        }
    }
}
