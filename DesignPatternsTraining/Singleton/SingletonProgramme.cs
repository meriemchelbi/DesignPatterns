using System;

namespace DesignPatternsTraining.Singleton
{
    public static class SingletonProgramme
    {
        public static void Singleton()
        {
            Console.WriteLine("Singleton pattern...");

            MySingleton.GetInstance();
            MySingleton.GetInstance();
            MySingleton.GetInstance();
        }
    }
}
