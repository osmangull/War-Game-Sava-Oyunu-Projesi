using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavaşOyunuProjesi
{
    class DusmanHazirla : IDusman
    {
        DusmanAdaptor dusmanAraSinif;
        public void DusmanAdi(string dusmanTip, string dusmanIsmi)
        {

            dusmanAraSinif = new DusmanAdaptor(dusmanTip);
            dusmanAraSinif.DusmanAdi(dusmanTip, dusmanIsmi);

        }

        public void Hizlan(string dusmanTip, bool hizliHareket)
        {
            dusmanAraSinif = new DusmanAdaptor(dusmanTip);
            dusmanAraSinif.Hizlan(dusmanTip, hizliHareket);

        }

        public void SilahKullan(string dusmanTipi, bool silahTuru)
        {
            dusmanAraSinif = new DusmanAdaptor(dusmanTipi);
            dusmanAraSinif.SilahKullan(dusmanTipi, silahTuru);
        }
    }
}
