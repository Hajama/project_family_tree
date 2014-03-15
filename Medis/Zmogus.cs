using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medis
{
            // kintamieji
    class Zmogus
    {
        private string vardas;  // Žmogaus vardas
        private string pavarde;
        private string lytis;
        private int gim_metai;
        private string seim_padet;
        private string gyv_mires;
        private int mano_ID;
        private int tevo_ID;


        public Zmogus()
        {
            vardas = "";
            pavarde = "";
            lytis = "";
            gim_metai = 0;
            seim_padet = "";
            gyv_mires = "";
            mano_ID = 0;
            tevo_ID = 0;
        }

        public Zmogus(string vard, string pav, string lyt, int met, string sp, string gyv_m, int m_ID, int t_ID)
        {
            vardas = vard;
            pavarde = pav;
            lytis = lyt;
            gim_metai = met;
            seim_padet = sp;
            gyv_mires = gyv_m;
            mano_ID = m_ID;
            tevo_ID = t_ID;
            //Sveikas pasauli
        }
    }
}
