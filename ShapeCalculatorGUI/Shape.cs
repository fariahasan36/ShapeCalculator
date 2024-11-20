using System;

namespace ShapeCalculatorGUI
{
    /* It implements the IShape interface, providing a blueprint for
    calculating the area of different shapes.*/
    public abstract class Shape : IShape
    {
        public abstract double CalculateArea();
        public abstract void PrintShapeArea(double area);
    }
}
