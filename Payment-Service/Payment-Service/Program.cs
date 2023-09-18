using System.Globalization;
using Payment_service.Entities;
using Payment_service.Services;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter contract data");
        Console.Write("Number: ");
        int contractNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Date (dd/MM/yyyy): ");
        DateTime contractDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
        Console.WriteLine("Contract value: ");
        double contractValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine("Enter number of installments: ");
        int months = int.Parse(Console.ReadLine());

        Contract myContract = new Contract(contractNumber, contractDate, contractValue);

        ContractService contractService = new ContractService(new PaypalService());
        contractService.ProcessContract(myContract, months);

        Console.WriteLine("Installments");
        foreach (Installment installment in myContract.Installments)
        {
            Console.WriteLine(installment);
        }

    }
}