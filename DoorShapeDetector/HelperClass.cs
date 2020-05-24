using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


   public static  class HelperClass
    {

    public static Bitmap CropImage(Image  src, int X, int Y, int Width, int Height)
    {

        
        System.Drawing.Rectangle cropRect = new System.Drawing.Rectangle(X, Y, Width, Height);
        Bitmap target = new Bitmap(cropRect.Width, cropRect.Height);

        using (Graphics g = Graphics.FromImage(target))
        {
            g.DrawImage(src, new System.Drawing.Rectangle(0, 0, target.Width, target.Height),
                             cropRect,
                             GraphicsUnit.Pixel);
        }
        return target;
    }
}

