using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vonglap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // vong lap hinh chu nhat
            /*for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 7; j++)
                {
                    Console.Write(" * ");
                }
                Console.WriteLine();
            }
            */
            //botton left
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" * ");
                }
                Console.WriteLine();
            }


        }
    }
}
