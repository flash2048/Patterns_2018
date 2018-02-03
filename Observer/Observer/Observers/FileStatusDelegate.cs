using System;
using System.Timers;

namespace Observer.Observers
{
    //Observer pattern - using delegate
    //The name of the class is given to understand the type of implementation
    public class FileStatusDelegate: IDisposable
    {
        private readonly Action<string> _subscriber;
        private readonly Timer _timer;
        private readonly DirMonitoring _dirMonitor;

        public FileStatusDelegate(string directory, Action<string> subscriber)
        {
            _subscriber = subscriber;
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
                _subscriber($"{fileName}");
            }
        }

        public void Dispose()
        {
            _timer.Dispose();
        }
    }
}
