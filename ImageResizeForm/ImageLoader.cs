using System.Collections.Generic;
using System.Drawing;

namespace ImageResizeForm
{
    public static class ImageLoader
    {
        public static List<Image> CreateImages(string imagePath)
        {
            List<Image> images = new List<Image>();
            Image baseImage = Image.FromFile(imagePath);
            images.Add(baseImage);
            // Scale the resolution of the base image down by 50% until there is only one pixel left.
            while (baseImage.Width > 1 && baseImage.Height > 1)
            {
                baseImage = ScaleImage(baseImage, 0.5f);
                images.Add(baseImage);
            }
            
            return images;
        }

        private static Image ScaleImage(Image baseImage, float f)
        {
            int width = (int)(baseImage.Width * f);
            int height = (int)(baseImage.Height * f);
            return new Bitmap(baseImage, width, height);
        }
    }
}