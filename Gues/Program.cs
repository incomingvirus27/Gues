using System;

namespace Gues
{
    class Program
    {       
        static void Main(string[] args)
        {
            Ilearning d;
            d = new Learn();
            d.draw();
            Learn item = new Learn();
            
            Console.WriteLine("The mulitiplication of the following numbers {0} and {1} is:", item.num(5, 6));
            DateTime gradDay = new DateTime(2020, 2, 28);
            Console.WriteLine(gradDay.ToString("MM/dd/yyyy"));            
        }
    }
}
