using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace FactoryPatternApp
{
    class ApplePhone : ICallable
    {
        public void Build()
        {
            ConsoleLogging.PhoneBuildDialogue();
            Console.WriteLine("Building an Apple phone!");
        }
    }
}
