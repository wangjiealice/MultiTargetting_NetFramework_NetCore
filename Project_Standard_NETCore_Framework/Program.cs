using Project_Standard16;
using Project_Standard20;
using System;

namespace Project_Standard_NETCore_Framework
{
    class Program
    {
        static void Main(string[] args)
        {
            Standard20 standard20 = new Standard20() { };
            Standard16 standard16 = new Standard16() { };

#if NETSTANDARD2_0
            Console.WriteLine("Target framework: .NET Standard 2.0");
#elif NET461
            Console.WriteLine("Target framework: .NET Framework 4.6.1");
#elif NETCOREAPP3_1
            Console.WriteLine("Target framework: .NET Core 3.1");
#else
            Console.WriteLine("Unknown Target framework");
#endif
            Console.WriteLine("Name is " + standard20.Name);
            Console.WriteLine("Name is " + standard16.Name);

            Console.ReadKey();
        }
    }
}
