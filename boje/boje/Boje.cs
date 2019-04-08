using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boje
{
    public class Boje
    {
        public int prviBroj { get; set; }
        public int drugiBroj { get; set; }
        public int trećiBroj { get; set; }
        public List<int> listaBoja = new List<int>();
        public Boje()

        {
           
        }
        public bool ProvjeriBoju(List<string> boje)
        {
            bool ispravno = false;

            foreach (var item in boje)
            {
                int broj = 0;
            
                if(int.TryParse(item, out broj) == true)
                {
                    if (int.Parse(item) <= 255 && int.Parse(item) >= 0)
                    {
                        listaBoja.Add(int.Parse(item));
                        
                    }
                   

                }
                
            }
            if (listaBoja.Count==3) ispravno = true;
            listaBoja.Clear();
            return ispravno;
        }
        public void ProslijediBoju(List<string> boje)
        {

            this.prviBroj = int.Parse(boje[0]);
            this.drugiBroj = int.Parse(boje[1]);
            this.trećiBroj = int.Parse(boje[2]);
            
        }
    }
}
