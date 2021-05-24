using System;

namespace T2008M_AP.Session.s3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Product p = new Product();
            p.ProductName = "Túi xách Gucci";
            p.Price = 1000; // nhìn thì tưởng attribute nhưng thực ra là Property
            p[0] = "image1.png"; // dang su dung indexers
            p[1] = "image2.png";// set
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(p[i]); //get
            }
        }
    }
    namespace T2008M.session3
    {
        public class Cart
        {
        
        }
    }
}