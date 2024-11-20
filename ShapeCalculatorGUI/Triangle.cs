using System;
using System.Windows.Shapes;
using System.Windows;

namespace ShapeCalculatorGUI
{
    // Triangle class inheriting from Shape
    public class Triangle : Shape
    {
        private double[] side = new double[3];
        private static double areaResult;

        public double getAreaResult() { 
            return areaResult;
        }
        public void setAreaResult(double AreaResult) { 
            areaResult = AreaResult;
        }

        public Triangle() {
            side[0] = 0;
            side[1] = 0;
            side[2] = 0;
        }

        // Parameterized constructor to set the lengths of the sides
        public Triangle(double side1, double side2, double side3)
        {
            this.side[0] = side1;
            this.side[1] = side2;
            this.side[2] = side3;
        }

        // Overridden method to calculate the area of the triangle
        public override double CalculateArea()
        {
            double s = (side[0] + side[1] + side[2]) / 2;
            return Math.Sqrt(s * (s - side[0]) * (s - side[1]) * (s - side[2]));
        }

        // Method to store the area of the triangle and save the data to xml file
        public override void PrintShapeArea(double triangleArea)
        {
            areaResult = Math.Round(triangleArea,2);

            ShapeCalculatorData data = new ShapeCalculatorData
            {
                ShapeName = "Triangle",
                Side1 = this.side[0],
                Side2 = this.side[1],
                Side3 = this.side[2],
                Width = 0,
                Length = 0,
                Radius = 0,
                AreaResult = areaResult
            };

            ShapeCalculatorDataRepository.SaveShapeCalculatorData(data);
            
        }
    }
}