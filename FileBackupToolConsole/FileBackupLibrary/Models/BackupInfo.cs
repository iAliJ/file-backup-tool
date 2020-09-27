using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace FileBackupLibrary.Models
{
    public class BackupInfo
    {
        public string BackupLocation { get; set; }
        public int NumberOfBackups { get; set; } // Number of backups that have been performed
        public int MaxBackup { get; set; }  // Number of backups should not exceed this number
        public int BackupInterval { get; set; } // Backup interval in minutes
        public Timer BackUpTimer { get; set; } // Time until the next backup
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
            this.BackUpTimer = new Timer();
            //StartTimer();
        }

        private void StartTimer()
        {
            //this.BackUpTimer.Interval = this.BackupInterval * 1000 * 60;
            this.BackUpTimer.Interval = 5000;
            BackUpTimer.Elapsed += BackupEvent;
            BackUpTimer.AutoReset = true;
            BackUpTimer.Enabled = true;
        }

        private void BackupEvent(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("Backup Event Executed");
        }
    }
}
