using System;

namespace BetterFillSpheres
{
    class Program
    {
        static void Main(string[] args)
        {
            Color color = new Color(0, 255, 0);
            Sphere s = new Sphere(color, 2f);

            int t;
            s.Throw();
            t = s.GetTimesThrown();
            s.Pop();
            s.Throw();
            t = s.GetTimesThrown();

            Console.WriteLine(t);
            Console.WriteLine($"Name:{s.color.Name}");
        }
    }
}
