using System;

namespace Project_Standard_NETCore_Framework
{
    public class MTBKernel
    {
        public static string Name()
        {
            string printContent = "";

#if NETSTANDARD2_0
            printContent = "MTBKernel Target framework: .NET Standard 2.0";
#elif NET461
             printContent = "MTBKernel Target framework: .NET Framework 4.6.1";
#elif NETCOREAPP3_1
             printContent = "MTBKernel Target framework: .NET Core 3.1";
#else
             printContent = "MTBKernel Unknown Target framework";
#endif

            Console.WriteLine(printContent);
            return printContent;
        }
    }
}
