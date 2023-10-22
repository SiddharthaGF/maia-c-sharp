using System.Diagnostics;
using Timer = System.Windows.Forms.Timer;

namespace maia_c_sharp
{
    public partial class Form1 : Form
    {
        private readonly Bitmap canvas = new(700, 540);
        private readonly List<Color> palette0 = new();
        private Timer timer = new();
        private readonly Stopwatch stopwatch;

        public Form1()
        {
            InitializeComponent();
            stopwatch = new Stopwatch();
            palette0.Add(Color.Black);
            palette0.Add(Color.Navy);
            palette0.Add(Color.Green);
            palette0.Add(Color.Aqua);
            palette0.Add(Color.Red);
            palette0.Add(Color.Purple);
            palette0.Add(Color.Maroon);
            palette0.Add(Color.LightGray);
            palette0.Add(Color.DarkGray);
            palette0.Add(Color.Blue);
            palette0.Add(Color.Lime);
            palette0.Add(Color.Silver);
            palette0.Add(Color.Teal);
            palette0.Add(Color.Fuchsia);
            palette0.Add(Color.Yellow);
            palette0.Add(Color.White);
        }

        private void doSomething_Click(object sender, EventArgs e)
        {
            var w = new Wave
            {
                Palette = palette0,
                M = 1,
                W = 1.5,
                V = 9.3,
                X0 = 8,
                Y0 = 6.15f,
            };
            const int duration = 10000;
            long now = 0;
            timer = new Timer
            {
                Interval = 1,
            };
            timer.Tick += (sender, e) =>
            {
                w.T += 0.01;
                w.SimpleWave(canvas);
                screen.Image = canvas;
                screen.Refresh();
                now = stopwatch.ElapsedMilliseconds;
                if (now >= duration)
                {
                    stopwatch.Stop();
                    timer.Stop();
                }
            };
            timer.Start();
            stopwatch.Start();
        }
    }
}