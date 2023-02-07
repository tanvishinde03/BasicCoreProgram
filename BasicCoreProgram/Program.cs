﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1.FlipCoin \n 2. Leap year \n 3. Poweroftwo \n 4. Harmonic \n 5. Factors \n 6. QR \n 7. SwapNumber \n 8 .EvenAndOdd \n 9. VowelorConstant \n  10. Largest \n");
            Console.WriteLine("Enter the option");

            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    FlipCoin flipcoin = new FlipCoin();
                    FlipCoin.Checkflipcoin();
                    break;


                case 2:
                    LeapYear leapyearr = new LeapYear();
                    leapyearr.CheckLeapYear();
                    break;


                case 3:

                    PowerOfTwo obj = new PowerOfTwo();
                    obj.Power();
                    break;


                case 4:
                    Harmonic objj = new Harmonic();
                    objj.Harmonicnumber();
                    break;

                case 5:
                    Factors Obj = new Factors();
                    Obj.checkfactors();
                    break;

                case 6:
                    QR obJ = new QR();
                    obJ.checkQR();
                    break;


                case 7:
                    SwapNumber Swap = new SwapNumber();
                    Swap.checkswap();
               
                    break;

                case 8:
                    EvenAndOdd ENO = new EvenAndOdd();
                    ENO.checkevenorodd();
                    break;

                case 9:
                    VowelorConstant ABC = new VowelorConstant();
                    ABC.checkVowelsOrConstant();
                    break;
                case 10:
                    Largest PQR = new Largest();
                    PQR.checkLargestNumber();
                    break;
            }
            Console.ReadLine();
        }
    }
}
