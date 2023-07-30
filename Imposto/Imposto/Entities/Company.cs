using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imposto.Entities
{
    internal class Company : TaxPayer
    {
        public int NumberOfEmployees { get; set; }
        
        public Company()
        {
        }

        public Company(string name, double anualIncome, int numberOfEmployees) : base(name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            if(NumberOfEmployees > 10)
            {
                return AnualIncome * 14 / 100;
            }
            else
            {
                return AnualIncome * 16 / 100;
            }
        }
    }
}
