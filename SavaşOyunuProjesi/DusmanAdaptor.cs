using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavaşOyunuProjesi
{
    class DusmanAdaptor : IDusman
    {
        IRobotDusman dusmanAsker;
        IDusman dusman;

        public DusmanAdaptor(string dusmanTipi)
        {
            if (dusmanTipi == "robot")
                dusmanAsker = new RobotDusman();
            else if (dusmanTipi == "tank")
                dusman = new DusmanTank();
        }
        public void DusmanAdi(string dusmanTip, string dusmanIsmi)
        {
            if (dusmanTip == "robot")
                dusmanAsker.RobotIsim(dusmanTip, dusmanIsmi);
            if (dusmanTip == "tank")
                dusman.DusmanAdi(dusmanTip, dusmanIsmi);
        }

        public void Hizlan(string dusmanTip, bool hizliHareket)
        {
            if (dusmanTip == "robot")
                dusmanAsker.Yuru(dusmanTip, hizliHareket);
            if (dusmanTip == "tank")
                dusman.Hizlan(dusmanTip, hizliHareket);
        }

        public void SilahKullan(string dusmanTipi, bool silahTuru)
        {
            if (dusmanTipi == "robot")
                dusmanAsker.YumrukAt(dusmanTipi, silahTuru);
            if (dusmanTipi == "tank")
                dusman.SilahKullan(dusmanTipi, silahTuru);
        }
    }
}