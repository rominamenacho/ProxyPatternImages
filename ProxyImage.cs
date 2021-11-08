using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPatternImages
{
    class ProxyImage : IImage
    {
        private String fileName;
        private RealImage realImage;


        public ProxyImage(String fileName)
        {
            this.fileName = fileName;
        }
        public void Display()
        {
           if(realImage == null)
            {
                realImage = new RealImage(fileName);
            }
            realImage.Display();
        }
    }
}
