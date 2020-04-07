using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\t What is your classification code? B, D, W? : \t ");
            string classification = Console.ReadLine().ToUpper();

            Console.Write("\t How many days was the vehicle rented? : \t ");
            int numofdays = int.Parse(Console.ReadLine());

            Console.Write("\t What was the vehicle's odometer reading at the start of the rental period: \t ");
            float startodam = float.Parse(Console.ReadLine());

            Console.Write("\t What is the vehicle's odometer reading at the end of the rental period: \t ");
            float endodam = float.Parse(Console.ReadLine());

            float mileage = (float)(endodam - startodam);
            int week = (int)(numofdays / 7);
            float basefee1 = (float)(40.0 * numofdays);
            float basefee2 = (float)(60.0 * numofdays);
            float basefree3 = (float)(190.0 * week);

            if (classification == "B")
            {
                Console.WriteLine("Classification code: \t B");
                Console.WriteLine("# of days vehicle was rented: \t" + numofdays + " days");
                Console.WriteLine("Vehicle's odometer reading at start: \t" + startodam);
                Console.WriteLine("Vehicle's odometer reading at end: \t" + endodam);
                Console.WriteLine("Total # of miles driven during rental period: \t" + mileage + " miles");
                Console.WriteLine("Base charge: \t$" + basefee1.ToString("0.00"));
                Console.WriteLine("mileage charge: \t$" + (mileage * 0.25).ToString("0.00"));
                Console.WriteLine("Total bill: \t$" + (basefee1 + (mileage * 0.25)).ToString("0.00"));
            }
            else if (classification == "D")
            {
                Console.WriteLine("Classification code: \t D");
                Console.WriteLine("# of days vehicle was rented: \t" + numofdays + " days");
                Console.WriteLine("Vehicle's odometer reading at start: \t" + startodam);
                Console.WriteLine("Vehicle's odometer reading at end: \t" + endodam);
                Console.WriteLine("Total # of miles driven during rental period: \t" + mileage + " miles");
                Console.WriteLine("Base charge: \t$" + basefee2.ToString("0.00"));
                if (mileage <= 100)
                {
                    Console.WriteLine("mileage: \t no charge");
                    Console.WriteLine("Total bill: \t$" + basefee2.ToString("0.00"));
                }
                else
                {
                    Console.WriteLine("mileage: \t$" + (mileage * 0.25).ToString("0.00"));
                    Console.WriteLine("Total bill: \t$" + (basefee2 + (mileage * 0.25)).ToString("0.00"));
                }
            }
            else if (classification == "W")
            {
                Console.WriteLine("Classification code: \t W");
                Console.WriteLine("# of days vehicle was rented: \t" + numofdays + " days");
                Console.WriteLine("Vehicle's odometer reading at start: \t" + startodam);
                Console.WriteLine("Vehicle's odometer reading at end: \t" + endodam);
                Console.WriteLine("Total # of miles driven during rental period: \t" + mileage + " miles");
                if (mileage <= 900)
                {
                    Console.WriteLine("mileage: \t no charge");
                    Console.WriteLine("Total bill: \t$" + basefree3.ToString("0.00"));
                }
                else if (mileage > 900 && mileage <= 1500)
                {
                    Console.WriteLine("mileage charge: \t$" + (100.0 * week).ToString("0.00"));
                    Console.WriteLine("Total bill: \t$" + (basefree3 + (100.0 * week)).ToString("0.00"));
                }
                else
                {
                    Console.WriteLine("mileage charge: \t$" + ((200.0 * week) + (0.25 * mileage)).ToString("0.00"));
                    Console.WriteLine("Total bill: \t$" + (basefree3 + ((200.0 * week) + (0.25 * mileage))).ToString("0.00"));
                }
            }





            Console.ReadKey();
        }
    }
}
