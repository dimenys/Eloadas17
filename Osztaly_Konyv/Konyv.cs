using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osztaly_Konyv
{
    
    class Konyv
    {
        private string isbnSzam;
        private string szerzo_k;
        private string muCime;
        private int kiadasiEv;
        private string nyelv;
        private bool enciklopedia;
        private char eBook;

        public Konyv(string isbnSzam, string szerzo_k, string muCime, int kiadasiEv, string nyelv, bool enciklopedia, char eBook)
        {
            IsbnSzam = isbnSzam;
            Szerzo_k = szerzo_k;
            MuCime = muCime;
            KiadasiEv = kiadasiEv;
            Nyelv = nyelv;
            Enciklopedia = enciklopedia;
            EBook = eBook;
        }
        public Konyv()
        {

        }

        public string IsbnSzam
        {
            get { return isbnSzam; }
            //set { isbnSzam = value; }
            set
            {

                if (isbnSzam.Length != 10 || isbnSzam.Length != 13)
                {
                    throw new IsbnSzamException(isbnSzam, muCime);
                }
                isbnSzam = value;

            }
        }

        public string Szerzo_k
        {
            get { return szerzo_k; }
            set { szerzo_k = value; }
        }
        public string MuCime
        {
            get { return muCime; }
            set { muCime = value; }
        }
        public int KiadasiEv
        {
            get { return kiadasiEv; }
            set { kiadasiEv = value; }
        }
        public string Nyelv
        {
            get { return nyelv; }
            set { nyelv = value; }
        }
        public bool Enciklopedia
        {
            get { return enciklopedia; }
            set { enciklopedia = value; }
        }
        public char EBook
        {
            get { return eBook; }
            set { eBook = value; }
        }

        /*public void Ertekadas()
        {
            

        }*/
        public override string ToString()
        {
            return $"ISBN: {isbnSzam}\nSzerzők: {szerzo_k}\nMücime: {muCime}\nKiadási év: {kiadasiEv}\nNyelv: {nyelv}\nEnciklopédia: {enciklopedia}\nEbook: {eBook}";
        }

        /*
        ~Konyv() //Destruktor <--> Konstruktor
        {
            Console.WriteLine("A destruktor tette a dolgát....");
        }*/
    }
}
