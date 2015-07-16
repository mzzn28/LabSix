using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSix
{
    class Product
    {
        string description;
        decimal cost;
        string manufacturer;
        public Product(string desc,decimal _cost,string manf)
        {
            description = desc;
            cost = _cost;
            manufacturer = manf;
        }
        public void printproduct()
        {
            Console.WriteLine("Desc: "+this.description+" Manufacturer: "+ this.manufacturer+" Cost: {c}"+this.cost);
        }


    }
}
