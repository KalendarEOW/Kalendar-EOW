using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalendář_EOW
{
    public partial class kalendarEOW : Form
    {
        KalendarEOW hodnota=new KalendarEOW(1,1,1);
        public int rok;
        public int den;
        public int mesic;
        public kalendarEOW(int den,int mesic,int rok)
        {
            InitializeComponent();
            this.den = den;
            this.mesic = mesic;
            this.rok = rok;
            ciselnikDen.Value = den;
            ciselnikMesic.Value = mesic;
            ciselnikRok.Value = rok;
        }


        private void tlacitkoZrusit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void tlacitkoOK_Click(object sender, EventArgs e)
        {
            den = (int)ciselnikDen.Value;
            mesic = (int)ciselnikMesic.Value;
            rok = (int)ciselnikRok.Value;
            DialogResult = DialogResult.OK;
        }
    }
}
