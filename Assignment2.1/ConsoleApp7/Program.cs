using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = 0.06f;
            var y = 5.94f;
            Console.WriteLine("Sum Of X and y{0}:-",x + y);

            Console.WriteLine("Equals:-{0}",(x + y).Equals(6));

            Console.WriteLine(Garter(x, y));
             string Garter(float x1,float y1)
            {
                if (x1 > y1)
                    return "X is Grater";
                else
                    return "Y is Grater";

            }
        }
    }
}
