using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klaphop
{
    class Program
    {
        /// <summary>
        /// mål ved hver der går op i 3 klap ved hver der går op i 5 hop går de op i begge klap og hop
        /// </summary>
        /// <param name="args"></param>

        

        static void Main(string[] args)
        {


            for (int i = 1; i < 31; i++)
            {
                if (i % 3 == 0)
                {
                    if (i % 5 == 0)
                    {
                        Console.WriteLine("klap hop");
                    }
                    else
                    {
                        Console.WriteLine("klap");
                    }
                    
                }

                else if (i % 5 == 0)
                {
                    Console.WriteLine("hop");
                }
                else
                {
                    Console.WriteLine(i);
                }

                
            }



            Console.ReadLine();
        }
    }
}
