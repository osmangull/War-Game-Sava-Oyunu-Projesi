using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavaşOyunuProjesi
{
    interface IRobotDusman
    {
        void YumrukAt(string dusmanTip, bool yumrukla);
        void Yuru(string dusmanTip, bool hareket);
        void RobotIsim(string dusmanTipi, string robotAdi);
    }
}
