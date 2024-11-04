using System;

namespace Delegates
{
    public class Joiner
    {
        private string firstString;

        public Joiner(string firstString)
        {
            this.firstString = firstString;
        }

        public void JoinAnPrint(string secondString)
        {
           Console.WriteLine(firstString + secondString);
        }
    }
    
}