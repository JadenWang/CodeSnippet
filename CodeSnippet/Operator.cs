
using System;

namespace Exmaple
{
    class Example
    {
        static void Main(string[] argv)
        {
            string param1 = null;
            string param2 = "param 2";

            MyFunc(1 | 2);

        }

        static void MyFunc(string param)
        {
            if (!string.IsNullOrEmpty(param) && !string.IsNullOrWhiteSpace(param))
            {
                Console.WriteLine(param);
            }
        }

        static void MyFunc(int param)
        {
            Console.WriteLine(param);
        }

        static void MyFunc(Type param)
        {
            //Console.WriteLine(param);
        }

        enum Call
        {
            onload,
            onInit,
            onPreRender
        }
    }
}





