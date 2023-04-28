using System;

namespace BetterFillSpheres
{
    class Program
    {
        static void Main(string[] args)
        {
            Color color = new Color(2, 70, 20);
            Sphere s = new Sphere(color, 2f);

            int t;
            s.Throw();
            t = s.GetTimesThrown();
            s.Pop();
            s.Throw();
            t = s.GetTimesThrown();

            Console.WriteLine(t);
            Console.WriteLine($"Red:{s.color.Red}, Green:{s.color.Green}, Blue:{s.color.Blue}");
        }
    }
}
