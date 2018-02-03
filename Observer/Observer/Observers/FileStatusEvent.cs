using System;
using System.Timers;

namespace Observer.Observers
{
    //Observer pattern - using event
    //The name of the class is given to understand the type of implementation
    public class FileStatusEvent : IDisposable
    {
        public event EventHandler<string> RemoveFiles;
        private readonly Timer _timer;
        private readonly DirMonitoring _dirMonitor;

        public FileStatusEvent(string directory)
        {
            _dirMonitor = new DirMonitoring(directory);

            if (_dirMonitor.StartMonitor())
            {
                _timer = new Timer(1000);
                _timer.Elapsed += CheckRemoval;
                _timer.Start();
            }
            else
            {
                Console.WriteLine("Specified directory does not exist");
                Dispose();
            }
        }

        private void CheckRemoval(Object source, ElapsedEventArgs e)
        {

            foreach (var fileName in _dirMonitor.DeletedFiles())
            {
                var handler = RemoveFiles;
                handler?.Invoke(this, fileName);
            }
          
        }

        public void Dispose()
        {
            _timer.Dispose();
        }
    }
}
