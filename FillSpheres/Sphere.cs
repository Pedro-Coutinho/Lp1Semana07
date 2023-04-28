namespace FillSpheres
{
    public class Sphere
    {
        public readonly Color color;
        private float radius;
        private int bounces;

        public Sphere(Color c, float r)
        {
            color = c;
            radius = r;
            bounces = 0;
        }

        public void Pop() => radius = 0;

        public void Throw()
        {
            if(radius>0)
                bounces++;
        }

        public int GetTimesThrown()=>bounces;
    }
}