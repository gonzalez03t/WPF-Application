using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Windows.Shapes;
using System.Windows.Media;
using System.Windows;


namespace WpfApp_Classes_Objects
{
    class Shape
    {
        public Shape(Canvas canvas) //Constructor
        {
            _canvas = canvas;
        }

        public void Draw()
        {
            //NextDouble function returns a number between 0 and 1. 
            double left = 727 * _rand.NextDouble(); //Use rand num as percentage to determine rand position for left
            double top = 347 * _rand.NextDouble(); //Use rand num as percentage to determine rand position for top
            _element.SetValue(Canvas.LeftProperty, left);
            _element.SetValue(Canvas.TopProperty, top);
            _canvas.Children.Add(_element);
        }

        Canvas _canvas;
        protected UIElement _element;
        static Random _rand = new Random();
    }

    class Circle : Shape
    {
        public Circle(Canvas canvas) //Constructor
            : base(canvas)
        {
            Ellipse ellipse = new Ellipse();
            ellipse.Width = 20;
            ellipse.Height = 20;
            ellipse.Fill = new SolidColorBrush(Colors.Orange);
            ellipse.Stroke = new SolidColorBrush(Colors.Black);
            _element = ellipse;
        }
    }

    class Squares : Shape
    {
        public Squares(Canvas canvas) //Constructor
            :base(canvas)
        {
            Rectangle rect = new Rectangle();
            rect.Width = 20;
            rect.Height = 20;
            rect.Fill = new SolidColorBrush(Colors.Blue);
            rect.Stroke = new SolidColorBrush(Colors.Black);
            _element = rect;
        }
    }
}
