using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            HR h1 = new HR(1,8000,"Hitesh","HR",4,"12/4/1997");
            Devloper d1 = new Devloper(1, 8000, "sohesh", "Devloper", 5, "12/4/1997");
            var a = h1.Annual_Salary();
            Console.WriteLine("Devloper Annual Salary:-{0}", a);
            var b = d1.Annual_Salary();
            Console.WriteLine("Devloper Annual Salary:-{0}", b);
        }
    }
}
