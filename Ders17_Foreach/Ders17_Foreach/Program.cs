using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders17_Foreach
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] dizim = new int[3];

            dizim[0] = 14;
            dizim[1] = 123;
            dizim[2] = 213;


            foreach (int item in dizim)
            {
                Console.WriteLine(item);
            }

            Console.Read();
        }
    }
}
