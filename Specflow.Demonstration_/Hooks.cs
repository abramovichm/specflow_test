using System;
using TechTalk.SpecFlow;

namespace Specflow.Demonstration
{
    [Binding]
    public static class Hooks
    {
        [BeforeFeature]
        public static void BeforeFeatureHook()
        {
            Console.WriteLine("BeforeFeature");
        }

        [BeforeScenario]
        public static void BeforeScenarioHook()
        {
            Console.WriteLine("BeforeScenario");
        }

        [AfterFeature]
        public static void AfterFeatureHook()
        {
            Console.WriteLine("AfterFeature");
        }

        [AfterScenario]
        public static void AfterScenarioHook()
        {
            Console.WriteLine("AfterScenario");
        }
    }
}