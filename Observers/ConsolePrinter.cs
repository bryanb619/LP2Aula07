using System;

namespace Observers
{
    public class ConsolePrinter : IObserver<AbstractStringSubject>
    {
        public void Update(AbstractStringSubject sub)
        {
            Console.WriteLine($"ConsolePrint: {sub.Item}");
        }
    }
}