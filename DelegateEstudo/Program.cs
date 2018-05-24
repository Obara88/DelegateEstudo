using DelegateEstudo;
using PhotoLibrary;
using System;

namespace EstudoDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            var processor = new PhotoProcessor();
            PhotoProcessor.PhotoFilterHandler filterHandler;

            PhotoFilters filters = new PhotoFilters();
            filterHandler = filters.ApplyBrightness;

            MyCustomFilter myCustomFilter = new MyCustomFilter();
            filterHandler += myCustomFilter.MyCustomFilterMethod;

            processor.Process("path da foto", filterHandler);

            Console.Read();
        }
    }
}
