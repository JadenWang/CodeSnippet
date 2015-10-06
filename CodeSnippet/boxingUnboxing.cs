
using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;


namespace Exmaple
{

    public class ExampleClass
    {

        public static void Main(string[] args)
        {

            int i = 10;
            object O = i;  // boxing to object (to heap)
            int j = (int)O; // unboxing to int (to stack)
        }

    }

}





