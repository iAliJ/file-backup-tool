using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileBackupLibrary.Models
{
    public class FileInfo
    {
        private string fileName;
        public string FileName
        {
            get { return fileName; }
            set
            {
                if (fileName == null)
                    fileName = Path.GetFileName(FilePath);
                else
                    fileName = value;
            }

        }
        public string FilePath { get; set; }
        public BackupInfo FileBackupInfo { get; set; }

        public FileInfo()
        {
            this.FileBackupInfo = new BackupInfo();
        }
    }
}
