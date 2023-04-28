using System;

namespace FillSpheres
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
            Console.WriteLine($"Red:{s.color.GetRed()}, Green:{s.color.GetGreen()}, Blue:{s.color.GetBlue()}");
        }
    }
}
