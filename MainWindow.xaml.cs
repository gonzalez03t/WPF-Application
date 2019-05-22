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
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp_Classes_Objects
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Title = "Demo App";

            for (int i = 0; i < 200; i++)
            {
                DrawShape(new Squares(DrawingCanvas));
                DrawShape(new Circle(DrawingCanvas));
            }
        }

        private void DrawShape(Shape shape)
        {
            shape.Draw();
        }
    }
}
