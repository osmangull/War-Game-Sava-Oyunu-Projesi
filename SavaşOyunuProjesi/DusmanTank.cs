using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavaşOyunuProjesi
{
    class DusmanTank : IDusman
    {


        public void DusmanAdi(string dusmanTipi, string dusmanAdi)
        {
            Console.WriteLine("Tehlikeli Düşman " + dusmanTipi + "'a " + dusmanAdi + " adı verildi");
        }

        public void Hizlan(string dusmanTip, bool hizliHareket)
        {
            if (hizliHareket == true)
                Console.WriteLine("Düşman " + dusmanTip + " çok hızlı.");
            else
                Console.WriteLine("Düşman " + dusmanTip + " yavaş.");
        }

        public void SilahKullan(string dusmanTipi, bool silahTuru)
        {
            if (silahTuru == true)
                Console.WriteLine("Tehlikeli Düşman " + dusmanTipi + " ateş etti.");
            else
                Console.WriteLine("Tehlikeli Düşman" + dusmanTipi + " şu an sakin görünüyor saldırı yok.");
        }

    }
}
