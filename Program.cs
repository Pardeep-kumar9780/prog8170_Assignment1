using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog8170_Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating instance of Rectangle class in order to pass the values to attributes (Length and Width).
           
            Rectangle rectangle = new Rectangle();
            int rectlength = rectangle.Length;
            int rectwidth = rectangle.Width;
            /// Initializing variables for the input
            string length = string.Empty;
            string width = string.Empty;
            string userinput = string.Empty;
            bool validMenuSelection = false;
            Console.WriteLine("");
            Console.WriteLine("Initially values of Length and Width is 0");
            Console.WriteLine("------------------------------------------------------------------------------------");
            // Menu selection
            while (validMenuSelection == false)
                {
                    Console.WriteLine("Enter 1 to Get Rectangle Length");
                    Console.WriteLine("Enter 2 to Change Rectangle Length");
                    Console.WriteLine("Enter 3 to Get Rectangle Width");
                    Console.WriteLine("Enter 4 to Change Rectangle Width");
                    Console.WriteLine("Enter 5 to Get Rectangle Parameter");
                    Console.WriteLine("Enter 6 to Get Rectangle Area");
                    Console.WriteLine("Enter 7 to Exit");
                userinput = Console.ReadLine();
                switch (userinput)
                {
                    case "1":
                        Console.WriteLine("Length of the Rectangle is : {0} ", rectangle.GetLength());
                        break;
                    case "2":

                        Console.WriteLine("Enter New Length");

                        length = Console.ReadLine();

                        // Validating values of the Length

                        if ((!int.TryParse(length, out rectlength)) && (rectlength <= 0))
                        {

                            Console.WriteLine("Please enter valid length");
                            Console.WriteLine("");

                        }
                        else
                        {
                            Console.WriteLine("New Length of the rectangle is : {0} ", rectangle.SetLength(rectlength));
                        }
                         break;
                        case "3":
                            Console.WriteLine("Width of the Rectangle is : {0} ", rectangle.GetWidth());
                            break;
                        case "4":
                            Console.WriteLine("Enter new width");
                            width = Console.ReadLine();
                        // Validating values of the Width
                        if ((!int.TryParse(width, out rectwidth)) && (rectwidth <= 0))
                        {
                            Console.WriteLine("Please enter valid width");
                            Console.WriteLine("");
                        }
                        else
                        {
                            Console.WriteLine("New Width of the rectangle is : {0} ", rectangle.SetWidth(rectwidth));
                        }
                            break;
                        case "5":
                            Console.WriteLine("Perimeter of the Rectangle : {0} ", rectangle.GetPerimeter());
                            break;
                        case "6":
                            Console.WriteLine("Area of the Rectangle is : {0} ", rectangle.GetArea());
                            break;
                        case "7":
                            System.Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Please enter correctly");
                            break;
                           
                }
                    

            }


        }

            
    }



}


