using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavaşOyunuProjesi
{
    class RobotDusman : IRobotDusman
    {
        public void RobotIsim(string dusmanTipi, string robotAdi)
        {
            Console.WriteLine("Dusman " + dusmanTipi + "'a " + robotAdi + " ismi verildi.");
        }

        public void YumrukAt(string dusmanTip, bool yumrukla)
        {
            if (yumrukla == true)
                Console.WriteLine("Dusman " + dusmanTip + " yumruk atti.");
            else
                Console.WriteLine("Dusman " + dusmanTip + " tarafindan saldırı yok.");
        }

        public void Yuru(string dusmanTip, bool hareket)
        {
            if (hareket == true)
                Console.WriteLine("Dusman " + dusmanTip + " ilerledi.");
            else
                Console.WriteLine("Dusman" + dusmanTip + "sabit.");
        }
    }
}
