using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavaşOyunuProjesi
{
    class Program
    {
        static void Main(string[] args)
        {
            DusmanHazirla enemy = new DusmanHazirla();
            Console.WriteLine("Savaş alanı hazırlanıyor...");
            Console.WriteLine("Düşman birlikleri belirlendi...");

            enemy.DusmanAdi("tank", "Leopard 1");
            enemy.DusmanAdi("robot", "Babür");
            enemy.DusmanAdi("tank", "Agusta-Bell");
            enemy.Hizlan("robot", true);
            enemy.Hizlan("tank", true);
            enemy.SilahKullan("tank", false);
            enemy.SilahKullan("robot", false);  //SİLAHLAR KONUŞMASIN :))
            Console.WriteLine("Ordumuz düşmanı püsküttü düşman saldirmiyor...");

            Console.ReadKey();
        }


    }
}
