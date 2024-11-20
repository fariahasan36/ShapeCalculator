using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ShapeCalculatorGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /* Button to 
         calculate all the areas of Shape */
        private void BtnAppCalculate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double side1 = double.Parse(TxtTriangleSide1.Text);
                double side2 = double.Parse(TxtTriangleSide2.Text);
                double side3 = double.Parse(TxtTriangleSide3.Text);
                double length = double.Parse(TxtRectangleLength.Text);
                double width = double.Parse(TxtRectangleWidth.Text);
                double radius = double.Parse(TxtCircleRadius.Text);

                ShapeDatabase shapeDatabase = new ShapeDatabase();

                Triangle triangle = new Triangle(side1, side2, side3);
                shapeDatabase.AddShapeToDatabase(triangle);

                Rectangle rectangle = new Rectangle(length, width);
                shapeDatabase.AddShapeToDatabase(rectangle);

                Circle circle = new Circle(radius);
                shapeDatabase.AddShapeToDatabase(circle);

                shapeDatabase.PrintAllAreas();

                double triangleArea = triangle.getAreaResult();
                double rectangleArea = rectangle.getAreaResult();
                double circleArea = circle.getAreaResult();

                List<ShapeCalculatorData> shapes = ShapeCalculatorDataRepository.GetAllShapes();

                AreaResult areaResult = new AreaResult();
                areaResult.triangleArea = triangleArea;
                areaResult.rectangleArea = rectangleArea;
                areaResult.circleArea = circleArea;
                areaResult.shapes = shapes;
                areaResult.ShapeList.ItemsSource = shapes;
                areaResult.Show();
                this.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Please enter only numbers");
            }
        }
        
        private void BtnAppReset_Click(object sender, RoutedEventArgs e)
        {
            TxtTriangleSide1.Text = "Triangle Side 1";
            TxtTriangleSide2.Text = "Triangle Side 2";
            TxtTriangleSide3.Text = "Triangle Side 3";
            TxtRectangleLength.Text = "Rectangle Length";
            TxtRectangleWidth.Text = "Rectangle Width";
            TxtCircleRadius.Text = "Circle Radius";
        }

        private void BtnAppClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void TriSide1_Focus(object sender, RoutedEventArgs e)
        {
            if (TxtTriangleSide1.Text == "Triangle Side 1")
                TxtTriangleSide1.Text = "";
        }

        private void TriSide1_LostFocus(object sender, RoutedEventArgs e)
        {
            if (TxtTriangleSide1.Text == "")
                TxtTriangleSide1.Text = "Triangle Side 1";
        }

        private void RecLength_Focus(object sender, RoutedEventArgs e)
        {
            if (TxtRectangleLength.Text == "Rectangle Length")
                TxtRectangleLength.Text = "";

        }

        private void RecLength_LostFocus(object sender, RoutedEventArgs e)
        {
            if (TxtRectangleLength.Text == "")
                TxtRectangleLength.Text = "Rectangle Length";
        }

        private void TxtRectangleLength_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TriSide2_Focus(object sender, RoutedEventArgs e)
        {
            if (TxtTriangleSide2.Text == "Triangle Side 2")
                TxtTriangleSide2.Text = "";
        }

        private void TriSide2_LostFocus(object sender, RoutedEventArgs e)
        {
            if (TxtTriangleSide2.Text == "")
                TxtTriangleSide2.Text = "Triangle Side 2";
        }

        private void TriSide3_LostFocus(object sender, RoutedEventArgs e)
        {
            if (TxtTriangleSide3.Text == "")
                TxtTriangleSide3.Text = "Triangle Side 3";
        }

        private void TriSide3_Focus(object sender, RoutedEventArgs e)
        {
            if (TxtTriangleSide3.Text == "Triangle Side 3")
                TxtTriangleSide3.Text = "";
        }

        private void RecWidth_Focus(object sender, RoutedEventArgs e)
        {
            if (TxtRectangleWidth.Text == "Rectangle Width")
                TxtRectangleWidth.Text = "";
        }

        private void RecWidth_LostFocus(object sender, RoutedEventArgs e)
        {
            if (TxtRectangleWidth.Text == "")
                TxtRectangleWidth.Text = "Rectangle Width";
        }

        private void CirRadius_Focus(object sender, RoutedEventArgs e)
        {
            if (TxtCircleRadius.Text == "Circle Radius")
                TxtCircleRadius.Text = "";
        }

        private void CirRadius_LostFocus(object sender, RoutedEventArgs e)
        {
            if (TxtCircleRadius.Text == "")
                TxtCircleRadius.Text = "Circle Radius";
        }

        private void BtnViewRecords_Click(object sender, RoutedEventArgs e)
        {
            List<ShapeCalculatorData> shapes = ShapeCalculatorDataRepository.GetAllShapes();

            AreaResult areaResult = new AreaResult();
            areaResult.shapes = shapes;
            areaResult.ShapeList.ItemsSource = shapes;
            areaResult.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
