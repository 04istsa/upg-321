using System;

namespace upg_321
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("DU ska skriva in anntingen två tal plus varandra eller tre tal plus varandra");
            string numStr = Console.ReadLine();
            int plus = numStr.IndexOf("+");

            string num1 = numStr[..plus];
            double förstaTalet = double.Parse(num1);

            string num2 = numStr[(plus + 1)..];
            //string efterAndraPlus = numStr

            if (num2.Contains("+"))
            {
                int andraPlus = num2.IndexOf("+");
                    string mellanPlus = num2[..andraPlus];

                double andraTalet = double.Parse(mellanPlus);

                string efterAndraPlus = num2[(andraPlus + 1)..];
                double tredjeTalet = double.Parse(num2);
                Console.WriteLine($"Uttryck värde är {förstaTalet + andraTalet + tredjeTalet}");
            }
            else
            {
                double andraTalet = double.Parse(num2);
                Console.WriteLine($"Uttrycket värde är{num1 + andraTalet}");
            }
            //int num = int.Parse(());
            
        }
    }
}
