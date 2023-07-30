using Exeptions.Entities;
using Exeptions.Entities.Exeptions;
using System.Globalization;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter account data");
        Console.Write("Number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Holder: ");
        string holder = Console.ReadLine();
        Console.Write("Initial balance: ");
        double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Withdraw limit: ");
        double withDrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Account acc = new Account(number, holder, balance, withDrawLimit);
        
        Console.WriteLine();
        Console.Write("Enter amount for withdraw: ");
        double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        try
        {
            acc.WithDraw(amount);
            Console.WriteLine("New balance: " + acc.Balance.ToString("F2", CultureInfo.InvariantCulture));
        }
        catch (DomainExceptions e)
        {
            Console.WriteLine("Withdraw error: " + e.Message);
        }
    }
}