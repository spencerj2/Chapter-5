using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckZip
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] zip = { 12985, 12746, 46573, 15360, 22647, 35065, 74635, 74537, 64058, 64420 };
            for (int i = 0; i < zip.Length; i++)
            {
                Console.Write("Enter A Zip Code: ");
                int input = Convert.ToInt32(Console.ReadLine());

                if (input == zip[i])
                {
                    Console.WriteLine("We Deliver There (:");
                    break;
                }
                else
                {
                    Console.WriteLine("We Dont Deliver There ):");
                    break;
                }
            }

        }
    }
}
