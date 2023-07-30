using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Produtos.Entities
{
    internal class ImportedProduct : Product
    {
        public double CustomsFree { get; set; }

        public ImportedProduct() 
        {
        }

        public ImportedProduct(string name, double price, double customsFree) : base(name, price)
        {
            CustomsFree = customsFree;
        }

        public double TotalPrice()
        {
            return Price + CustomsFree;
        }

        public override string PriceTag()
        {
            return Name + " $ " + TotalPrice().ToString("F2", CultureInfo.InvariantCulture) + "(Customs fee: $ " + CustomsFree.ToString("F2", CultureInfo.InvariantCulture) + ")";
        }
    }
}
