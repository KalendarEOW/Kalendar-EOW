
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Kalendář_EOW_Release
{
    public partial class vyberDatumuEOW : Form
    {
        public decimal rok;
        public int den;
        public int mesic;
        DatumEOW dnes;
        public vyberDatumuEOW(DatumEOW datumEOW, DatumEOW dnes)
        {
            InitializeComponent();
            this.den = datumEOW.Den;
            this.mesic = datumEOW.Mesic;
            this.rok = datumEOW.Rok;
            ciselnikDen.Value = den;
            ciselnikMesic.Value = mesic;
            ciselnikRok.Value = rok;
            this.dnes = dnes;
        }


        private void tlacitkoZrusit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void tlacitkoOK_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
                return;
            den = (int)ciselnikDen.Value;
            mesic = (int)ciselnikMesic.Value;
            rok = ciselnikRok.Value;
            DialogResult = DialogResult.OK;
        }

        private void ciselnik_Validated(object sender, EventArgs e)
        {
            ukazatelChyb.SetError(ciselnikRok, null);
            ukazatelChyb.SetError(ciselnikDen, null);
        }

        private void ciselnik_Validating(object sender, CancelEventArgs e)
        {
            if (ciselnikRok.Value == 0)
            {
                ukazatelChyb.SetError(ciselnikRok, "Rok 0 neexistuje.");
                e.Cancel = true;
            }
        }

        private void vyberDatumuEOW_Resize(object sender, EventArgs e)
        {
            ciselnikDen.Size = new Size(Size.Width - 140, ciselnikDen.Height);
            ciselnikMesic.Size = new Size(Size.Width - 140, ciselnikMesic.Height);
            ciselnikRok.Size = new Size(Size.Width - 140, ciselnikRok.Height);
        }

        private void tlacitkoDnes_Click(object sender, EventArgs e)
        {
            den = dnes.Den;
            mesic = dnes.Mesic;
            rok = dnes.Rok;
            DialogResult = DialogResult.OK;
        }
    }
}
