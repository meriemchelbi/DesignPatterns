using System;

namespace DesignPatternsTraining.Observer
{
    public class Observer : IObserver
    {
        public readonly string Name;
        private Subject _subject;
        private int _value;
        private bool _newValueAvailable = false;

        public Observer(string name)
        {
            Name = name;
        }

        public Observer(string name, Subject subject)
        {
            Name = name;
            _subject = subject;
        }

        public void Update(int value)
        {
            if (_subject is null)
                SetValue(value);

            else
                Notify();
        }
        
        private void Notify()
        {
            _newValueAvailable = true;
            Console.WriteLine($"{Name} has been notified of an update to the subject's value");
        }

        public void UpdateAsync()
        {
            if (_subject is null)
                return;

            if (_newValueAvailable)
            {
                var value = _subject.GetValue();
                SetValue(value);
                _newValueAvailable = false;
            }
        }

        public int GetValue() => _value;

        private void SetValue(int value)
        {
            _value = value;
            Console.WriteLine($"Value successfully updated to {value} for observer: {Name}");
        }
    }
}
