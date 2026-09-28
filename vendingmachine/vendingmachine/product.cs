using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vendingmachine
{
    public class product
    {
        private string _code { get; set; }
        private string _name { get; set; }
        private int _price { get; set; }
        private int _stock { get; set; }
        private emu _cathegory { get; set; }
        public string Code { get; }
        public string Name { get; }
        public int Price { get; }
        public int Stock { get; }
        public emu Cathegory { get; }
        public bool isAvailabel { get { if (_stock >= 1) { return true; } else { return false;} }}
        public product(string Code, string Name, int Price, int Stock, emu Cathegory, string code, string name, int price, int stock, emu cathegory)
        {
            Code = _code;
            Name = _name;
            Price = _price;
            Stock = _stock;
            Cathegory = _cathegory;
            Code = _code;
            Name = _name;
            Price = _price;
            Stock = _stock;
            Cathegory = _cathegory;
        }
        public void Sell()
        {
            _stock -= 1;
        }
        
    }
}
