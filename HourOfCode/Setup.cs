using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HourOfCode
{
    class Setup
    {
        public static void Start()
        {
            string myFord = "ford";
            string myChevy = "chevy";
            string myDodge = "dodge";


            Console.Clear();
            Console.Write("Type the company you would like to learn about: ");
            FontChange.redText("Ford");
            Console.Write(",");
            FontChange.redText(" Chevy");
            Console.Write(",");
            Console.Write(" or ");
            FontChange.redText("Dodge");
            Console.Write(".");
            Console.WriteLine("");



            string input = Console.ReadLine();

            switch (input.ToLower())
            {
                case "ford":
                    Ford.MyFord();
                    break;
                case "chevy":
                    Chevy.MyChevy();
                    break;
                case "dodge":
                    Dodge.MyDodge();
                    break;
                default:
                    Console.WriteLine("Error!");
                    System.Threading.Thread.Sleep(2000);
                    Console.Clear();
                    Setup.Start();
                    break;
            }
            




        }
    }
}
