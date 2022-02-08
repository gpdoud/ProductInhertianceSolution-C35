using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductInhertianceProject {
    
    public class Widget : Product {

        public string Size { get; set; } = "Medium";
        public string Color { get; set; } = "Black";

        public override string ToPrint() {
            return $"{base.ToPrint()} | {Size} | {Color}";
        }

        public Widget(string code, decimal price, string size, string color)
            : base(code, price) {

            Size = size;
            Color = color;
        }
        public Widget() : base() {

        }
    }
}
