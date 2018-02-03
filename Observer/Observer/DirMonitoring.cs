using System.Collections.Generic;
using System.IO;

namespace Observer
{
    public class DirMonitoring
    {
        private List<string> _files;
        private readonly string _directory;

        public DirMonitoring(string directory)
        {
            _directory = directory;

        }
       
        public bool StartMonitor()
        {
            if (!Directory.Exists(_directory))
            {
                return false;
            }

            _files = new List<string>();

            var directoryInfo = new DirectoryInfo(_directory);
            foreach (var fileInfo in directoryInfo.GetFiles())
            {
                _files.Add(fileInfo.FullName);
            }

            return true;
        }

        public List<string> DeletedFiles()
        {
            var result = new List<string>();
            foreach (var file in _files.ToArray())
            {
                if (!File.Exists(file))
                {
                    _files.Remove(file);
                    result.Add(file);
                }
            }
            return result;
        }
    }
}
