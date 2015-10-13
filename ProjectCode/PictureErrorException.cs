using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCamPic
{
    class PictureErrorException: Exception
    {
        public PictureErrorException(string MASSAGE)
            :base(MASSAGE)
        {
        }
    }
}
