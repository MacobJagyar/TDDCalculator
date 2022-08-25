using System;
namespace TDDCalculator
{
    public static class Rectangle
    {
        public static decimal Length { get; set; }
        public static decimal Width { get; set; }



        public static decimal CalculateRectangleArea(decimal length,decimal width)
        {

            return length * width;
        }

        public static decimal CalculateRectanglePerimeter(decimal length, decimal width)
        {

            return 2*(length + width);
        }

    }
}

