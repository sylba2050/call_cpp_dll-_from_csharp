using System;
using System.Runtime.InteropServices;

namespace call_dll_test
{
    class Program
    {
        [DllImport("arithmetic.dll", EntryPoint = "add")]
        static extern int add(int a, int b);

        static void Main()
        {
            Console.WriteLine("2 + 3 = {0}", add(2, 3));
            Console.WriteLine("4 + 5 = {0}", add(4, 5));
            while (true) ;
        }
    }
}
