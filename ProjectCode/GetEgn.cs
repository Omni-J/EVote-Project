using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCamPic
{
    class GetEgn
    {
        private string egn;

        public string Egn
        {
            get
            {
                return egn;
            }

            set
            {
                egn = value;
            }
        }

        public GetEgn(string egn)
        {
            this.egn = egn;
        }

        public override string ToString()
        {
            return string.Format("{0}", egn);
        }
    }
}
