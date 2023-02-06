using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
        public class PowerOfTwo
        {
            public void Power()
            {
                Console.WriteLine("Enter the power");
                int powerNum = Convert.ToInt32(Console.ReadLine());

                for (int i = 1; i < powerNum; i++)
                {
                    int table = (int)Math.Pow(2, i);
                    Console.WriteLine(table);
                }
            }
        }
















    
}
