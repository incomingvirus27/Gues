using System;
using System.Collections.Generic;
using System.Text;

namespace Gues
{
    class Learn : Ilearning
    {
       
       public void draw()
        {
            Console.WriteLine("Drawing rectangle");
        }
        public int num(int a, int b)
        {            
            return a * b;
        }
    }
}
