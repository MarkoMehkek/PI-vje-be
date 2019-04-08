using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace boje
{
    public partial class FormaBoje : Form
    {
        public Boje boje;
        public FormaBoje()
        {
            InitializeComponent();
            boje = new Boje();
        }
        
        private void FormaBoje_Load(object sender, EventArgs e)
        {
           
        }

        private void GumbUnos_Click(object sender, EventArgs e)
        {
            List<string> listaBoja = new List<string>();
            listaBoja.Add(PoljeZaUnos1.Text);
            listaBoja.Add(poljeZaUnos2.Text);
            listaBoja.Add(PoljeZaUnos3.Text);
            bool dobro = boje.ProvjeriBoju(listaBoja);
            if (dobro) { boje.ProslijediBoju(listaBoja);
                PromeniBoju();
            }
            if (!dobro) MessageBox.Show("Unos boja nije ispravan!");
      
           /* if (boje.prviBroj==255 && boje.drugiBroj==0 && boje.trećiBroj == 0)
            {
                this.BackColor = Color.FromArgb(255, 0, 0);
            }
            if (boje.prviBroj == 0  && boje.drugiBroj == 255 && boje.trećiBroj == 0)
            {
                this.BackColor = Color.FromArgb(0, 255, 0);
            }
            if (boje.prviBroj == 0 && boje.drugiBroj == 0 && boje.trećiBroj == 255)
            {
                this.BackColor = Color.FromArgb(0, 0, 255);
            }*/
        }
        private void PromeniBoju()
        {
            this.BackColor = Color.FromArgb(boje.prviBroj, boje.drugiBroj, boje.trećiBroj);
        }
        
    }
}
