
using System;
using System.Collections.Generic;


namespace Exmaple
{

    public class ExampleClass
    {

        public delegate void DeleteGreeting(string adderss);

        private static void GreetingArab(string address)
        {
            Console.WriteLine(string.Format("Welcome {0} to {1}", "Arab", address));
        }

        private static void GreetingBob(string address)
        {
            Console.WriteLine(string.Format("Welcome {0} to {1}", "Bob", address));
        }

        private static string GreetingColin(string address)
        {
            Console.WriteLine(string.Format("Welcome {0} to {1}", "colin", address));
            return "Greeting Finished";
        }

        //private static void GreetingPeople(string address, DeleteGreeting delegateFunc)
        //{
        //    delegateFunc(address);
        //}

        private static void GreetingPeople(string address, Func<string, string> func)
        {
            Console.WriteLine("status: " + func(address));
        }

        private static void GreetingPeople(string address, Action<string> func)
        {
            func(address);
        }

        private static void GreetingPeople(string address, Action<string, string> func)
        {
            func(address, "Redwood City");
        }

        static void Main()
        {
            //Action<string> func = GreetingArab;
            //GreetingPeople("New York", func);

            //Action<string> func = new Action<string>(GreetingArab);
            //GreetingPeople("New York", func);


            //GreetingPeople("New York", delegate(string addr) { Console.WriteLine("Welcom {0} to {1}", "Arab", addr); return "Finished greeting."; });

            GreetingPeople("New York", x => Console.WriteLine("Welcom {0} to {1}", "Arab", x));
        }
    }

}





