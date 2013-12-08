using System;

namespace FuncMagic
{
    //A delegate is a reference type that can be used to encapsulate a named or an anonymous method. Delegates are similar to function pointers in C++; however, delegates are type-safe and secure.

    //following is an example of the generic delegate
    internal delegate T Transform<T>(T args);

    internal class Program
    {
        public readonly int x = 5;

        private static void Main()
        {
            Console.WriteLine(x);
            Console.ReadLine();
        }
    }
}//end namespace