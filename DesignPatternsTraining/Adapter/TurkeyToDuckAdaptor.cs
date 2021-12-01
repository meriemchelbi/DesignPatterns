namespace DesignPatternsTraining.Adapter
{
    public class TurkeyToDuckAdaptor : IDuck
    {
        public ITurkey Turkey;

        public TurkeyToDuckAdaptor(ITurkey turkey)
        {
            Turkey = turkey;
        }

        public void Fly()
        {
            for (int i = 0; i < 5; i++)
            {
                Turkey.Fly();
            }
        }

        public void Quack()
        {
            Turkey.Gobble();
        }
    }
}
