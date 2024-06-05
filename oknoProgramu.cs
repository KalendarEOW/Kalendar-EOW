using System;
using System.Windows.Forms;

namespace Kalendář_EOW
{
    public partial class oknoProgramu : Form
    {
        readonly KalendarEOW zakladniDatumEOW = new KalendarEOW(4041, 1, 53);
        readonly DateTime zakladniDatumG = new DateTime(2022, 2, 17);
        KalendarEOW datumEOW;
        bool interakceUzivatele = true;
        public oknoProgramu()
        {
            MessageBox.Show("Verze 1.2");
            InitializeComponent();
        }

        private void oknoProgramu_Load(object sender, EventArgs e)
        {
            DateTime časPřiSpuštění = DateTime.Today;
            UkazatelDatumuG.Value = časPřiSpuštění;
        }

        private void datumG_ValueChanged(object sender, EventArgs e)
        {
            if (!interakceUzivatele)
                return;
            interakceUzivatele = false;
            DateTime ciloveDatumG = UkazatelDatumuG.Value;
            DateTime datumG = new DateTime(zakladniDatumG.Year, zakladniDatumG.Month, zakladniDatumG.Day);
            datumEOW = new KalendarEOW(zakladniDatumEOW.Rok, zakladniDatumEOW.Mesic, zakladniDatumEOW.Den);

            if (ciloveDatumG > zakladniDatumG)
            {
                do
                {
                    datumG = datumG.AddDays(1);
                    datumEOW.AddDays(1);
                } while (datumG != ciloveDatumG);
                poleEOW.Text = datumEOW.ToString();
                poleDny.Text = datumEOW.DniDoKonceSveta.ToString();
                poleLetG.Text = (Convert.ToInt32(poleDny.Text) / 365).ToString();

            }
            else if (ciloveDatumG < zakladniDatumG)
            {
                do
                {
                    datumG = datumG.AddDays(-1);
                    datumEOW.AddDays(-1);
                } while (datumG != ciloveDatumG);
                poleEOW.Text = datumEOW.ToString();
                poleDny.Text = datumEOW.DniDoKonceSveta.ToString();
                poleLetG.Text = (Convert.ToInt32(poleDny.Text) / 365).ToString();
            }
            else
            {
                poleEOW.Text = datumEOW.ToString();
                poleDny.Text = datumEOW.DniDoKonceSveta.ToString();
                poleLetG.Text = (Convert.ToInt32(poleDny.Text) / 365).ToString();
            }
            interakceUzivatele = true;
        }

        private void poleEOW_Click(object sender, EventArgs e)
        {
            kalendarEOW oknoKalendare = new kalendarEOW(datumEOW.Den, datumEOW.Mesic, datumEOW.Rok);
            oknoKalendare.ShowDialog();
            datumEOW = new KalendarEOW(oknoKalendare.rok, oknoKalendare.mesic, oknoKalendare.den);
            poleEOW.Text = datumEOW.ToString();
        }

        private void poleEOW_TextChanged(object sender, EventArgs e)
        {
            if (!interakceUzivatele)
                return;
            interakceUzivatele = false;
            KalendarEOW ciloveDatumEOW = datumEOW;
            DateTime datumG = new DateTime(zakladniDatumG.Year, zakladniDatumG.Month, zakladniDatumG.Day);
            datumEOW = new KalendarEOW(zakladniDatumEOW.Rok, zakladniDatumEOW.Mesic, zakladniDatumEOW.Den);

            if (ciloveDatumEOW.Rok < zakladniDatumEOW.Rok || (ciloveDatumEOW.Rok == zakladniDatumEOW.Rok && ciloveDatumEOW.Mesic > zakladniDatumEOW.Mesic) || (ciloveDatumEOW.Rok == zakladniDatumEOW.Rok && ciloveDatumEOW.Mesic == zakladniDatumEOW.Mesic && ciloveDatumEOW.Den > zakladniDatumEOW.Den))
            {
                do
                {
                    datumG = datumG.AddDays(1);
                    datumEOW.AddDays(1);
                } while (datumEOW != ciloveDatumEOW);
                UkazatelDatumuG.Text = datumG.ToString();
                poleDny.Text = datumEOW.DniDoKonceSveta.ToString();
                poleLetG.Text = (Convert.ToInt32(poleDny.Text) / 365).ToString();

            }
            else if (ciloveDatumEOW != zakladniDatumEOW)
            {
                do
                {
                    datumG = datumG.AddDays(-1);
                    datumEOW.AddDays(-1);
                } while (datumEOW != ciloveDatumEOW);
                UkazatelDatumuG.Text = datumG.ToString();
                poleDny.Text = datumEOW.DniDoKonceSveta.ToString();
                poleLetG.Text = (Convert.ToInt32(poleDny.Text) / 365).ToString();
            }
            interakceUzivatele = true;
        }

        private void poleDny_TextChanged(object sender, EventArgs e) //nevyužíváno
        {
            if (!interakceUzivatele)
                return;
            interakceUzivatele = false;
            try
            {
                long ciloveDnyDoKonceSveta = Convert.ToInt64(poleDny.Text);
                DateTime datumG = new DateTime(zakladniDatumG.Year, zakladniDatumG.Month, zakladniDatumG.Day);
                datumEOW = new KalendarEOW(zakladniDatumEOW.Rok, zakladniDatumEOW.Mesic, zakladniDatumEOW.Den);
                if (ciloveDnyDoKonceSveta < datumEOW.DniDoKonceSveta)
                {
                    do
                    {
                        datumG = datumG.AddDays(1);
                        datumEOW.AddDays(1);
                    } while (ciloveDnyDoKonceSveta != datumEOW.DniDoKonceSveta);
                    poleEOW.Text = datumEOW.ToString();
                    UkazatelDatumuG.Value = datumG;
                    poleLetG.Text = (Convert.ToInt32(poleDny.Text) / 365).ToString();

                }
                else if (ciloveDnyDoKonceSveta > datumEOW.DniDoKonceSveta)
                {
                    do
                    {
                        datumG = datumG.AddDays(-1);
                        datumEOW.AddDays(-1);
                    } while (ciloveDnyDoKonceSveta != datumEOW.DniDoKonceSveta);
                    poleEOW.Text = datumEOW.ToString();
                    UkazatelDatumuG.Value = datumG;
                    poleLetG.Text = (Convert.ToInt32(poleDny.Text) / 365).ToString();
                }
                else
                {
                    poleEOW.Text = datumEOW.ToString();
                    UkazatelDatumuG.Value = datumG;
                    poleLetG.Text = (Convert.ToInt32(poleDny.Text) / 365).ToString();
                }
            }
            catch (ArgumentOutOfRangeException)
            {

            }
            interakceUzivatele = true;
        }
    }
}
