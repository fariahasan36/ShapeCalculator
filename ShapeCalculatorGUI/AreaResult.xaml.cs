using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ShapeCalculatorGUI
{
    /// <summary>
    /// Interaction logic for AreaResult.xaml
    /// </summary>
    public partial class AreaResult : Window
    {
        public double triangleArea { get; set; }
        public double rectangleArea { get; set; }
        public double circleArea { get; set; }
        public List<ShapeCalculatorData> shapes { get; set; }
        public List<string> ShapeTypes { get; set; }
    
        public AreaResult()
        {
            InitializeComponent();
            ShapeTypes = new List<string> { "Select", "Triangle", "Rectangle", "Circle"};
            DataContext = this;
            
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comboBox.SelectedItem != null)
            {
                string selectedItem = (string)comboBox.SelectedItem;
                this.shapes = ShapeCalculatorDataRepository.SearchShape(selectedItem);
                ShapeList.ItemsSource = shapes;
            }
        }

        private void BtnBackToMain_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.Show();

        }
    }
}
