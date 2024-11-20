using System;
using System.Collections.Generic;
using System.Windows;

namespace ShapeCalculatorGUI
{
    /// <summary>
    /// Class to manage a database of shapes
    /// </summary>
    public class ShapeDatabase
    {
        
        /// List to hold all shapes in the database       
        public List<Shape> allShapes = new List<Shape>();

        // Method to add a shapes 
        public void AddShapeToDatabase(Shape shape)
        {
            allShapes.Add(shape);
        }

        /// <summary>
        /// Method to store and print the areas of all shapes. 
        /// </summary>
        /// <param name="area">calculate the area of shapes.</param>
        public void PrintAllAreas()
        {
            foreach (Shape shape in allShapes)
            {
                double area = shape.CalculateArea();
                shape.PrintShapeArea(area);
            }
            MessageBox.Show("Shape data saved successfully.");
        }
    }
}