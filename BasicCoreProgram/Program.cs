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
            Console.WriteLine("1.FlipCoin \n 2. Leap year \n 3. Poweroftwo \n 4. Harmonic \n");
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





            }
            Console.ReadLine();
        }
    }
}
