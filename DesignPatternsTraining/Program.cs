using DesignPatternsTraining.Adapter;
using DesignPatternsTraining.Command;
using DesignPatternsTraining.Composite;
using DesignPatternsTraining.Decorator;
using DesignPatternsTraining.Iterator;
using DesignPatternsTraining.Observer;
using DesignPatternsTraining.Strategy;
using DesignPatternsTraining.Template_Method;

namespace DesignPatternsTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            StrategyProgramme.Strategy();
            AdaptorProgramme.Adaptor();
            DecoratorProgramme.Decorator();
            ProxyProgramme.Proxy();
            CommandProgramme.Command();
            CompositeProgramme.Composite();
            IteratorProgramme.Iterator();
            ObserverProgramme.Observer();
            TemplateMethodProgramme.TemplateMethod();
        }
    }
}
