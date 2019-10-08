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
            while (true)

            {
                char c = Console.ReadKey().KeyChar;
                Console.WriteLine(Char2Code(c));
          
            }
        }
    
        public static void Print_a_2_z_v1()
        {
            for (char c ='a'; c <= 'z';c++ )
            {
                Console.WriteLine (c);


            }
        }
        public static int Char2Code(char c)
        {
            return (int)c;

        }

    }
}
