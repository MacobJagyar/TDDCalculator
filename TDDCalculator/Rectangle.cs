using System;
namespace TDDCalculator
{
    public class Rectangle
    {
        public decimal Length { get; set; }
        public decimal Width { get; set; }



        public decimal CalculateRectangleArea(Rectangle a)
        {

            return a.Length * a.Width;
        }

        public decimal CalculateRectanglePerimeter(Rectangle a)
        {

            return 2*(a.Length + a.Width);
        }

    }
}

