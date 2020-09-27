using System;
using FileBackupLibrary;
using FileBackupLibrary.Models;
using System.Timers;

namespace FileBackupToolConsole
{
    class Program
    {

        public static void Main()
        {
            FileInfo file1 = new FileInfo();
            file1.FilePath = @"C:\Backup\FA\FileA.txt";
            file1.FileName = "FileA.txt";
            file1.FileBackupInfo.BackupLocation = @"C:\Backup";

            FileBackupLibrary.Services.BackupServices backup = new FileBackupLibrary.Services.BackupServices();
            backup.PerformBackup(file1);
            Console.Read();
        }
    }
}
