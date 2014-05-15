using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace burbuja
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int m=0;
            int[] burbuja = new int[5];
            burbuja[0] = 14;
            burbuja[1] = 32;
            burbuja[2] = 80;
            burbuja[3] = 50;
            burbuja[4] = 18;

            for (int i = 0; i < 5; i++) 
            {
                for (int n = 0; n < 4; n++)
                {
                    if (burbuja[n] < burbuja[n + 1])
                    {
                        m = burbuja[n];
                        burbuja[n] = burbuja[n + 1];
                        burbuja[n + 1] = m;
                    }
                
                }               
            }
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Green;
            for(int i=0;i<5;i++)
            {
            Console.WriteLine("la burbuja es: " + burbuja[i] + "\n");
            
            }
            Console.Read();
          

        }
    }
}
