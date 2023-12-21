using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Edition
    {
        private string name;
        public string Name
        {
            set { name = value; }
            get { return (name=="")?"Ошибка":name; }
        }
        private string surname;
        public string Surname
        {
            set { surname = value; }
            get { return (surname == "") ?"Ошибка":surname; }
        }
        private int year;
        public int Year
        {
            set{ year = (value < 2000 || value > 2023) ?0:value; }
            get { return year; }
        }
        public Edition() { }
        public Edition(string name,string surname,int year)
        {
            Name = name;
            Surname = surname;
            Year = year;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"name={Name}\tsurname={Surname}\tyear={Year}");
        }
        public int Izmen(int n)
        {
            if(n<0)
            {
                return Year + n;
            }
            else
            {
                return Year + n;
            }
        }
    }
}
