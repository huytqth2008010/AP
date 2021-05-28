using System;
namespace GeometryExample
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var cylinder = new Cylinder();
            while (true)
            {
                try
                {
                    Console.WriteLine("\n"+"Enter the dimensions of the cylinder");
                    Console.Write("Radius: ");
                    cylinder.Radius = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Height: ");
                    cylinder.Height = Convert.ToDouble(Console.ReadLine());
                    cylinder.Process();
                    Console.WriteLine("\n"+"Cylinder Characteristics");
                    Console.WriteLine(cylinder.Result());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}