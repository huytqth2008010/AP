using System.Collections.Generic;
using T2008M_AP.Lab.S1;

namespace T2008M_AP.Lab.s3
{
    public class Cart:Product
    {
        public int id;
        public string customer,city,country;
        public double grandTotal;
        public List<string> productList;
        public Cart()
        {
            productList = new List<string>();
        }

        public Cart(int id, string customer, string city, string country, double grandTotal, List<string> productList)
        {
            this.id = id;
            this.customer = customer;
            this.city = city;
            this.country = country;
            this.grandTotal = grandTotal;
            this.productList = productList;
            productList = new List<string>();
        }
    //Phương thức thêm sản phẩm vào giỏ hàng
    public bool AddProduct(Product ap){
        productList.Add(ap.ToString());
        return true;
    }
    //Phương thức xoá 1 sản phẩm khỏi giỏ hàng
    public bool RemoveProduct(Product rp)
    {
        productList.Remove(rp.ToString());
        return true;
    }
    //Phương tính tinh tổng tiền
    public bool CheckCity(){
        return city == "HN" || city == "HCM";
    }
    public bool CheckNation()
    {
        return country == "Viet Nam";
    }
    
    public double FinalGrandTotal(){
        if (CheckNation())
        {
             if(CheckCity()){
                            return  grandTotal+ grandTotal*1/100;
                        } 
                        return  grandTotal +  grandTotal * 2/100;
                 }
         return  grandTotal +  grandTotal * 5/100;
        }
    }
}