using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L3_Krupier
{
    class Krupier
    {
        private string[] duzaTalia = new string[]
        {
            "A-karo","K-karo","D-karo","W-karo","10-karo","9-karo","8-karo","7-karo","6-karo","5-karo","4-karo","3-karo","2-karo",
            "A-kier","K-kier","D-kier","W-kier","10-kier","9-kier","8-kier","7-kier","6-kier","5-kier","4-kier","3-kier","2-kier",
            "A-trefl","K-trefl","D-trefl","W-trefl","10-trefl","9-trefl","8-trefl","7-trefl","6-trefl","5-trefl","4-trefl","3-trefl","2-trefl",
            "A-pik","K-pik","D-pik","W-pik","10-pik","9-pik","8-pik","7-pik","6-pik","5-pik","4-pik","3-pik","2-pik"
        };
        private string[] malaTalia = new string[]
        {
            "A-karo","K-karo","D-karo","W-karo","10-karo","9-karo",
            "A-kier","K-kier","D-kier","W-kier","10-kier","9-kier",
            "A-trefl","K-trefl","D-trefl","W-trefl","10-trefl","9-trefl",
            "A-pik","K-pik","D-pik","W-pik","10-pik","9-pik"
        };
        List<string> talia;
        private int rodzajTalii = 1;
        Random random;

        public Krupier(int t=1)
        {
            random = new Random();
            if (t == 2)
            {
                talia = new List<string>(malaTalia);
                rodzajTalii = 2;
            }
                
            else
                talia = new List<string>(duzaTalia);
        }

        public string wezKarte()
        {

            if (talia.Count > 0)
            {
                int nr = random.Next(talia.Count());
                string s = talia[nr];
                talia.RemoveAt(nr);
                return s;
            }
            else
                return "Brak kart";
        }

        public List<string> wezKarty(int ile)
        {
            List<string> temp = new List<string>();
            for (int i=0; i<ile; i++)
            {
                temp.Add(wezKarte());
            }

            return temp;
        }

        public void potasuj()
        {
            talia.Clear();
            if (rodzajTalii == 2)
                talia.AddRange(malaTalia);
            else
                talia.AddRange(duzaTalia);
        }
    }
}
