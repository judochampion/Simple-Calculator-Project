using Calculator_Core;
using System;

namespace Basic_Client
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var lovInstance = new Calculator_Instance();
            lovInstance.Process("1");
            lovInstance.Process("1");
            lovInstance.Process("1");
            lovInstance.Process("-");
            lovInstance.Process("3");
            lovInstance.Process("3");
            lovInstance.Process("=");
            Console.WriteLine("My Answer is " + lovInstance.Current_Answer);
        }
    }
}