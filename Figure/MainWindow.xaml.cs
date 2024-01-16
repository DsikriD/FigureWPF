using System;
using System.Collections.Generic;
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

namespace Figure
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            cmbSetValue();
        }

       private Dictionary<string, MyShape> TypesFigure = new Dictionary<string, MyShape>
       {
            { "Квадрат", new MyRectangle()},
            { "Круг", new MyElipse()},
            { "Треугольник", new MyTriangular()},
            { "Овал",new MyOval()}
       };

        private MyShape shape = new MyRectangle();

        private void Draw()
        {
            Clear_Canvas();
            cnv.Children.Add(shape.getFigure());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Draw();
        }
        
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           Clear_Canvas();
        }

        public void Clear_Canvas() => cnv.Children.Clear();

        public void cmbSetValue()
        {
            foreach (var type in TypesFigure)
                cmb.Items.Add(type.Key);

            cmb.SelectedIndex = 0;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            shape = (TypesFigure.Single(x=> x.Key == cmb.SelectedValue.ToString())).Value;
        }
    }
}
