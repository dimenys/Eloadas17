using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osztaly_Konyv
{
    
    class IsbnSzamException:Exception
    {
        string hibasIsbnSzam;
        string hibasKonyvCime;

        public string HibasIsbnSzam
        {
            get { return hibasIsbnSzam; }
            set { hibasIsbnSzam = value; }
        }

        public string HibasKonyvCime
        {
            get { return hibasKonyvCime; }
            set { hibasKonyvCime = value; }
        }

        public IsbnSzamException(string hibasIsbnSzam, string hibasKonyvCime)
        {
            HibasIsbnSzam = hibasIsbnSzam;
            HibasKonyvCime = hibasKonyvCime;
        }
    }
}
