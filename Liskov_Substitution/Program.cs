using Liskov_Substitution.Apply_Principle;
//using Liskov_Substitution.Problem;


namespace Liskov_Substitution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BEFORE

            //Rectangle rectangle = new Rectangle();
            //rectangle.Width = 5;
            //rectangle.Hight = 10;
            //Console.WriteLine(rectangle.Area()); // 50


            //Rectangle sqare = new Sqare();
            //sqare.Width = 5;
            //sqare.Hight = 10;
            //Console.WriteLine(sqare.Area()); // 100

            // The problem is that the Sqare class is not substitutable for the Rectangle class, because it violates the Liskov Substitution Principle.

            //*******************************************************************

            // AFTER

            List<Shape> shapes = new List<Shape>() {
              new Rectangle() { Width = 5, Hight = 10 },
                new Sqare() { Side = 5 }
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine(shape.Area());
            }
        }
    }
}
