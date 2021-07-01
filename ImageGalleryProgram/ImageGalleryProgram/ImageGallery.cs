using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageGalleryProgram
{
    public class ImageGallery
    {
        IShareImage _share;
        public ImageGallery(IShareImage share)
        {
            this._share = share;
        }

        public void Share()
        {
            _share.Send();

        }
    }
}
