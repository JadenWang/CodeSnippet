
using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;


namespace Exmaple
{

    public class ExampleClass
    {

        public delegate int DelegateGreeting(string address);

        static void Main()
        {
            DelegateGreeting del = x => { Console.WriteLine("Welcome {0} to {1}", "Arab", x); System.Threading.Thread.Sleep(1000); return 2; };

            IAsyncResult AsycRes = del.BeginInvoke("California", CallBackMethod, null);

            Console.ReadLine();
        }


        public static void CallBackMethod(IAsyncResult res)
        {
            int result = (((res as AsyncResult).AsyncDelegate) as DelegateGreeting).EndInvoke(res);
            Console.WriteLine("result number is: {0}", result);
        }
    }

}





