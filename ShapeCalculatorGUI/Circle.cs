using System;
using System.Windows;

namespace ShapeCalculatorGUI
{
    // Circle class inheriting from Shape
    public class Circle : Shape
    {
        private double radius;
        private static double areaResult;

        public double getRadius()
        {
            return radius;
        }
        public void setRadius(double radius)
        {
            this.radius = radius;
        }

        public double getAreaResult()
        {
            return areaResult;
        }
        public void setAreaResult(double AreaResult)
        {
            areaResult = AreaResult;
        }

        public Circle()
        {
            radius = 0;            
        }

        // Parameterized constructor to set the radius of the Circle
        public Circle(double Radius)
        {
            this.radius = Radius;
        }

        // Overridden method to calculate the area of the circle
        public override double CalculateArea()
        {
            return Math.PI * radius * radius;
        }

        // Method to store the area of the circle and save the data to xml file
        public override void PrintShapeArea(double circleArea)
        {
            areaResult = Math.Round(circleArea,2);

            ShapeCalculatorData data = new ShapeCalculatorData
            {
                ShapeName = "Circle",
                Side1 = 0,
                Side2 = 0,
                Side3 = 0,
                Width = 0,
                Length = 0,
                Radius = this.radius,
                AreaResult = areaResult
            };

            ShapeCalculatorDataRepository.SaveShapeCalculatorData(data);
            
        }
    }
}