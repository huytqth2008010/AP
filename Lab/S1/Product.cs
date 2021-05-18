using System;
using System.Collections;
using System.Collections.Generic;

namespace T2008M_AP.Lab.S1
{
    
    public class Product
    {
    //các thuộc tính
        public int id,qty;
        public string name,image,desc;
        public double price;
        public List<string> gallery = new List<string>();
    //constructors không có tham số 
        public Product()
        {
        }
    //constructors có tham số 
        public Product(int id, int qty, string name, string image, string desc, double price)
        {
            this.id = id;
            this.qty = qty;
            this.name = name;
            this.image = image;
            this.desc = desc;
            this.price = price;
        }
    // Hiển thị ra toàn bộ thông tin của product
    
        public void GetInfo()
        {
            Console.WriteLine("Id : " + id );
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Price : " + price);
            Console.WriteLine("Qty : " + qty);
            Console.WriteLine("Image : " + image);
            Console.WriteLine("Desc : " + desc);
        }
    //Phương thức thông báo còn hàng hay hết hàng
        public bool CheckQty(int qty)
        {
            return (qty>0)?true:false;
        }
    //Phương thức thêm ảnh vào gallery
        public void AddImage(string img)
        {
            if (gallery.Count > 10)
            {
                Console.WriteLine("Ban phai xoa bot anh.");
                DeleteImage();
                HienThi();
            }
            else
            {
                gallery.Add(img);
                Console.WriteLine("Them thanh cong");
                HienThi();
            }
        }

        public void DeleteImage()
        {
            Console.Write("Ban muon xoa anh:");
            var del = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(gallery[del]);
            gallery.RemoveAt(del);
        }

        public void HienThi()
        {
            Console.WriteLine("Danh sach cac anh:");
            foreach (var VARIABLE in gallery)
            {
                Console.WriteLine(VARIABLE);
            }
        }
    }
}