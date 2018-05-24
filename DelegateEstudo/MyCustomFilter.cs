using PhotoLibrary;
using System;

namespace DelegateEstudo
{
    public class MyCustomFilter
    {
        public void MyCustomFilterMethod(Photo photo)
        {
            Console.WriteLine("Apply Custom Filter");
        }
    }
}
