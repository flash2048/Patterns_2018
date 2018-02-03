using System;

namespace Observer
{
    class Observer : IObserver<string>
    {
        private IDisposable _unsubscriber;

        public virtual void Subscribe(IObservable<string> provider)
        {
            if (provider != null)
            {
                _unsubscriber = provider.Subscribe(this);
            }
        }

        public void OnNext(string value)
        {
            Console.WriteLine($"{value} file was deleted!");
        }

        public void OnError(Exception error)
        {
            Console.WriteLine("An error has occurred: " + error.Message);
        }

        public void OnCompleted()
        {
            Unsubscribe();
        }

        public virtual void Unsubscribe()
        {
            _unsubscriber.Dispose();
        }
    }
}
