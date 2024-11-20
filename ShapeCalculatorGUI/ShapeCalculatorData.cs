using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalculatorGUI
{
    // This class represents the data used to store information about shapes and their calculations.
    public class ShapeCalculatorData
    {
        public string ShapeName { get; set; }

        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public double Side3 { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public double Radius { get; set; }
        public double AreaResult { get; set; }
    }
}
