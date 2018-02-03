using System;
using System.Collections.Generic;
using System.Timers;

namespace Observer.Observers
{
    //Observer pattern - using IObservable/IObserver
    //The name of the class is given to understand the type of implementation
    public class FileStatusObservable : IObservable<string>, IDisposable
    {
        private readonly List<IObserver<string>> _observers;
        private readonly Timer _timer;
        private readonly DirMonitoring _dirMonitor;

        public FileStatusObservable(string directory)
        {
            _observers = new List<IObserver<string>>();
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
                foreach (var observer in _observers)
                {
                    observer.OnNext(fileName);
                }
            }
        }

        public void Dispose()
        {
            _timer.Dispose();
        }

        public IDisposable Subscribe(IObserver<string> observer)
        {
            if (!_observers.Contains(observer))
            {
                _observers.Add(observer);
            }

            return new Unsubscriber(_observers, observer);
        }
    }

    public class Unsubscriber : IDisposable
    {
        private readonly List<IObserver<string>> _observers;
        private readonly IObserver<string> _observer;

        public Unsubscriber(List<IObserver<string>> observers, IObserver<string> observer)
        {
            _observers = observers;
            _observer = observer;
        }

        public void Dispose()
        {
            if (_observer != null && _observers.Contains(_observer))
            {
                _observers.Remove(_observer);
            }
        }
    }
}
