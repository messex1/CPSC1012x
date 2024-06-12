namespace Assignment02_MichaelEssex
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Stoney Gravel Pit!");
            Console.WriteLine();
            bool continuePurchase = true;

            while (continuePurchase)
            {
                Console.Write("Please enter the weight of gravel required: ");
                if (!int.TryParse(Console.ReadLine(), out int weight))
                {
                    Console.WriteLine("Invalid input. Please enter a valid weight.");
                    continue;
                }

                Console.Write("Do you require delivery (Y/N)? ");
                string deliveryInput = Console.ReadLine();
                Console.WriteLine();

                bool requiresDelivery = deliveryInput.ToLower() == "y";

                double pricePerPound;

                if (weight < 1000)
                {
                    pricePerPound = 0.55;
                }
                else if (weight is >= 1000 and <= 2000)
                {
                    pricePerPound = 0.45;
                }
                else if (weight is >= 2001 and <= 3000)
                {
                    pricePerPound = 0.35;
                }
                else
                {
                    pricePerPound = weight is >= 3001 and <= 4000 ? 0.25 : weight is >= 4001 and <= 5000 ? 0.15 : 0.10;
                }

                double subtotal = weight * pricePerPound;
                double deliveryCharge = requiresDelivery && weight <= 4800 ? subtotal * 0.03 : 0;
                double gst = (subtotal + deliveryCharge) * 0.05;
                double total = subtotal + deliveryCharge + gst;

                Console.WriteLine($"The charge for {weight} lb of gravel is {pricePerPound:c} per lb.");
                Console.WriteLine();
                Console.WriteLine($"Subtotal: {subtotal:c}");
                Console.WriteLine($"Delivery: {deliveryCharge:c}" + (requiresDelivery && weight > 4800 ? " (free delivery)" : ""));
                Console.WriteLine($"GST: {gst:c}");
                Console.WriteLine("-----------------------");
                Console.WriteLine($"Total: {total:c}");
                Console.WriteLine();
                Console.WriteLine("Thank you for your purchase! We hope your day rocks.");

                Console.Write("Do you want to make another purchase? (Y/N): ");
                string continueInput = Console.ReadLine();

                continuePurchase = continueInput.ToLower() == "y";
                Console.WriteLine();
            }
        }
    }
}
