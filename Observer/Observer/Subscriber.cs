using System;

namespace Observer
{
    public class Subscriber
    {
        private readonly string _name;

        public Subscriber(string name)
        {
            _name = name;
        }

        public void ItIsSubscriber(string fileName)
        {
            Console.WriteLine($"{_name} {fileName} was deleted!");
        }

        public void ItIsSubscriber(object sender, string fileName)
        {
            Console.WriteLine($"{_name} {fileName}  was deleted!");
        }

        public void ItIsSecondSubscriber(object sender, string fileName)
        {
            Console.WriteLine("---");
            Console.WriteLine($"{_name} {fileName}  was deleted!");
            Console.WriteLine("---");
        }
    }
}
