namespace BetterFillSpheres
{
    public class Color
    {
        public byte Red {get; set;}
        public byte Green {get; set;}
        public byte Blue {get; set;}
        public byte Alpha {get; set;} = 255;

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