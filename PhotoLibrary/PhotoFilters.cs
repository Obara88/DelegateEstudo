using System;

namespace PhotoLibrary
{
    public class PhotoFilters
    {
        public PhotoFilters() { }

        public void ApplyBrightness(Photo photo)
        {
            Console.WriteLine("ApplyBrightness");
        }

        public void ApplyConstrast(Photo photo)
        {
            Console.WriteLine("ApplyConstrast");
        }

        public void Resize(Photo photo)
        {
            Console.WriteLine("Resize");
        }
    }
}
