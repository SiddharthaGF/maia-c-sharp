namespace maia_c_sharp
{
    internal class Wave : Vector
    {

        public double W { get; set; } = 1;
        public double V { get; set; } = 1;
        public double M { get; set; } = 1;
        public double T { get; set; } = 0;
        public double IncrementT { set => T += value; }
        public List<Color> Palette { get; set; } = new List<Color>();
        public int Step { get; set; } = 1;

        public Wave() : base() { }

        public void SimpleWave(Bitmap canvas)
        {
            double z;
            int index;
            Start(canvas);
            for (var i = Sx1; i < Sx2; i += Step)
            {
                var x = CardX(i);
                for (var j = Sy1; j < Sy2; j += Step)
                {
                    var y = CardY(j);
                    z = W * (Math.Sqrt((x - X0) * (x - X0) + (y - Y0) * (y - Y0)) - V * T);
                    z = M * Math.Sin(z) + 1;
                    index = (int)(z * 7.5);
                    Color = Palette[index];
                    On(i, j, Color);
                }
            }
            Finish(canvas);
        }

    }
}
