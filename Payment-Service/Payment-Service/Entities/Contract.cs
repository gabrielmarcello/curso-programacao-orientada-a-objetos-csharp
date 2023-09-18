namespace Payment_service.Entities
{
    internal class Contract
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }
        public List<Installment> Installments { get; set; }

        public Contract(int number, DateTime date, double value)
        {
            Number = number;
            Date = date;
            TotalValue = value;
            Installments = new List<Installment>();
        }

        public void AddInstallments(Installment installments)
        {
            Installments.Add(installments);
        }


    }
}
