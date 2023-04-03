using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osztaly_Konyv
{

    class Program
    {
        static void Main(string[] args)
        {
            //Könyv osztály (Konyv)
            //isbnSzám (isbnSzam)
            //Szerző(k) (szerzo_k)
            //Mű cime (muCime)
            //Kiadási Év (kiadasiEv)
            //Nyelv (nyelv)
            //Enciklopédia (enciklopedia) - bool
            //E-könyv? (eBook) - char - i/n


            Konyv egy = new Konyv();
            /*
            for (int i = 0; i < 10000; i++)
            {
                Konyv konyv = new Konyv(1212, "1212121", "Igen", 2000, "Gy", true, 'i');

            }*/
            while (true)
            {


                try
                {


                    Console.Write("Adja meg a könyv isbn számát: ");
                    string szam = Console.ReadLine();
                    if (szam == "" || szam == string.Empty)
                    {
                        break;
                    }
                    egy.IsbnSzam = szam;

                    Console.WriteLine("A könyv szerzői: ");
                    egy.Szerzo_k = Console.ReadLine();
                    Console.Write("A mü cime: ");
                    egy.MuCime = Console.ReadLine();
                    Console.Write("Kiadási év: ");
                    egy.KiadasiEv = int.Parse(Console.ReadLine());
                    Console.Write("Nyelve: ");
                    egy.Nyelv = Console.ReadLine();
                    Console.Write("Enciklopédia: ");
                    egy.Enciklopedia = bool.Parse(Console.ReadLine());
                    Console.Write("ebook: ");
                    egy.EBook = char.Parse(Console.ReadLine());
                    // egy.Ertekadas();
                }
                catch (IsbnSzamException e)
                {
                    Console.WriteLine($"Hibás isbn szám: {e.HibasIsbnSzam} Hibás könyv cime: {e.HibasKonyvCime}");
                }
                catch
                {
                    Console.WriteLine("Elkurtxk, nem kicsit, nagyon");
                }
            }

            /*
            
            
            finally
            {
                Console.WriteLine("Elkurtxk, nem kicsit, nagyon");
            }*/



            Console.WriteLine(egy.ToString());
            Console.ReadKey();

        }
    }
}
