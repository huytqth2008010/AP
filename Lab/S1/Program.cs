using System;

namespace T2008M_AP.Lab.S1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Product product = new Product();
            Console.WriteLine("Hien thi ra toan bo thong tin cua Product :");
            product.id = 1;
            product.name = "sp1";
            product.price = 123.23;
            product.qty = 2;
            product.image = "Anhdep.ipg";
            product.description = "ABC";
            product.gallery.Add("Anh1.jpg");
            product.gallery.Add("Anh2.jpg");
            product.gallery.Add("Anh3.jpg");
            product.gallery.Add("Anh4.jpg");
            product.GetInfo();
            Console.WriteLine((product.CheckQty(product.qty))?"con hang":"het hang");
            Console.WriteLine("Them anh:");
            var a=Console.ReadLine();
            product.AddImage(a);
        }
    }
}