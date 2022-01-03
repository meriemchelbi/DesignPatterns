namespace DesignPatternsTraining.State
{
    public interface IState
    {
        void Dispense();
        void EjectQuarter();
        void InsertQuarter();
        void TurnCrank();
    }
}