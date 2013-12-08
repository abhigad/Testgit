using System;
//git source control plugin details availble @ http://gitscc.codeplex.com/documentation 
//this is ab

namespace FuncMagic
{
    //A delegate is a reference type that can be used to encapsulate a named or an anonymous method. Delegates are similar to function pointers in C++; however, delegates are type-safe and secure.

    //following is an example of the generic delegate
    internal delegate T Transform<T>(T args);
    /// <summary>
    /// This is a test and a bug fix
    /// </summary>
    internal class Program
    {
        public static readonly int x = 5;

        private static void Main()
        {
            Console.WriteLine(x);
            Console.ReadLine();
        }
    }
}//end namespace