using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                //Prompts user to enter Length and Width
                Console.WriteLine("Please enter the Lenth of the room");
                String inputLength = Console.ReadLine();
                Console.WriteLine("Please enter the Width of the room");
                String inputWidth = Console.ReadLine();

                //The application displays the area
                double Length = double.Parse(inputLength);
                double Width = double.Parse(inputWidth);
                double area = Length * Width;
                Console.WriteLine("Area: {0}", area);

                //The application displays the perimeter
                double perimeter = (2 * Length) + (2 * Width);
                Console.WriteLine("Perimeter: {0}", perimeter);

                Console.WriteLine("Would you like to continue? Yes or No");

            } while (Console.ReadLine() == "Yes");
                Console.WriteLine("Okay, Goodbye!");


        }
    }
}
