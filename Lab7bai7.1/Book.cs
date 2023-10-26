using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7bai7._1
{
    internal class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Pulisher { get; set; }
        public int Year { get; set; }
        public int Price { get; set; }
        public void Add()
        {
            Console.WriteLine("Nhap thong tin cho sach: ");
            Console.Write("Id: "); Id = int.Parse(Console.ReadLine());
            Console.Write("Title: ");Title = Console.ReadLine();
            Console.Write("Author: ");Author = Console.ReadLine();
            Console.Write("Pulisher: "); Pulisher = Console.ReadLine();
            Console.Write("Year: "); Year = int.Parse(Console.ReadLine());
            Console.Write("Price: "); Price = int.Parse(Console.ReadLine());
        }
        public override string ToString()
        {
            return "Thong tin sach: " +
                "\nId: " + Id +
                "\nTitle: " + Title +
                "\nAuthor: " + Author +
                "\nPulisher: " + Pulisher +
                "\nYear: " + Year +
                "\nPrice: " + Price;
        }
    }
}
