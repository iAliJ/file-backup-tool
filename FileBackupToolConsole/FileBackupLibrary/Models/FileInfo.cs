using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileBackupLibrary.Models
{
    public class FileInfo
    {
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public BackupInfo FileBackupInfo { get; set; }
    }
}
