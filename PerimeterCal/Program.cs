using System;

namespace PerimeterCal
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1, b, s2, l, w, s;
            string ch;
            try
            {
                do
                {
                    Console.WriteLine("Please enter your choice:");
                    Console.WriteLine("1. Perimeter of the Triangle");
                    Console.WriteLine("2. Perimeter of the Rectangle");
                    Console.WriteLine("3. Perimeter of the Square");
                    int choice = int.Parse(Console.ReadLine());
           
                    switch(choice)
                    {
                        case 1: Console.WriteLine("Please enter the following: side1, base, side2:");
                                s1 = int.Parse(Console.ReadLine());
                                b = int.Parse(Console.ReadLine());
                                s2 = int.Parse(Console.ReadLine());
                                Math obj = new Math(s1, b, s2);
                                int res1 = obj.CalculatePerimeter(s1, b, s2);
                                Console.WriteLine("The Perimeter of the Triangle is: {0}", res1);
                                break;

                        case 2: Console.WriteLine("Please enter the following: length, width:");
                                l = int.Parse(Console.ReadLine());
                                w = int.Parse(Console.ReadLine());
                                Math obj1 = new Math(l, w);
                                int res2 = obj1.CalculatePerimeter(l, w);
                                Console.WriteLine("The Perimeter of the Rectangle is: {0}", res2);
                                break; 

                        case 3: Console.WriteLine("Please enter the following: side:");
                                s = int.Parse(Console.ReadLine());
                                Math obj2 = new Math(s);
                                int res3 = obj2.CalculatePerimeter(s);
                                Console.WriteLine("The Perimeter of the Square is: {0}", res3);
                                break;
                    }
                    Console.WriteLine("Would you like to continue?");
                    ch = (Console.ReadLine()).ToUpper();
                }while(ch == "YES");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
