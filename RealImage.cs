using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPatternImages
{
    class RealImage:IImage
    {
        private String fileName;

        public RealImage(String fileName)
        {
            this.fileName = fileName;
            LoadFromDisk(fileName);
        }


        public void Display()
        {
            Console.WriteLine("Displaying  "+ fileName);
        }
        private void LoadFromDisk(String fileName)
        {
            Console.WriteLine("Loading from disk " + fileName);
        }
    }
}
