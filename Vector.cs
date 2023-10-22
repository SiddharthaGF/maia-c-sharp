namespace maia_c_sharp
{
    internal class Vector : VectorExtension
    {
        public static int Sx1 { get; } = 0;
        public static int Sy1 { get; } = 0;
        public static int Sx2 { get; } = 700;
        public static int Sy2 { get; } = 540;
        public static float X1 { get; } = -8;
        public static float Y1 { get; } = -6.15f;
        public static float X2 { get; } = 8;
        public static float Y2 { get; } = 6.15f;
        public float X0 { get; set; } = 0;
        public float Y0 { get; set; } = 0;
        public Color Color { get; set; } = Color.Black;

        public Vector() { }

        protected static void Screen(double x, double y, out int sx, out int sy)
        {
            sx = (int)((x - X1) / (X1 - X2) * (Sx1 - Sx2) + Sx1);
            sy = (int)((y - Y2) / (Y2 - Y1) * (Sy1 - Sy2) + Sy1);
        }

        public virtual void On(Bitmap canvas)
        {
            Screen(X0, Y0, out var sx, out var sy);
            if (sx >= Sx1 && sx < Sx2 && sy >= Sy1 && sy < Sy2)
            {
                canvas.SetPixel(sx, sy, Color);
            }
        }

        public virtual void Off(Bitmap canvas)
        {
            for (var x = Sx1; x < Sx2; x++)
            {
                for (var y = Sy1; y < Sy2; y++)
                {
                    canvas.SetPixel(x, y, Color.White);
                }
            }
        }

        public static void Card(int xP, int yP, out double x, out double y)
        {
            x = (xP - Sx1) * ((X1 - X2) / (Sx1 - Sx2)) + X1;
            y = (yP - Sy2) * ((Y1 - Y2) / (Sy2 - Sy1)) + Y1;
        }

        public static double CardX(int xP)
        {
            return (xP - Sx1) * ((X1 - X2) / (Sx1 - Sx2)) + X1;
        }

        public static double CardY(int yP)
        {
            return (yP - Sy2) * ((Y1 - Y2) / (Sy2 - Sy1)) + Y1;
        }

    }
}
