

class Program
{
    public static void Main(string[] args)
    {

        List<Shape> shapes = new List<Shape>();

        shapes.Add(new Square("s1", 2));
        shapes.Add(new Rectangle("r1", 2, 3));
        shapes.Add(new Circle("c1", 2));
        shapes.Add(new Triangle("t1", 4, 6));
        shapes.Add(new Ellipse("e1", 2, 3));
        shapes.Add(new Diamond("d1", 2, 3));
        shapes.Add(new Square("s2", 5));
        shapes.Add(new Rectangle("r2", 5, 4));
        shapes.Add(new Circle("c2", 1));
        shapes.Add(new Triangle("t2", 7, 8));
        foreach (var s in shapes)
        {
            Console.WriteLine(s);
        }



    }

    public abstract class Shape
    {
        public string Name { get; private set; }//how to use get and set?
        public abstract double Area { get; } //what to assign for area?

        public Shape(string name)
        {
            this.Name = name;
        }

        public override string ToString()
        {
            return $"Shape: {Name} Area: {Area}";
        }
    }

    public class Square : Shape
    {

        public double Length { get; protected set; }

        public Square(string name, double length) : base(name)
        {
            // parent argument comes first
            this.Length = length;
        }

        public override double Area
        {
            get { return Length * Length; }
        }

    }

    public class Circle : Square
    {

        public double Area
        {
            get { return Math.PI * Length * Length; }
        }

        public Circle(string name, double length) : base(name, length)
        {
        }
    }

    public class Rectangle : Shape
    {
        public double Width { get; protected set; }

        public double Height { get; protected set; }


        public Rectangle(string name, double width,
        double height) : base(name)
        {
            this.Width = width;
            this.Height = height;

        }
        public override double Area
        {
            get { return Width * Height; }
        }




    }

    public class Triangle : Rectangle
    {
        public Triangle(string name, double width, double height)
        : base(name, width, height)
        {
            this.Width = width;
            this.Height = height;
        }
        public override double Area
        {
            get { return 0.5 * Width * Height; }

        }
    }

    public class Ellipse : Rectangle
    {
        public Ellipse(string name, double width, double height)
        : base(name, width, height)
        {
            this.Width = width;
            this.Height = height;
        }

        public override double Area
        {
            get { return Math.PI * Width * Height; }
        }

    }
    public class Diamond : Rectangle
    {
        public Diamond(string name, double width, double height)
        : base(name, width, height)
        {
            this.Width = width;
            this.Height = height;
        }

        public override double Area
        {

            get { return Width * Height * 0.5; }
        }
    }


}