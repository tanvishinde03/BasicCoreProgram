using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public  class EvenAndOdd
    {

        public void checkevenorodd()
        {
            int Number;
            Console.Write("Enter The Number: ");
            Number = int.Parse(Console.ReadLine());
            if (Number % 2 == 0)
            {
                Console.Write("Entered Number is an Even Number");
            }
            else
            {
                Console.Write("Entered Number is an Odd Number");
            }
            Console.Read();
        }
    }













}

