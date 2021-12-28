using System;
using System.Collections.Generic;

namespace DesignPatternsTraining.Observer
{
    public class Subject
    {
        private List<IObserver> _observers = new List<IObserver>();
        private int _value = 0;

        public void RegisterObserver(Observer observer)
        {
            _observers.Add(observer);
            Console.WriteLine($"Observer {observer.Name} added.");
        }

        public void UnregisterObserver(Observer observer)
        {
            _observers.Remove(observer);
            Console.WriteLine($"Observer {observer.Name} removed.");
        }

        public void SetValue(int value)
        {
            _value = value;
            NotifyObservers();
        }

        private void NotifyObservers()
        {
            _observers.ForEach(o => o.Update(_value));
            Console.WriteLine("Observers notified");
        }
    }
}
