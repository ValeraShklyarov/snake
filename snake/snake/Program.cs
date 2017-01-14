using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.SetBufferSize(80, 25);

            HorizontalLine topLine = new HorizontalLine(0,78,0,'*');
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '*');
            VerticalLine leftLine = new VerticalLine(0, 0, 24, '*');
            VerticalLine rightLine = new VerticalLine(78, 0, 24, '*');
            topLine.Drow();
            downLine.Drow();
            leftLine.Drow();
            rightLine.Drow();


            Console.ReadLine();
        }

        
    }
}
