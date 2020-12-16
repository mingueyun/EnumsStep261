using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsStep261
{
    class Program
    {
        static void Main(string[] args)
        {

            Weeks week = new Weeks();
            week.DaysOfTheWeek = new DaysOfTheWeek();

            Console.WriteLine("what day of the week is it? ");


            bool input = false;
            while (input == false)
            {
                try
                {
                    DaysOfTheWeek today = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), Console.ReadLine(), true);
                    Console.WriteLine("You think today is: {0}", today.ToString());
                    input = true;
                }
                catch (Exception )
                {
                    Console.WriteLine("Please enter an actual day of the week:");
                }
            }
            Console.ReadLine();

        }
    }
}
