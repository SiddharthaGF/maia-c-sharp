using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace maia_c_sharp
{
    public class VectorExtension
    {

        private BitmapData? canvasData;
        private int bytesPerPixel;
        private byte[]? pixelData;
        private int stride;

        public void Start(Bitmap canvas)
        {
            var canvasWidth = canvas.Width;
            var canvasHeight = canvas.Height;
            canvasData = canvas.LockBits(new Rectangle(0, 0, canvasWidth, canvasHeight), ImageLockMode.WriteOnly, canvas.PixelFormat);
            bytesPerPixel = Image.GetPixelFormatSize(canvas.PixelFormat) / 8;
            stride = canvasData.Stride;
            pixelData = new byte[stride * canvasHeight];
        }

        public virtual void On(int x, int y, Color Color)
        {
            var offset = (y * stride) + (x * bytesPerPixel);
            pixelData![offset] = Color.B;
            pixelData[offset + 1] = Color.G;
            pixelData[offset + 2] = Color.R;
            pixelData[offset + 3] = Color.A;
        }

        public void Finish(Bitmap canvas)
        {
            Marshal.Copy(pixelData!, 0, canvasData!.Scan0, pixelData!.Length);
            canvas.UnlockBits(canvasData);
        }

    }
}
