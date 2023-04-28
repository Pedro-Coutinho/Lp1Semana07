namespace BetterFillSpheres
{
    public class Color
    {
        public byte Red {get; set;}
        public byte Green {get; set;}
        public byte Blue {get; set;}
        public byte Alpha {get; set;} = 255;

        public string Name
        {
            get
            {
                return this switch
                {
                    {Red: 255, Green: 0, Blue: 0} => "Red 100%",
                    {Red: 0, Green: 255, Blue: 0} => "Green 100%",
                    {Red: 0, Green: 0, Blue: 255} => "Blue 100%",
                    _ => "Mixed"
                };
            }
        }

        public Color(byte r, byte g, byte b){
            Red = r;
            Green = g;
            Blue = b;
        }

        public int GetGrey(){
            int grey;

            grey = (Red + Green + Blue)/3;

            return grey;
        }
    }
}