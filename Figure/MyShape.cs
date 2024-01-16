using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Figure
{
    
    public abstract class MyShape : Shape
    {
        protected string ?description;
        protected Shape figure;

        public MyShape(string decription,Shape figure)
        {
            this.description = decription;
            this.figure = figure;   
        }

        public string ?getDecription() => description; 

        public Shape getFigure() => figure;
    }

    public class MyElipse : MyShape
    {

        public MyElipse() : base ("Это круг", new Ellipse())
        {
            figure.Height = 30;
            figure.Width = 30;
            figure.StrokeThickness = 1;
            figure.Fill = Brushes.Red;
            figure.Stroke = Brushes.Green;
        }
 
        protected override Geometry DefiningGeometry => figure.RenderedGeometry;

    }

    public class MyRectangle : MyShape
    {
  
        public MyRectangle() : base ("Это квадрат", new Rectangle())
        {
            figure.Height = 30;
            figure.Width = 30;
            figure.StrokeThickness = 1;
            figure.Fill = Brushes.Red;
            figure.Stroke = Brushes.Green;
        }
        protected override Geometry DefiningGeometry => figure.RenderedGeometry;

    }

    public class MyTriangular : MyShape
    {
  
        public MyTriangular() : base ("Это треугольник", new Polygon())
        {
            Polygon polygon = new Polygon();
            polygon.StrokeThickness = 1;
            polygon.Fill = Brushes.Red;
            polygon.Stroke = Brushes.Green;

            var PointsSector = new PointCollection()
            {
                new Point(0,30),
                new Point(30,0),
                new Point(0,0),
            };
            polygon.Points = PointsSector;

            figure = polygon;
        }

        protected override Geometry DefiningGeometry => figure.RenderedGeometry;

    }

    public class MyOval : MyShape
    {

        public MyOval() : base ("Это овал", new Ellipse())
        {
            figure.Height = 30;
            figure.Width = 50;
            figure.StrokeThickness = 1;
            figure.Fill = Brushes.Red;
            figure.Stroke = Brushes.Green;
        }
        protected override Geometry DefiningGeometry => figure.RenderedGeometry;
    }

}
