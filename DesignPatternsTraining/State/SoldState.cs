using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsTraining.State
{
    public class SoldState : IState
    {
        private readonly GumballMachine _machine;

        public SoldState(GumballMachine machine)
        {
            _machine = machine;
        }

        public void Dispense()
        {
            Console.WriteLine("Enjoy your gumball!");
        }

        public void EjectQuarter()
        {
            throw new NotImplementedException();
        }

        public void InsertQuarter()
        {
            throw new NotImplementedException();
        }

        public void TurnCrank()
        {
            throw new NotImplementedException();
        }
    }
}
