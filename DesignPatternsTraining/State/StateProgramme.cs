using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsTraining.State
{
    public class StateProgramme
    {
        public static void State()
        {
            Console.WriteLine("State programme...");
            
            var machine = new GumballMachine(3);

            machine.EjectQuarter();
            machine.InsertQuarter();
            machine.TurnCrank();
        }
    }
}
