using System;

namespace T2008M_AP.Session.s4
{
    public class Program
    {
        public static void Main(string[] args)
        {

            try
            {
                int x = 10;
                int y = 10;
                x++;
                int z = x / y;
                Console.WriteLine("z =" + z);
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine("loi toan hoc");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Finally..");
            }
            // khi can lam viec voi I O (nhap -xuat)
            // khi lam viec voi api (hoac connect ben ngoai qua internet)
            // khi lam viec voi DB
            // du doan se loi
        }
    }
}