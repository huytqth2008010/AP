using System;
using T2008M_AP.Lab.S1;

namespace T2008M_AP.Lab.s3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Product p1 = new Product();
            p1.id = 1;
            p1.name = "sp1";
            p1.price = 1000000;
            p1.qty = 1;
            p1.image = "Anhdep.ipg";
            p1.description = "ABC";
            Product p2 = new Product();
            p2.id = 2;
            p2.name = "sp2";
            p2.price = 2000000;
            p2.qty = 2;
            p2.image = "Anhdep.ipg";
            p2.description = "ABC";
            
            Cart sp1 = new Cart();
            sp1.id = 1;
            sp1.customer = "Nguyen Van A";
            sp1.city = "HN";
            sp1.country = "Viet Nam";
            sp1.AddProduct(p1);
            sp1.AddProduct(p2);
            sp1.RemoveProduct(p2);
            
            Console.WriteLine("Danh sach cac sp:");
            foreach (var VARIABLE in sp1.productList)
            {
                Console.WriteLine(VARIABLE);
            }
            Console.WriteLine("Tong tien:"+sp1.FinalGrandTotal());
           
        }
    }
}