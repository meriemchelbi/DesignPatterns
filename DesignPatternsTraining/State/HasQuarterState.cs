using System;

namespace DesignPatternsTraining.State
{
    public class HasQuarterState : IState
    {
        private readonly GumballMachine _machine;

        public HasQuarterState(GumballMachine machine)
        {
            _machine = machine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You cannot insert another quarter");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Quarter returned");
            _machine.SetState(_machine.NoQuarterState);
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned the crank...");
            _machine.SetState(_machine.SoldState);
        }

        public void Dispense()
        {
            Console.WriteLine("No gumball dispensed- turn the crank first!");
        }
    }
}
