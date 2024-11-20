using System;
using System.Windows;

namespace ShapeCalculatorGUI
{
    // Rectangle class inheriting from Shape
    public class Rectangle : Shape
    {
        private double length;
        private double width;
        private static double areaResult;

        public double getLength()
        {
            return length;
        }
        public void setLength(double Length)
        {
            this.length = Length;
        }

        public double getWidth()
        {
            return width;
        }
        public void setWidth(double Width)
        {
            this.width = Width;
        }

        public double getAreaResult()
        {
            return areaResult;
        }
        public void setAreaResult(double AreaResult)
        {
            areaResult = AreaResult;
        }

        public Rectangle()
        {
            length = 0;
            width = 0;
        }

        // Parameterized constructor to set the lengths and width of rectangle
        public Rectangle(double Length, double Width)
        {
            this.length = Length;
            this.width = Width;
        }

        // Overridden method to calculate the area of the rectangle
        public override double CalculateArea()
        {
            return length * width;
        }

        // Method to store the area of the rectangle and save the data to xml file
        public override void PrintShapeArea(double rectangleArea)
        {
            areaResult = Math.Round(rectangleArea);

            ShapeCalculatorData data = new ShapeCalculatorData
            {
                ShapeName = "Rectangle",
                Side1 = 0,
                Side2 = 0,
                Side3 = 0,
                Width = this.length,
                Length = this.width,
                Radius = 0,
                AreaResult = areaResult
            };
            ShapeCalculatorDataRepository.SaveShapeCalculatorData(data);         
        }
    }
}