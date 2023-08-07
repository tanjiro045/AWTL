using System;
namespace P3Abstract
{
    public abstract class Shape
    {
        public double area;
        public abstract void Area();
        public void displayData()
        {
            Console.WriteLine("Area is: " + area);
        }
    }
    public class Rectangle : Shape
    {
        public double len, breadth;
        public void getData()
        {
            Console.WriteLine("Enter length of Rectangle");
            len = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter breadth of Rectangle");
            breadth = Double.Parse(Console.ReadLine());
        }
        public override void Area()
        {
            getData();
            area = len * breadth;
            displayData();
        }
    }
    public class Circle : Shape
    {
        public double r;
        public void getData()
        {
            Console.WriteLine("Enter radius of Circle");
            r = Double.Parse(Console.ReadLine());
        }
        public override void Area()
        {
            getData();
            area = 3.14 * r * r;
            displayData();
        }
    }
    public class Ellipse : Shape
    {
        public double a, b;
        public void getData()
        {
            Console.WriteLine("Enter a axis of Ellipse");
            a = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter b axis of Ellipse");
            b = Double.Parse(Console.ReadLine());
        }
        public override void Area()
        {
            getData();
            area = 3.14 * a * b;
            displayData();
        }
    }
    public class Square : Shape
    {
        public double s;
        public void getData()
        {
            Console.WriteLine("Enter side of Square");
            s = Double.Parse(Console.ReadLine());
        }
        public override void Area()
        {
            getData();
            area = s * s;
            displayData();
        }
    }
    public class Triangle : Shape
    {
        public double h, b;
        public void getData()
        {
            Console.WriteLine("Enter height of Triangle");
            h = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter base of Triangle");
            b = Double.Parse(Console.ReadLine());
        }
        public override void Area()
        {
            getData();
            area = 0.5 * h * b;
            displayData();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.Area();
            Circle c = new Circle();
            c.Area();
            Ellipse e = new Ellipse();
            e.Area();
            Square s = new Square();
            s.Area();
            Triangle t = new Triangle();
            t.Area();
            Console.ReadLine();
        }
    }
}