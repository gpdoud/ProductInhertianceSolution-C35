using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductInhertianceProject {
    
    public class Product {

        private bool Flag { get; set; }
        public string Code { get; set; }
        public decimal Price { get; set; }

        public virtual string ToPrint() {
            return $"{GetType().ToString()} | {Code} | {Price:c}";
        }
        public Product(string Code, decimal price) {
            Flag = true;
            this.Code = Code;
            Price = price;
        }
        public Product() {

        }
    }
}
