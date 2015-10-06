
using System;

namespace Exmaple
{
    public class ExampleClass
    {


        private static void GreetingArab(string address)
        {
            Console.WriteLine(string.Format("Hello {0} from {1}", "Arab", address));
        }

        private static void GreetingBob(string address)
        {
            Console.WriteLine(string.Format("Hello {0} from {1}", "Bob", address));
        }

        static void Main()
        {
            GreetingArab("California");
            GreetingBob("New York");
        }
    }

}





