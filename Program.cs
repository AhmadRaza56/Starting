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
                //calculation of wall area
                Console.WriteLine("please enter the width of the wall in foot");
                double width = int.Parse(Console.ReadLine());
                Console.WriteLine("please enter the height of the wall foot");
                double height = int.Parse(Console.ReadLine());
                double total = height * width;
                Console.WriteLine("The total area of the wall is " + total + "ft^2");
                Console.WriteLine("1 litre of pain covers approx 20ft^2");
                Console.ReadLine();

                //calculations for having windows 
                Console.WriteLine("Do you have windows on the wall?");
                string windows = Console.ReadLine();
                if (windows == "yes")
                {
                    int i = 0;
                    Console.WriteLine("How many windows do you have?");
                    int windowsize = int.Parse(Console.ReadLine());
                    //loop to make sure all windows are calculated
                    while (i == windowsize)
                    {
                        Console.WriteLine("please enter the width of the wall in foot");
                        double widthWindow = int.Parse(Console.ReadLine());
                        Console.WriteLine("please enter the height of the wall foot");
                        double heightWindow = int.Parse(Console.ReadLine());
                        double totalWindow = heightWindow * widthWindow;
                        Console.WriteLine("The total area of the window is " + totalWindow + "ft^2");
                        total = total - totalWindow;
                        ++i;
                    }
                    Console.WriteLine("The new total area of the wall is "+ total + "ft^2");
                }

                //calculations for having doors
                Console.WriteLine("Do you have doors on the wall?");
                string doors = Console.ReadLine();
                if (doors == "yes")
                {
                    int i = 0;
                    Console.WriteLine("How many doors do you have?");
                    int doorsize = int.Parse(Console.ReadLine());
                    //loop to make sure all windows are calculated
                    while (i == doorsize)
                    {
                        Console.WriteLine("please enter the width of the door in foot");
                        double widthDoor = int.Parse(Console.ReadLine());
                        Console.WriteLine("please enter the height of the door foot");
                        double heightDoor = int.Parse(Console.ReadLine());
                        double totalDoor = heightDoor * widthDoor;
                        Console.WriteLine("The total area of the door is " + totalDoor + "ft^2");
                        total = total - totalDoor;
                        ++i;
                    }
                    Console.WriteLine("The new total area of the wall is " + total + "ft^2");
                }

                //calculate the amount of paint needed in total
                double paintNeeded = Math.Round(total / 20);
                Console.WriteLine("You will need " + paintNeeded + " litres of paint");
                Console.ReadLine();
                //shows amount of paint needed accordingly
                Console.WriteLine("You will need " + paintNeeded + " of the small size or " + (paintNeeded / 5) + " of medium size or " + (paintNeeded / 10) + " of large size can");
                Console.WriteLine("The cost for a small size will range from £8-£20, medium will range from £10-25 and a large will cost £15-30.");
                Console.ReadLine();
                Console.WriteLine("What size paint would you like? small for 1 litre, medium for 5 litre or large for 10 litre");
                string size = Console.ReadLine();

                //if statement for calc of size and total costs
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
                //to have code repeat
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
