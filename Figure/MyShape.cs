using System;
using System.Collections.Generic;
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
        public abstract Shape getFigure();

    }

    public class MyElipse : MyShape
    {
        Ellipse elipse = new Ellipse();

        protected override Geometry DefiningGeometry => elipse.RenderedGeometry;

        public override Shape getFigure()
        {
            elipse.Height = 30;
            elipse.Width = 30;
            elipse.StrokeThickness = 1;
            elipse.Fill = Brushes.Red;
            elipse.Stroke = Brushes.Green;
            return elipse;
        }
    }

    public class MyRectangle : MyShape
    {
        Rectangle rect = new Rectangle();

        protected override Geometry DefiningGeometry => rect.RenderedGeometry;

        public override Shape getFigure()
        {
            rect.Height = 30;
            rect.Width = 30;
            rect.StrokeThickness = 1;
            rect.Fill = Brushes.Red;
            rect.Stroke = Brushes.Green;
            return  rect;
        }
    }

    public class MyTriangular : MyShape
    {
        Polygon trin = new Polygon();

        protected override Geometry DefiningGeometry => trin.RenderedGeometry;

        public override Shape getFigure()
        {

            trin.StrokeThickness = 1;
            trin.Fill = Brushes.Red;
            trin.Stroke = Brushes.Green;

            var PointsSector = new PointCollection()
            {
                new Point(0,30),
                new Point(30,0),
                new Point(0,0),
            };

            trin.Points = PointsSector;
            return trin;
        }
    }

    public class MyOval : MyShape
    {
        Ellipse elipse = new Ellipse();

        protected override Geometry DefiningGeometry => elipse.RenderedGeometry;

        public override Shape getFigure()
        {
            elipse.Height = 30;
            elipse.Width = 50;
            elipse.StrokeThickness = 1;
            elipse.Fill = Brushes.Red;
            elipse.Stroke = Brushes.Green;
            return elipse;
        }

    }



}
