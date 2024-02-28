using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace KonBanegaCrorepati
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StartKBC startkbc = new StartKBC();
            Console.WriteLine("\t\t\t\t Welcome to KBC Please Register Yourself to Play \n");
            Console.Write("Please Enter Your Name: ");
            string username = Convert.ToString(Console.ReadLine());
            if (string.IsNullOrEmpty(username))
            {
                Recursion();
            }
            else
            {
                startkbc.Start(username);
            }
            Console.WriteLine("Please Enter any key to exit.....");
            Console.ReadKey();
        }


        static void Recursion()
        {
            Console.Write("Please Enter Your Name: ");
            string username = Convert.ToString(Console.ReadLine());

            if (string.IsNullOrEmpty(username))
            {
                Recursion();
            }
            else
            {
                StartKBC startkbc = new StartKBC();
                startkbc.Start(username);
            }
        }
    }
}
