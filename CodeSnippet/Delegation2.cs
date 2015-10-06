
using System;

namespace Exmaple
{

    public class ExampleClass
    {

        public delegate void DeleteGreeting(string adderss);

        private static void GreetingArab(string address)
        {
            Console.WriteLine(string.Format("Hello {0} from {1}", "Arab", address));
        }

        private static void GreetingBob(string address)
        {
            Console.WriteLine(string.Format("Hello {0} from {1}", "Bob", address));
        }

        private static void GeetingPeople(string address, DeleteGreeting delegateFunc)
        {

            delegateFunc(address);
        }

        static void Main()
        {
            GeetingPeople("California", GreetingArab);
        }
    }

}





