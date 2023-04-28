namespace FillSpheres
{
    public class Color
    {
        private byte[] color = new byte[4];

        public Color(byte r, byte g, byte b){
            color[0] = r;
            color[1] = g;
            color[2] = b;
            color[3] = 255;
        }

        public byte GetRed() => color[0];
        public byte GetGreen() => color[1];
        public byte GetBlue() => color[2];
        public byte GetAlpha() => color[3];

        public int GetGrey(){
            int grey;

            grey = (color[0] + color[1] + color[2])/3;

            return grey;
        }

        private void SetRed(byte value) => color[0] = value;
        private void SetGreen(byte value) => color[1] = value;
        private void SetBlue(byte value) => color[2] = value;
        private void SetAlpha(byte value) => color[3] = value;
    }
}