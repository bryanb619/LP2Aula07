using System;

namespace Delegates
{
    public class Program
    {

        public static void PrintUpper(string str)
        {
            Console.WriteLine(str.ToUpper());
        }

        public static void PrintLower(string str)
        {
            Console.WriteLine(str.ToLower());
        }

        private static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            StringOp strOp = null;

            strOp += PrintUpper;

            strOp += PrintLower;

            Joiner joiner = new Joiner("nada");

            strOp += joiner.JoinAnPrint;

            strOp.Invoke("tudo");
            
        }
    }
}
