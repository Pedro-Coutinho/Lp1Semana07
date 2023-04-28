namespace BetterFillSpheres
{
    public class Sphere
    {
        public readonly Color color;
        public float Radius{get; set;}
        private int Bounces{get; set;} = 0; 

        public Sphere(Color c, float r)
        {
            color = c;
            Radius = r;
        }

        public void Pop() => Radius = 0;

        public void Throw()
        {
            if(Radius>0)
                Bounces++;
        }

        public int GetTimesThrown()=>Bounces;
    }
}