using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SpeedLimit
{
    internal class Program
    {
        public static int speed, yrInSchool, Speed;
        public const double COST_PER_5_OVER = 87.50;
        public static double fine;
        public const int speedLimit = 35, initial = 75, seniorCharge = 50, seniorHighCharge = 200, FRESHMEN_COST_DEDUCTION = 50, OVER_20_SPEEDLIMIT = 100;
        static void Main(string[] args)
        {

            for (; ; )
            {
                try
                {
                    Console.WriteLine("===========================================");
                    Console.WriteLine("          SPEED LIMIT: 35MPH");
                    Console.WriteLine("-------------------------------------------");
                    Console.Write("    ENTER SPEED (MPH): ");
                    speed = Convert.ToInt32(Console.ReadLine());
                    Console.Write("   <1> Freshman\n   <2> Sophomore\n   <3> Junior\n   <4>  Senior\n");
                    Console.Write("   ENTER <NUMBER> YEAR IN SCHOOL: ");
                    yrInSchool = Convert.ToInt32(Console.ReadLine());
                    Speed = speed - 35;

                    if (Speed <= 20 && yrInSchool == 4 && speed > speedLimit)
                    {

                        fine = ((Speed / 5) * COST_PER_5_OVER) + seniorCharge + initial;
                        Console.WriteLine("===========================================");
                        Console.WriteLine("    Student: Senior");
                        Console.WriteLine("    Total charge per 50mph: PHP " + (Speed / 5) * COST_PER_5_OVER);
                        Console.WriteLine("    Charge fo speeding: PHP " + seniorCharge);
                        Console.WriteLine("    Initial charge: PHP " + initial);
                        Console.WriteLine("  ---------------------------------");
                        Console.WriteLine("    Fine: PHP {0}", fine);
                    }
                    else if (Speed > 20 && yrInSchool == 4)
                    {
                        Console.WriteLine("===========================================");
                        fine = ((Speed / 5) * COST_PER_5_OVER) + seniorCharge + initial + seniorHighCharge;
                        Console.WriteLine("    Student: Senior");
                        Console.WriteLine("    Total charge per 50mph: PHP " + (Speed / 5) * COST_PER_5_OVER);
                        Console.WriteLine("    Charge for speeding: PHP " + seniorCharge);
                        Console.WriteLine("    Initial charge: PHP " + initial);
                        Console.WriteLine("  ---------------------------------");
                        Console.WriteLine("    Fine: PHP {0}", fine);
                    }
                    else if (yrInSchool == 4 && speed < speedLimit)
                    {
                        Console.WriteLine("===========================================");
                        Console.WriteLine("    Student: Senior");
                        Console.WriteLine("    Fine: {0}", 0);
                        Console.WriteLine("  --------------------------------------");
                        Console.WriteLine("    You didn't go over the speed limit.");
                    }
                    else if (Speed < 20 && yrInSchool == 1 && speed > speedLimit)
                    {
                        Console.WriteLine("===========================================");
                        fine = (((Speed / 5) * COST_PER_5_OVER) + initial) - FRESHMEN_COST_DEDUCTION;
                        Console.WriteLine("    Student: Freshmen");
                        Console.WriteLine("    Total charge per 50mph: PHP " + (Speed / 5) * COST_PER_5_OVER);
                        Console.WriteLine("    Initial charge: PHP " + initial);
                        Console.WriteLine("    Deduction: PHP " + FRESHMEN_COST_DEDUCTION);
                        Console.WriteLine("  ---------------------------------");
                        Console.WriteLine("    Fine: PHP {0}", fine);

                    }
                    else if (Speed >= 20 && speed > speedLimit && yrInSchool == 1)
                    {
                        Console.WriteLine("===========================================");
                        fine = (((Speed / 5) * COST_PER_5_OVER) + initial) + OVER_20_SPEEDLIMIT;
                        Console.WriteLine("    Student: Freshmen");
                        Console.WriteLine("    Total charge per 50mph: PHP " + (Speed / 5) * COST_PER_5_OVER);
                        Console.WriteLine("    Initial charge: PHP " + initial);
                        Console.Write("    Charge for exceeding 20mph or more\n    over the speed limit: PHP " + OVER_20_SPEEDLIMIT + "\n");
                        Console.WriteLine("  ---------------------------------");
                        Console.WriteLine("    Fine: PHP {0}", fine);

                    }
                    else if (Speed < 20 && speed > speedLimit && yrInSchool == 1)
                    {
                        Console.WriteLine("===========================================");
                        fine = (((Speed / 5) * COST_PER_5_OVER) + initial);
                        Console.WriteLine("    Student: Freshmen");
                        Console.WriteLine("    Total charge per 50mph: PHP " + (Speed / 5) * COST_PER_5_OVER);
                        Console.WriteLine("    Initial charge: PHP " + initial);
                        Console.WriteLine("  ---------------------------------");
                        Console.WriteLine("    Fine: PHP {0}", fine);

                    }
                    else if (Speed > 19 && speed > speedLimit && yrInSchool == 2)
                    {
                        Console.WriteLine("===========================================");
                        fine = (((Speed / 5) * COST_PER_5_OVER) + initial) + OVER_20_SPEEDLIMIT;
                        Console.WriteLine("    Student: Sophomore");
                        Console.WriteLine("    Total charge per 50mph: PHP " + (Speed / 5) * COST_PER_5_OVER);
                        Console.WriteLine("    Initial charge: PHP " + initial);
                        Console.Write("    Charge for exceeding 20mph or more\n    over the speed limit: PHP " + OVER_20_SPEEDLIMIT + "\n");
                        Console.WriteLine("  ---------------------------------");
                        Console.WriteLine("    Fine: PHP {0}", fine);

                    }
                    else if (Speed < 20 && speed > speedLimit && yrInSchool == 2)
                    {
                        Console.WriteLine("===========================================");
                        fine = (((Speed / 5) * COST_PER_5_OVER) + initial);
                        Console.WriteLine("    Student: Sophomore");
                        Console.WriteLine("    Total charge per 50mph: PHP " + (Speed / 5) * COST_PER_5_OVER);
                        Console.WriteLine("    Initial charge: PHP " + initial);
                        Console.WriteLine("  ---------------------------------");
                        Console.WriteLine("    Fine: PHP {0}", fine);

                    }
                    else if (Speed >= 20 && speed > speedLimit && yrInSchool == 3)
                    {
                        Console.WriteLine("===========================================");
                        fine = (((Speed / 5) * COST_PER_5_OVER) + initial) + OVER_20_SPEEDLIMIT;
                        Console.WriteLine("    Student: Junior");
                        Console.WriteLine("    Total charge per 50mph: PHP " + (Speed / 5) * COST_PER_5_OVER);
                        Console.WriteLine("    Initial charge: PHP " + initial);
                        Console.Write("    Charge for exceeding 20mph or more\n    over the speed limit: PHP " + OVER_20_SPEEDLIMIT + "\n");
                        Console.WriteLine("  ---------------------------------");
                        Console.WriteLine("    Fine: PHP {0}", fine);

                    }
                    else if (Speed >= 20 && speed > speedLimit && yrInSchool == 3)
                    {
                        Console.WriteLine("===========================================");
                        fine = (((Speed / 5) * COST_PER_5_OVER) + initial);
                        Console.WriteLine("    Student: Junior");
                        Console.WriteLine("    Total charge per 50mph: PHP " + (Speed / 5) * COST_PER_5_OVER);
                        Console.WriteLine("    Initial charge: PHP " + initial);
                        Console.WriteLine("  ---------------------------------");
                        Console.WriteLine("    Fine: PHP {0}", fine);

                    }
                    else if (speed <= speedLimit && yrInSchool == 3)
                    {
                        Console.WriteLine("===========================================");
                        Console.WriteLine("    Student: Junior");
                        Console.WriteLine("    Fine: {0}", 0);
                        Console.WriteLine("  ---------------------------------------");
                        Console.WriteLine("    You didn't go over the speed limit.");

                    }
                    else if (speed <= speedLimit && yrInSchool == 1)
                    {
                        Console.WriteLine("===========================================");
                        Console.WriteLine("    Student: Freshmen");
                        Console.WriteLine("    Fine: {0}", 0);
                        Console.WriteLine("  ---------------------------------------");
                        Console.WriteLine("    You didn't go over the speed limit.");

                    }
                    else if (speed <= speedLimit && yrInSchool == 2)
                    {
                        Console.WriteLine("===========================================");
                        Console.WriteLine("    Student: Sophomore");
                        Console.WriteLine("    Fine: {0}", 0);
                        Console.WriteLine("  ---------------------------------------");
                        Console.WriteLine("    You didn't go over the speed limit.");
                    }
                }
                catch
                {
                    Console.WriteLine("===========================================");
                    Console.WriteLine("       ! INVALID INPUT. TRY AGAIN. !");
                }
            }
        }
    }
}
