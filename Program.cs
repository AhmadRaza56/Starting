using System;

namespace Starting
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;

            while (repeat)
            {
                Console.WriteLine("please enter the width of the wall in meters");
                double width = int.Parse(Console.ReadLine());
                Console.WriteLine("please enter the height of the wall meters");
                double height = int.Parse(Console.ReadLine());
                double total = height * width;
                Console.WriteLine("The total area of the wall is " + total + "m^2");
                Console.WriteLine("1 litre of pain covers approx 12m^2");
                double paintNeeded = Math.Round(total / 12);
                Console.WriteLine("You will need " + paintNeeded + " litres of paint");
                Console.WriteLine("You will need " + paintNeeded + " of the small size or " + (paintNeeded / 5) + " of medium size or " + (paintNeeded / 10) + " of large size can");
                Console.WriteLine("What size paint would you like? small for 1 litre, medium for 5 litre or large for 10 litre");
                string size = Console.ReadLine();

                if (size == "small" || size == "1")
                {
                    Console.WriteLine("Would you like the £8 single coat, the £10 double coat or the £20 Finish?");
                    int price = int.Parse(Console.ReadLine());

                    switch (price)
                    {
                        case 8:
                            double cost = paintNeeded * 8;
                            Console.WriteLine("price is £" + cost);
                            break;
                        case 10:
                            double cost2 = paintNeeded * 10;
                            Console.WriteLine("price is £" + cost2);
                            break;
                        case 20:
                            double cost3 = paintNeeded * 20;
                            Console.WriteLine("price is £" + cost3);
                            break;
                    }
                    Console.ReadLine();
                }
                else if (size == "medium" || size == "5")
                {
                    Console.WriteLine("Would you like the £10 single coat, the £15 double coat or the £25 Finish?");
                    int price = int.Parse(Console.ReadLine());

                    switch (price)
                    {
                        case 10:
                            double cost = paintNeeded * 10;
                            Console.WriteLine("price is £" + cost);
                            break;
                        case 15:
                            double cost2 = paintNeeded * 15;
                            Console.WriteLine("price is £" + cost2);
                            break;
                        case 25:
                            double cost3 = paintNeeded * 25;
                            Console.WriteLine("price is £" + cost3);
                            break;
                    }
                    Console.ReadLine();
                }
                else if (size == "large" || size == "10")
                {
                    Console.WriteLine("Would you like the £15 single coat, the £20 double coat or the £30 Finish?");
                    int price = int.Parse(Console.ReadLine());

                    switch (price)
                    {
                        case 15:
                            double cost = paintNeeded * 15;
                            Console.WriteLine("price is £" + cost);
                            break;
                        case 20:
                            double cost2 = paintNeeded * 20;
                            Console.WriteLine("price is £" + cost2);
                            break;
                        case 30:
                            double cost3 = paintNeeded * 30;
                            Console.WriteLine("price is £" + cost3);
                            break;
                    }
                    Console.ReadLine();
                }
                Console.WriteLine("Would you like to reuse the paint calculator?");
                string repeating = Console.ReadLine();
                if (repeating == "yes")
                {
                    repeat = true;
                }
                else if (repeating == "no")
                {
                    repeat = false;
                }                    
            }
            

        }
    }
}
