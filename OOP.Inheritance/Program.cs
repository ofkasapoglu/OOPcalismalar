using System;

namespace OOP.Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var s1 = new Rectangle(10, 20);
            Console.WriteLine("{0},{1}",s1.X, s1.Y);


            var s2 = new Circle(25, 35);
            Console.WriteLine("{0},{1}", s2.X, s2.Y);

            var s3 = new Square(45,55);
            Console.WriteLine("{0},{1}", s3.X, s3.Y);


            var s4 = new Triangle(60,70);
            Console.WriteLine("{0},{1}", s4.X, s4.Y);

            Console.ReadKey();

        }

        private static void Polymorphism()
        {
            var shapes = new List<Shape>()
            {
                new Rectangle(),
                new Circle(),
                new Triangle(),
                new Square()
            };

            foreach (var shape in shapes)
            {
                shape.Draw();
            }

            new Square().Calculate();
        }

        private static void viryualKeyword()
            {
                var _s1 = new Rectangle();
                var _s2 = new Circle();

                _s1.X = 10;
                _s1.Y = 100;
                Console.WriteLine("{0},{1}", _s1.X, _s1.Y);
                _s1.Draw();

                _s2.X = 5;
                _s2.Y = 55;
                Console.WriteLine("{0},{1}", _s2.X, _s2.Y);
                _s2.Draw();

                new Triangle().Draw();
            }
    }
}