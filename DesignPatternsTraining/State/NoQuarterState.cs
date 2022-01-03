using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsTraining.State
{
    public class NoQuarterState : IState
    {
        private readonly GumballMachine _machine;

        public NoQuarterState(GumballMachine machine)
        {
            _machine = machine;
        }

        public void Dispense()
        {
            Console.WriteLine("Insert a quarter, first!");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("No quarter to inject");
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You have inserted a quarter!");
            _machine.SetState(_machine.HasQuarterState);
        }

        public void TurnCrank()
        {
            Console.WriteLine("Insert a quarter, first!");
        }
    }
}
