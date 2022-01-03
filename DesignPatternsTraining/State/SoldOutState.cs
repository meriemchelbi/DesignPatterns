using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsTraining.State
{
    public class SoldOutState : IState
    {
        private readonly GumballMachine _machine;

        public SoldOutState(GumballMachine machine)
        {
            _machine = machine;
        }

        public void Dispense()
        {
            Console.WriteLine("Sold out of gumballs- cannot dispense!");
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
