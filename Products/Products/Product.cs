using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Products {
    class Product {
        public string Name;
        public double Value;
        public int Amount;

        public double TotalValueInStock() {
            return Value * Amount;
        }

        public void AddProducts(int amount) {
            Amount += amount;
        }

        public void RemoveProducts(int amount) {
            Amount -= amount;
        }

        public override string ToString() {
            return Name
                + ", R$ "
                + Value.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Amount
                + " unidades, Total: R$ "
                + TotalValueInStock().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
