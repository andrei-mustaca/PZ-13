using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Cuper
    {
        private string name;
        public string Name
        {
            set { name = value; }
            get { return (name=="") ?"Нет такой валюты":name; }
        }
        private int nom;
        public int Nom
        {
            set { nom = (value<1||value>500) ?0:value; }
            get { return nom; }
        }
        private int kvo;
        public int Kvo
        {
            set { kvo = (value<10||value>1000) ?0:value; }
            get { return kvo; }
        }
        public Cuper() { }
        public Cuper(string name,int nom,int kvo)
        {
            Name = name;
            Nom = nom;
            Kvo = kvo;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"name={Name}\tnominal={Nom}\tkvo={Kvo}");
        }
        public int Izmen(int a)
        {
            return (a < 0) ?Kvo-a:Kvo-a;
        }
        public string Prod(int b)
        {
            string c = (b > Kvo * Nom) ? "Недостаточно" : "Достаточно";
            return c;
        }
    }
}
