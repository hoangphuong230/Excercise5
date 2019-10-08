using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise5a
{
    class Program
    {
        static void Main(string[] args)
        {
            Print_a_2_z_v1();
        }

        public static void Print_a_2_z_v1()
        {
            for (char c ='a'; c <= 'z';c++ )
            {
                Console.WriteLine (c);


            }
        }
    }
}
