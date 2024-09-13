using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Kalendář_EOW_Release
{
    public partial class vyberDatumuG : Form
    {
        public decimal rok;
        public int den;
        public int mesic;
        DateTime dnes;
        public vyberDatumuG(int den, int mesic, decimal rok,DateTime dnes)
        {
            if(rok==0)
                throw new ArgumentException("Rok 0 neexistuje.");
            if (rok%1!=0)
                throw new ArgumentException("Rok musí být celé číslo.");
            InitializeComponent();
            this.den = den;
            this.mesic = mesic;
            this.rok = rok;
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

        private void vyberDatumuG_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                double rokTMP = Math.Abs((double)ciselnikRok.Value);
                DateTime datum = new DateTime((int)(((rokTMP - 400) % 9600) + 400), (int)ciselnikMesic.Value, (int)ciselnikDen.Value);
            }
            catch (ArgumentOutOfRangeException)
            {
                ukazatelChyb.SetError(ciselnikDen, "Toto datum neexistuje.");
                e.Cancel = true;
            }
            if (ciselnikRok.Value == 0)
            {
                ukazatelChyb.SetError(ciselnikRok, "Rok 0 neexistuje.");
                e.Cancel = true;
            }
            if (ciselnikRok.Value == ciselnikRok.Minimum && (ciselnikMesic.Value == 3 && ciselnikDen.Value < 17 || ciselnikMesic.Value < 3))
            {
                ciselnikMesic.Value = 3;
                ciselnikDen.Value = 17;
                ukazatelChyb.SetError(ciselnikDen, "Datum 17. 3. " + ciselnikRok.Minimum + " je první datum, které tento program umí. Skutečně potřebujete tak daleko?");
                e.Cancel = true;
            }
            if (ciselnikRok.Value == ciselnikRok.Maximum && (ciselnikMesic.Value == 5 && ciselnikDen.Value > 16 || ciselnikMesic.Value > 5))
            {
                ciselnikMesic.Value = 5;
                ciselnikDen.Value = 16;
                ukazatelChyb.SetError(ciselnikDen, "Datum 16. 5. " + ciselnikRok.Maximum + " je poslední datum, které tento program umí. Skutečně potřebujete tak daleko?");
                e.Cancel = true;
            }
            return;
        }

        private void vyberDatumuG_Validated(object sender, EventArgs e)
        {
            ukazatelChyb.SetError(ciselnikDen, null);
            ukazatelChyb.SetError(ciselnikRok, null);
        }

        private void ciselnik_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown ciselnik = (NumericUpDown)sender;
            ciselnik.Validate();
        }

        private void vyberDatumuG_Resize(object sender, EventArgs e)
        {
            ciselnikDen.Size = new Size(Size.Width - 140, ciselnikDen.Height);
            ciselnikMesic.Size = new Size(Size.Width - 140, ciselnikMesic.Height);
            ciselnikRok.Size = new Size(Size.Width - 140, ciselnikRok.Height);
        }

        private void tlacitkoDnes_Click(object sender, EventArgs e)
        {
            den = dnes.Day;
            mesic = dnes.Month;
            rok = dnes.Year;
            DialogResult = DialogResult.OK;
        }
    }
}
