using System;

namespace FactoryPatternApp
{
    class AndroidPhone : ICallable
    {
        public void Build()
        {
            ConsoleLogging.PhoneBuildDialogue();
            Console.WriteLine("Building an Android phone!");
        }
    }
}

