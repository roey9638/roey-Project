using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Threads_HM
{
    class Searchh
    {
        public string Drive { get; set; }
        public string SearchTerm { get; set; }

        public List<string> Extensions = new List<string>() { ".txt" };

        public Searchh(string drive, string searchTerm)
        {
            Drive = drive;
            SearchTerm = searchTerm;
        }

        public List<string> Searching()
        {
            List<string> results = new List<string>();

            var files = GetAllFiles();

            return results;
        }

        public List<dynamic> GetAllFiles()
        {
            DriveInfo drives = new DriveInfo($@"{Drive}");

            DirectoryInfo directoryInfo = drives.RootDirectory;

            var allFiles = new List<dynamic>();

            object lockObject = new object();

            var getFiles = new List<dynamic>();

            allFiles.Add(directoryInfo.GetFiles().Where(file => IsMatchExtension(file.Name.ToString())));

            foreach (var file in allFiles)
            {
                new Thread(() =>
                {
                    if (IsContainsSearchTerm(file.ToString()))
                    {
                        lock (lockObject)
                        {
                            getFiles.Add(file);
                        }
                    }
                }).Start();
            }
            return getFiles;
        }
        private bool IsContainsSearchTerm(string file)
        {
            string line;
            using (StreamReader reader = new StreamReader(file))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Contains(SearchTerm))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private bool IsMatchExtension(string extension)
        {
            Regex regex = new Regex(@"^*\.txt$");
            return regex.IsMatch(extension);
        }
    }
}

