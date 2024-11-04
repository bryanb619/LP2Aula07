using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Observers
{
    public class KeyReader : AbstractStringSubject
    {
       public void ReadKeys()
       {

            ConsoleKey key;

            while(true) 
            {
                
                key = Console.ReadKey(true).Key;

                if (key == ConsoleKey.Escape) break;

                Item = key.ToString();
            }
       }
    }

}