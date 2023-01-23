using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int year;
            Console.Write("Enter the Year :");
            year = Convert.ToInt32(Console.ReadLine());
            if ((year % 4 == 0))
                Console.WriteLine("{0} Високосный", year);
            else
                Console.WriteLine("{0} не високосный   ", year);


            Console.ReadLine();
        }
    }
        }
        
    

