using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bingo
{
    class Loto
    {

        public List<int> UplaćeniBrojevi { get; set; }

        public List<int> DobitniBrojevi { get; set; }
        public Loto()
        {
            UplaćeniBrojevi = new List<int>();
            DobitniBrojevi = new List<int>();
        }
        public bool UnesiUplaćeneBrojeve(List<string> KorisničkeVrijednosti)
        {
            bool ispravni = false;
            UplaćeniBrojevi.Clear();
            foreach (var item in KorisničkeVrijednosti)
            {
                int broj = 0;
                if(int.TryParse(item,out broj) == true)
                {
                    if(broj>=1 && broj<=39)
                    {
                        if (UplaćeniBrojevi.Contains(broj) == false)
                        {
                            UplaćeniBrojevi.Add(broj);
                        }
                    }
                }
            }
            if (UplaćeniBrojevi.Count == 7) ispravni = true;
            return ispravni;
        }
        public void GenerirajDobitnuKombinaciju()
        {
            DobitniBrojevi.Clear();
            Random GeneratorBrojeva = new Random();
            while (DobitniBrojevi.Count<7)
            {
                int broj = GeneratorBrojeva.Next(1, 39);
                if (DobitniBrojevi.Contains(broj) == false) DobitniBrojevi.Add(broj);
            }

        }
        public int IzračunajBrojPogodaka()
        {
            int brojPogodaka = 0;
            foreach (var item in UplaćeniBrojevi)
            {
                if (DobitniBrojevi.Contains(item) == true) brojPogodaka++;

            }
            return brojPogodaka;
        }
    }
}
