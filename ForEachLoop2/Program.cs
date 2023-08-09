using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEachLoop2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Lütfen aranmasini istediginiz bir kelime girin : ");
            string aranacakKelime = Console.ReadLine();

            string[] kelimeler = new string[6]
            {
                "imagination",
                "desire",
                "work",
                "believe",
                "patience",
                "recpect"
            };

            KelimeBulmaca(aranacakKelime,kelimeler);


            Console.Read();
        }
        static void KelimeBulmaca(string aranacakKelime, string[] kelimeler)
        {
            bool bulundu = false;

            foreach (string kelime in kelimeler)
            {
                if (aranacakKelime == kelime)
                {
                    bulundu = true;
                    break;
                }
            }
            if (bulundu)
            {
                Console.WriteLine("Aranan kelime bulundu");
            }
            else
            {
                Console.WriteLine("Aranan kelime bulunamadı");
            }
        }
    }
}
