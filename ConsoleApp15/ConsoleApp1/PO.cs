using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class PO
    {
        private string name;
        public string Name
        {
            set { name = value; }
            get { return (name == "") ?"Ошибка":name; }
        }
        public string proizvod;
        public string Proizvod
        {
            set { name = value; }
            get { return (proizvod=="") ?"ошибка":name; }
        }
        private bool price;
        public bool Price
        {
            set { price = value; }
            get { return (price == false) ?false:true; }
        }
        public PO() { }
        public PO(string name,string proizvod,bool price)
        {
            Name = name;
            Proizvod = proizvod;
            Price = price;
        }
        public void ShowInfo()
        {
            string z = (Price == true) ? "ПО бесплатное" : "ПО платное";
            Console.WriteLine($"name={Name}\tproizvod={Proizvod}\t price={z} ");
        }
    }
}
