using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavaşOyunuProjesi
{
   public  interface IDusman
    {
        void SilahKullan(string dusmanTipi, bool silahTuru);
        void Hizlan(string dusmanTip, bool hizliHareket);
        void DusmanAdi(string dusmanTipi, string dusmanIsmi);
    }
}
