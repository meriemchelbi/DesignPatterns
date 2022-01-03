using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsTraining.State
{
    public class GumballMachine : IState
    {
        private readonly int _noOfGumballs;

        private IState _state { get; set; }
        public IState NoQuarterState { get; set; }
        public IState SoldOutState { get; set; }
        public IState HasQuarterState { get; set; }
        public IState SoldState { get; set; }

        public GumballMachine(int noOfGumballs)
        {
            NoQuarterState = new NoQuarterState(this);
            SoldOutState = new SoldOutState(this);
            HasQuarterState = new HasQuarterState(this);
            SoldState = new SoldState(this);

            _noOfGumballs = noOfGumballs;
            SetStartingState();
        }

        public IState GetState() => _state;

        public void SetState(IState state)
        {
            Console.WriteLine($"Setting machine state to {state.GetType()}");
            _state = state;
        }

        public void Dispense()
        {
            _state.Dispense();
        }

        public void EjectQuarter()
        {
            _state.EjectQuarter();
        }

        public void InsertQuarter()
        {
            _state.InsertQuarter();
        }

        public void TurnCrank()
        {
            _state.TurnCrank();
            _state.Dispense();
        }

        private void SetStartingState()
        {
            if (_noOfGumballs > 0)
                _state = NoQuarterState;
            else
                _state = SoldOutState;
        }
    }
}
