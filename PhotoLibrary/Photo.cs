using System;

namespace PhotoLibrary
{
    public class Photo
    {
        public static Photo Load(string path)
        {
            return new Photo();
        }

        public void Save()
        {

        }
    }
    //var processor = new PhotoProcessor();
    //var filter = new PhotoFilters();
    //PhotoProcessor.PhotoFilterHandler filterHandler = new PhotoProcessor.PhotoFilterHandler(filter.ApplyBrightness);
    //filterHandler += new PhotoProcessor.PhotoFilterHandler(filter.Resize);
    //PhotoProcessor.PhotoFilterHandler filterHandler2 = new PhotoProcessor.PhotoFilterHandler(filter.ApplyBrightness);
    //processor.Proces("path", filterHandler);
}
