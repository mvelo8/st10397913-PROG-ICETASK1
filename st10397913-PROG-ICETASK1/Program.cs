namespace st10397913_PROG_ICETASK1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer("Mpimpi Hloni", "mpimpi12@gmail.com", "0589567894", 1000, new DateTime(2023, 6, 15));


            Console.WriteLine("Name: " + customer[0]);
            Console.WriteLine("Email: " + customer["Email"]);
            Console.WriteLine("Phone: " + customer[2]);
            Console.WriteLine("Balance: " + customer["Balance"]);
            Console.WriteLine("Last Purchase: " + customer["LastPurchase"]);


            customer[0] = "Zinhle Josh";
            customer["Email"] = "zinhlejosh@gmail.com";
            customer[2] = "0987654321";
            customer["Balance"] = 1500;
            customer["LastPurchase"] = new DateTime(2023, 8, 1);


            Console.WriteLine("\nUpdated Customer Information:");
            Console.WriteLine("Name: " + customer[0]);
            Console.WriteLine("Email: " + customer["Email"]);
            Console.WriteLine("Phone: " + customer[2]);
            Console.WriteLine("Balance: " + customer["Balance"]);
            Console.WriteLine("Last Purchase: " + customer["LastPurchase"]);
        }
    }
}
