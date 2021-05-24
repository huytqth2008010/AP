using System;
using System.Collections;
using System.Collections.Generic;

namespace T2008M_AP.Lab.S1
{
    
    public class Product
    {
        public int id;
        public string name;
        public decimal price;
        public int qty;
        public string image;
        public string description;
        public List<string> gallery ;

        public Product()
        {
            gallery = new List<string>();
        }

        public Product(int id, string name, decimal price, int qty, string image, string description)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.qty = qty;
            this.image = image;
            this.description = description;
            gallery = new List<string>();
        }

        public void GetInfo()
        {
            Console.WriteLine("Ten sp: "+name);
            Console.WriteLine("Gia: "+price);
            Console.WriteLine("SL: "+qty);
        }

        public void CheckQty()
        {
            if (qty > 0)
            {
                Console.WriteLine("In stock");
                return;
            }
            Console.WriteLine("Out of stock");
        }

        public bool AddImage(string image)
        {
            if (gallery.Count >= 10)
                return false;
            gallery.Add(image);
            return true;
        }

        public bool RemoveImage(string image)
        {
            gallery.Remove(image);
            return true;
        }
    }
}