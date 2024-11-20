using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Windows.Shapes;

namespace ShapeCalculatorGUI
{
    public static class ShapeCalculatorDataRepository
    {
        private const string filePath = "C:\\Users\\faria\\Desktop\\Storage\\UClan Study\\VisualStudio\\ShapeCalculatorGUI\\ShapeCalculatorGUI\\ShapeCalculator.xml";

        public static void SaveShapeCalculatorData(ShapeCalculatorData data)
        {
            XDocument doc;
            if (File.Exists(filePath))
            {
                doc = XDocument.Load(filePath);
            }else{
                doc = new XDocument(new XElement("ShapeCalculator"));
            }

            doc.Root.Add(new XElement("Shape",
                            new XElement("ShapeName", data.ShapeName),
                            new XElement("Side1", data.Side1),
                            new XElement("Side2", data.Side2),
                            new XElement("Side3", data.Side3),
                            new XElement("Length", data.Length),
                            new XElement("Width", data.Width),
                            new XElement("Radius", data.Radius),
                            new XElement("AreaResult", data.AreaResult)));

            doc.Save(filePath);
        }

        public static List<ShapeCalculatorData> GetAllShapes()
        {
            List<ShapeCalculatorData> shapes = new List<ShapeCalculatorData>();

            if (File.Exists(filePath))
            {
                XDocument doc = XDocument.Load(filePath);
                shapes = doc.Root.Elements("Shape")
                            .Select(x => new ShapeCalculatorData
                            {
                                ShapeName = x.Element("ShapeName").Value,
                                Side1 = Convert.ToDouble(x.Element("Side1").Value),
                                Side2 = Convert.ToDouble(x.Element("Side2").Value),
                                Side3 = Convert.ToDouble(x.Element("Side3").Value),
                                Length = Convert.ToDouble(x.Element("Length").Value),
                                Width = Convert.ToDouble(x.Element("Width").Value),
                                Radius = Convert.ToDouble(x.Element("Radius").Value),
                                AreaResult = Convert.ToDouble(x.Element("AreaResult").Value)
                            }).ToList();
            }

            return shapes;
        }

        // Searches for ShapeCalculatorData objects with a specific shape name
        public static List<ShapeCalculatorData> SearchShape(string ShapeName)
        {
            List<ShapeCalculatorData> matchingShapes = new List<ShapeCalculatorData>();

            if (File.Exists(filePath))
            {
                XDocument doc = XDocument.Load(filePath);

                // If a specific shape name is provided, search for shapes with that name
                if (ShapeName != "Select")
                {
                    foreach (XElement shape in doc.Root.Elements("Shape"))
                    {
                        if (shape.Element("ShapeName").Value == ShapeName)
                        {
                            ShapeCalculatorData shapeData = new ShapeCalculatorData
                            {
                                ShapeName = shape.Element("ShapeName").Value,
                                Side1 = Convert.ToDouble(shape.Element("Side1").Value),
                                Side2 = Convert.ToDouble(shape.Element("Side2").Value),
                                Side3 = Convert.ToDouble(shape.Element("Side3").Value),
                                Length = Convert.ToDouble(shape.Element("Length").Value),
                                Width = Convert.ToDouble(shape.Element("Width").Value),
                                Radius = Convert.ToDouble(shape.Element("Radius").Value),
                                AreaResult = Convert.ToDouble(shape.Element("AreaResult").Value)
                            };
                            matchingShapes.Add(shapeData);
                        }
                    }
                } else
                {
                    // If "Select" is chosen, return all shapes
                    matchingShapes = GetAllShapes();
                }
            }
            return matchingShapes;
        }
    }
}
