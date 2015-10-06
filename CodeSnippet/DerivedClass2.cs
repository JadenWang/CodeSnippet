
using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;


namespace Exmaple
{

    public class ExampleClass
    {

        public static void Main(string[] args)
        {
            MyClass mc = new MyClass();
            mc.ID = 1;
            mc.name = "mc1";
            mc.value = "mcvalue1";

            IClass imc = mc;
            MyClass nmc = (MyClass)imc;

            nmc.MyFunc();
        }

    }


    public class IClass
    {
        public int ID;
        public string name;

        public IClass()
        {

        }

        public void IFunc()
        {
            Console.WriteLine("ID: {0}; Name: {1}", ID, name);
        }
    }

    public class MyClass : IClass
    {
        public string value;

        public MyClass()
        {

        }

        public void MyFunc()
        {
            Console.WriteLine("ID: {0}; Name: {1}; Value: {2}", ID, name, value);
        }

    }
}





