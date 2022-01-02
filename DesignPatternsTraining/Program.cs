using DesignPatternsTraining.Adapter;
using DesignPatternsTraining.Builder;
using DesignPatternsTraining.Command;
using DesignPatternsTraining.Composite;
using DesignPatternsTraining.Decorator;
using DesignPatternsTraining.Factory;
using DesignPatternsTraining.Iterator;
using DesignPatternsTraining.Observer;
using DesignPatternsTraining.Prototype;
using DesignPatternsTraining.Singleton;
using DesignPatternsTraining.Strategy;
using DesignPatternsTraining.TemplateMethod;

namespace DesignPatternsTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            //StrategyProgramme.Strategy();
            //AdaptorProgramme.Adaptor();
            //DecoratorProgramme.Decorator();
            //ProxyProgramme.Proxy();
            //CommandProgramme.Command();
            //CompositeProgramme.Composite();
            //IteratorProgramme.Iterator();
            //ObserverProgramme.Observer();
            //TemplateMethodProgramme.TemplateMethod();
            //SingletonProgramme.Singleton();
            //PrototypeProgramme.Prototype();
            //FactoryProgramme.Factory();
            BuilderProgramme.Builder();
        }
    }
}
