using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageGalleryProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Gmail gmail = new Gmail();
            ImageGallery imageGallery = new ImageGallery(gmail);
            imageGallery.Share();

            ImageGallery whatsApp = new ImageGallery(new WhatsApp());
            whatsApp.Share();

            ImageGallery bluetooth = new ImageGallery(new Bluetooth());
            bluetooth.Share();
        }
    }
}
