
using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;


namespace Exmaple
{

    public class ExampleClass
    {

        public static void Main(string[] args)
        {
            MyClass imc = new MyClass();
            
            imc.ID = 1;
            imc.name = "mc1";

            object omc = imc;
            MyClass mc = (MyClass)omc;
            
            mc.MyFunc();
        }

    }


    public class MyClass
    {
        public int ID;
        public string name;

        public MyClass()
        {

        }

        public void MyFunc()
        {
            Console.WriteLine("ID: {0}; Name: {1}", ID, name);
        }
    }
}





