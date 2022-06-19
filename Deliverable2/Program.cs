using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Welcome to TKO, your $9.99 all you can eat buffet! You only pay for drinks; coffee is $3 and soda is $2. We can seat groups of 6 or less. How many people are in your group?: ");
        int numofgroup = int.Parse(Console.ReadLine());
        int numofCoffeeOrders = 0;
        int numofSodaOrders = 0;
        if (numofgroup <= 6)
        {
            Console.WriteLine("\n" + "Alright! We have table for " + numofgroup + ". Please come with me, let's get you seated.");
            for (int i = 1; i <= numofgroup; i++)
            {
                Console.Write("\n" + "Guest " + i + ", what drink can I get you started with, coffee or soda? ");
                string drink = Console.ReadLine();
                if (drink == "coffee" || drink == "Coffee") { Console.WriteLine("Coffee for Guest " + i + ", Got it!"); numofCoffeeOrders++; }
                else if (drink == "soda" || drink == "Soda") { Console.WriteLine("Soda for Guest " + i + ", Ok!"); numofSodaOrders++; }
                else { Console.Write("\n" + "Sorry, Guest " + i + ", we don't have that." + "\n"); }
            }
            decimal buffetprice = 9.99m;
            decimal buffetbill = numofgroup * buffetprice;
            String buffetString = buffetbill.ToString("C");
            decimal coffeeprice = 3.00m;
            decimal coffeebill = coffeeprice * numofCoffeeOrders;
            String coffeebillString = coffeebill.ToString("C");
            decimal sodaprice = 2.00m;
            decimal sodabill = sodaprice * numofSodaOrders;
            String sodabillString = sodabill.ToString("C");
            decimal total = buffetbill + coffeebill + sodabill;
            String totalString = total.ToString("C");
            Console.WriteLine("\n" + "Here is your bill:" + "\n" + "\n" + numofgroup + " ($9.99 each) Buffet ticket(s): " + buffetString + "\n" + numofCoffeeOrders + " ($3.00 each) Cup(s) of coffee: " + coffeebillString + "\n" + numofSodaOrders + " ($2.00 each) soda(s): " + sodabillString + "\n" + "\n" + "Total: " + totalString + "\n" + "\n" + "Thank you and have a good day!");
        }
        else { Console.WriteLine("\n" + "Sorry, we can't seat more than 6 people at this time. Please come back when you have a group of 6 or less." + "\n"); }
    }
}

