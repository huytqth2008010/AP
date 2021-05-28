
using System;
namespace GeometryExample
{
    public class Cylinder
    {
        public double Radius { get; set; }
        public double Height { get; set; }

        public double BaseArea { get; set; }
        public double LateralArea { get; set; }
        public double TotalArea { get; set; }
        public double Volume { get; set; }

        public Cylinder()
        {
        }

        public Cylinder(double radius, double height)
        {
            Radius = radius;
            Height = height;
        }

        public void Process()
        {
            BaseArea = Radius * Radius * Math.PI;
            LateralArea = 2 * Math.PI * Radius * Height;
            TotalArea = 2 * Math.PI * Radius * (Height + Radius);
            Volume = Math.PI * Radius * Radius * Height;
        }

        public string Result()
        {
            return "Radius: " + Radius + ", Height: " + Height + "\n" +
                   "Base: " + Math.Round(BaseArea,2) + " | Lateral: " +  Math.Round(LateralArea,2)  + " | Total: " + Math.Round(TotalArea,2) + " | Volume: " + Math.Round(Volume,2);
        }
    }
}