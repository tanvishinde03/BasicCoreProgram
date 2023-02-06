using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class FlipCoin
    {
        public static void Checkflipcoin()
        {

            int CountTail = 0;
            int CountHead = 0;

            Console.WriteLine("Enter the number of time the coin flips");
            int flipnum = Convert.ToInt32(Console.ReadLine());

            Random random = new Random();
            for (int i = 0; i < flipnum; i++)
            {
                double NumCheck = random.NextDouble();
                if (NumCheck > 0.5)
                    CountTail++;
                else
                    CountHead++;
            }
            Console.WriteLine(CountHead + " " + CountTail);
            float headPercentage = (float)CountHead / flipnum * 100;
            float tailpercentage = (float)CountTail / flipnum * 100;
            Console.WriteLine(headPercentage + " " + tailpercentage);

            Console.ReadLine();
        }


    }













    }

