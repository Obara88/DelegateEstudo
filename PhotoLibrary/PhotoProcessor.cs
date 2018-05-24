namespace PhotoLibrary
{   
    public class PhotoProcessor
    {
        public delegate void PhotoFilterHandler(Photo photo);

        public void Process(string photoPath, PhotoFilterHandler filterHandler)
        {
            var photo = Photo.Load(photoPath);

            filterHandler(photo);

            photo.Save();
        }
    }     
}
