using System;

namespace DesignPatternsTraining.Observer
{
    public class Observer : IObserver
    {
        public readonly string Name;
        private int _value;

        public Observer(string name)
        {
            Name = name;
        }

        public void Update(int value)
        {
            _value = value;
            Console.WriteLine($"Value successfully updated to {value} for observer: {Name}");
        }

    }
}
