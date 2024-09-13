
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Kalendář_EOW_Release
{
    public partial class oknoProgramu : Form
    {
        DatumEOW datumEOW;
        DateTime datumG;
        DatumEOW datumPriSpusteniEOW;
        DateTime datumPriSpusteniG;

        decimal rok;
        decimal presahRoku = 0;
        bool interakceUzivatele = false;

        public oknoProgramu()
        {
            MessageBox.Show("Verze 2.6");
            InitializeComponent();
        }

        private void oknoProgramu_Load(object sender, EventArgs e)
        {
            datumPriSpusteniG = DateTime.Today;
            datumG = datumPriSpusteniG;
            rok = datumPriSpusteniG.Year;
            datumEOW = prevodDatumu.naDatumEOW(datumG, presahRoku);
            datumPriSpusteniEOW = datumEOW;
            aktualizujTexty();
            interakceUzivatele = true;
        }

        private void ciselnikDny_ValueChanged(object sender, EventArgs e)
        {
            if (!interakceUzivatele || !ValidateChildren())
                return;

            (DatumEOW, DateTime, decimal) vysledek = prevodDatumu.naDatumEOW_DateTime(ciselnikDny.Value);
            datumG = vysledek.Item2;
            datumEOW = vysledek.Item1;
            presahRoku = vysledek.Item3;

            aktualizujTexty();
        }

        private void poleDatumuG_Click(object sender, EventArgs e)
        {
            vyberDatumuG oknoKalendare = new vyberDatumuG(datumG.Day, datumG.Month, rok, datumPriSpusteniG);
            oknoKalendare.Size = new Size((int)Math.Max(Math.Min(176 + 6 * Math.Floor(Math.Log10(Math.Abs(Convert.ToDouble(rok)))), oknoKalendare.MaximumSize.Width), oknoKalendare.MinimumSize.Width), oknoKalendare.Size.Height);
            if (oknoKalendare.ShowDialog() == DialogResult.Cancel)
                return;
            rok = oknoKalendare.rok;
            presahRoku = Math.Truncate((rok - 400) / 9600);
            datumG = new DateTime((int)(((rok - 400) % 9600) + (rok < 400&& ((rok - 400) % 9600!=0)? 10000 : 400)), oknoKalendare.mesic, oknoKalendare.den);
            presahRoku -= rok < 400 && ((rok - 400) % 9600 != 0) ? 1 : 0;

            datumEOW = prevodDatumu.naDatumEOW(datumG, presahRoku);
            aktualizujTexty();
        }

        private void poleEOW_Click(object sender, EventArgs e)
        {
            vyberDatumuEOW oknoKalendare = new vyberDatumuEOW(datumEOW, datumPriSpusteniEOW);
            oknoKalendare.Size = new Size((int)Math.Max(Math.Min(176 + 6 * Math.Floor(Math.Log10(Math.Abs(Convert.ToDouble(rok)))), oknoKalendare.MaximumSize.Width), oknoKalendare.MinimumSize.Width), oknoKalendare.Size.Height);

            if (oknoKalendare.ShowDialog() == DialogResult.Cancel)
                return;


            datumEOW = new DatumEOW(oknoKalendare.rok, oknoKalendare.mesic, oknoKalendare.den);
            ciselnikDny.Value = datumEOW.DniDoKonceSveta;
        }
        private void aktualizujTexty()
        {
            interakceUzivatele = false;
            rok = datumG.Year + 9600 * presahRoku;
            poleEOW.Text = datumEOW.ToString();
            poleG.Text = datumG.Day + ". " + datumG.Month + ". " + rok.ToString();
            ciselnikDny.Value = datumEOW.DniDoKonceSveta;
            poleLetG.Text = (11946 - rok - (datumG.Month > 4 || (datumG.Month == 4 && datumG.Day > 16) ? 1 : 0)).ToString();
            interakceUzivatele = true;
        }

        private void ciselnikDny_Validated(object sender, EventArgs e)
        {
            ukazatelChyb.SetError(ciselnikDny, null);
        }

        private void ciselnikDny_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (ciselnikDny.Value == 0)
            {
                ukazatelChyb.SetError(ciselnikDny, "Počet dnů do konce světa nemůže být 0");
                e.Cancel = true;
            }
        }
    }
}