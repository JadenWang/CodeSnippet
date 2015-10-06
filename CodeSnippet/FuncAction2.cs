﻿
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
            //GreetingPeople("California", GreetingArab);

            //GreetingPeople("New York", (address) => { Console.WriteLine(string.Format("Welcome {0} to {1}", "Bob", address)); });

            //GreetingPeople("New York", (address) => 
            //    { 
            //        Console.WriteLine(string.Format("Welcome {0} to {1}", "Arab", "California"));
            //        Console.WriteLine(string.Format("Welcome {0} to {1}", "Bob", address));
            //    }
            //);

            //GreetingPeople("California", GreetingColin);
            //GreetingPeople("California", GreetingArab);

            //GreetingPeople("California", (string addr) => { Console.WriteLine(string.Format("Welcome {0} to {1}", "Bb", addr)); });

            //GreetingPeople("California", (string addr) => { Console.WriteLine(string.Format("Welcome {0} to {1}", "Bb", addr)); return "finished greeting."; });

            GreetingPeople("California", (string addr, string city) => { Console.WriteLine(string.Format("Welcome {0} to {1} - {2}", "Bob", addr, city));});


            GreetingPeople("California", ( addr,  city) => { Console.WriteLine(string.Format("Welcome {0} to {1} - {2}", "Bob", addr, city)); });
        }
    }

}





