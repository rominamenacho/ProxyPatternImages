using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPatternImages
{
    class Program
    {
        static void Main(string[] args)
        {
            IImage image = new ProxyImage("test_1.jpg");
            //la primera vez deberia ser cargada desde el disco
            image.Display();
            Console.WriteLine("Se llama nuevamente a display");
            image.Display();

            Console.ReadKey();
        }
    }
}
