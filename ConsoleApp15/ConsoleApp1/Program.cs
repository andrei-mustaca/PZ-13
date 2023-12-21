using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Edition ed1 = new Edition();
            //ed1.Name = "";
            //ed1.Surname = "";
            //ed1.Year = 1999;
            //ed1.ShowInfo();

            //Edition ed2 = new Edition("Евгений Онегин","Пушкин",2006);
            //ed2.ShowInfo();
            //Console.WriteLine("n=");
            //int n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"{ed2.Izmen(n)}");

            //Console.WriteLine("name=");
            //string name = Console.ReadLine();
            //Console.WriteLine("surname=");
            //string surname = Console.ReadLine();
            //Console.WriteLine("year=");
            //int year = Convert.ToInt32(Console.ReadLine());
            //Edition ed3 = new Edition(name, surname, year);
            //ed3.ShowInfo();

            //PO po1 = new PO();
            //po1.Name = "";
            //po1.Proizvod = "";
            //po1.Price = true;
            //po1.ShowInfo();

            //PO po2 = new PO("Виктория","Беллорусь",false);
            //po2.ShowInfo();

            //Cuper cup1 = new Cuper("",-1,1);
            //cup1.ShowInfo();

            Cuper cup2 = new Cuper("Русские",100,100);
            cup2.ShowInfo();
            Console.WriteLine("a=");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"izmen={cup2.Izmen(a)}");
            Console.WriteLine("y=");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"prod={cup2.Prod(y)}");
            Console.ReadKey();
        }
    }
}
