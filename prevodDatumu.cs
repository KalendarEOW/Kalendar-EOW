using System;

namespace Kalendář_EOW_Release
{
    public static class prevodDatumu
    {
        static readonly DateTime zakladniDatumG = new DateTime(2022, 2, 17);
        static readonly DatumEOW zakladniDatumEOW = new DatumEOW(4041, 1, 53);
        const int pocetDnuV9600LetechG = 3506328;
        const decimal weirdConstant = -225957647186 * 100000000000m - 7140459631m;

        public static DatumEOW naDatumEOW(DateTime k1, decimal cilovyPresah)
        {
            if ((k1.Year == 9600 && cilovyPresah == -1) || k1.Year < 400)
                throw new ArgumentException("Neplatné zadání.");

            DateTime datumG = new DateTime(zakladniDatumG.Ticks);
            DatumEOW datumEOW = new DatumEOW(zakladniDatumEOW);
            decimal presahRoku = 0;
            if (cilovyPresah <= weirdConstant)
            {
                decimal rozdil = weirdConstant - presahRoku;
                presahRoku = weirdConstant;
                datumEOW.AddDays(pocetDnuV9600LetechG * (rozdil / 2));
                datumEOW.AddDays(pocetDnuV9600LetechG * (rozdil / 2));
                datumG = datumG.AddYears(-1);
                DateTime k2 = new DateTime(400, 1, 1);
                datumEOW.AddDays(Convert.ToDecimal((k2 - datumG).TotalDays)
                    - (presahRoku != -1 || k1.Year < 9600 ? 0 : 366));
                datumG = datumG.AddDays((k2 - datumG).TotalDays);
            }
            else
            {
                if (cilovyPresah != presahRoku)
                {
                    decimal rozdil = cilovyPresah - presahRoku;
                    presahRoku = cilovyPresah;
                    datumEOW.AddDays(pocetDnuV9600LetechG * (rozdil / 2));
                    datumEOW.AddDays(pocetDnuV9600LetechG * (rozdil / 2));
                }
                if (presahRoku <= -1)
                    datumG = datumG.AddYears(-1);

                datumEOW.AddDays(Convert.ToDecimal((k1 - datumG).TotalDays)
                    - (presahRoku != -1 || k1.Year < 9600 ? 0 : 366));
                datumG = datumG.AddDays((k1 - datumG).TotalDays);
            }

            int zmena = (cilovyPresah > presahRoku) || ((cilovyPresah == presahRoku) && (k1 > zakladniDatumG)) ? 1 : -1;

            while (datumG != k1 || presahRoku != cilovyPresah)
            {
                try
                {
                    datumG = datumG.AddDays(zmena);
                    if (datumG.Year == 9600 && presahRoku == -1)
                        datumG = datumG.AddYears(zmena);
                    if (datumG.Year == 399)
                    {
                        datumG = new DateTime(9999, 12, 31);
                        presahRoku--;
                    }
                }
                catch (ArgumentOutOfRangeException)
                {
                    datumG = new DateTime(400, 1, 1);
                    presahRoku++;
                }
                datumEOW.AddDays(zmena);
            }

            return datumEOW;
        }

        public static (DateTime, decimal) naDateTime(DatumEOW k1)
        {
            (DatumEOW, DateTime, decimal) vysledek = naDatumEOW_DateTime(k1.DniDoKonceSveta);
            (DateTime, decimal) vraceni = (vysledek.Item2, vysledek.Item3);
            return vraceni;
        }

        public static (DatumEOW, DateTime, decimal) naDatumEOW_DateTime(decimal dniDoKonceSveta)
        {
            if (dniDoKonceSveta == 0)
                throw new ArgumentException("Počet dnů do konce světa nemůže být 0");


            decimal ciloveDnyDoKonceSveta = dniDoKonceSveta;


            DateTime datumG = new DateTime(zakladniDatumG.Ticks);
            DatumEOW datumEOW = new DatumEOW(zakladniDatumEOW);
            decimal presahRoku = 0;
            decimal rozdil;
            decimal podil;
            try
            {
                rozdil = datumEOW.DniDoKonceSveta - ciloveDnyDoKonceSveta;//vetší->později
            }
            catch (OverflowException)
            {
                podil = Math.Truncate(decimal.MaxValue / pocetDnuV9600LetechG);
                presahRoku += podil;
                datumEOW.AddDays(podil * pocetDnuV9600LetechG);
            }
            rozdil = datumEOW.DniDoKonceSveta - ciloveDnyDoKonceSveta + (ciloveDnyDoKonceSveta < 0 ? -1 : 0);
            rozdil += rozdil <= -pocetDnuV9600LetechG ? 1 : 0;

            podil = Math.Truncate(rozdil / pocetDnuV9600LetechG);
            presahRoku += podil;
            datumEOW.AddDays(podil * pocetDnuV9600LetechG);

            if (presahRoku <= -1)
                datumG = datumG.AddYears(-1);


            rozdil = datumEOW.DniDoKonceSveta - ciloveDnyDoKonceSveta + (ciloveDnyDoKonceSveta < 0 ? -1 : 0);
            if (presahRoku >= 1)
            {
                if (rozdil <= zakladniDatumEOW.DniDoKonceSveta - new DatumEOW(793, 7, 39).DniDoKonceSveta)
                {
                    datumG = datumG.AddDays(Convert.ToDouble(rozdil));
                    //funguje
                }
                else
                {
                    datumG = new DateTime(400, 1, 1).AddDays(Convert.ToDouble(rozdil + new DatumEOW(793, 7, 39).DniDoKonceSveta - zakladniDatumEOW.DniDoKonceSveta - 1));
                    presahRoku++;
                    //funguje
                }
            }
            else if (presahRoku <= -1)
            {
                if (rozdil >= zakladniDatumEOW.DniDoKonceSveta - new DatumEOW(4702, 13, 36).DniDoKonceSveta)
                {
                    datumG = datumG.AddDays(Convert.ToDouble(rozdil)); //funguje
                }
                else
                {
                    //funguje
                    datumG = new DateTime(9999, 12, 31).AddDays(Convert.ToDouble(rozdil + new DatumEOW(4702, 13, 36).DniDoKonceSveta - zakladniDatumEOW.DniDoKonceSveta + 1));
                    presahRoku--;
                }
            }
            else
            {
                if (rozdil > zakladniDatumEOW.DniDoKonceSveta - new DatumEOW(793, 7, 39).DniDoKonceSveta)
                {
                    datumG = new DateTime(400, 1, 1).AddDays(Convert.ToDouble(rozdil + new DatumEOW(793, 7, 39).DniDoKonceSveta - zakladniDatumEOW.DniDoKonceSveta - 1));
                    presahRoku++;
                    //funguje
                }
                else if (ciloveDnyDoKonceSveta <= new DatumEOW(4702, 8, 16).DniDoKonceSveta)
                {
                    datumG = datumG.AddDays(Convert.ToDouble(rozdil));
                    //funguje
                }
                else
                {
                    presahRoku--;
                    datumG = new DateTime(9999, 12, 31).AddDays(Convert.ToDouble(rozdil + new DatumEOW(4702, 8, 16).DniDoKonceSveta - zakladniDatumEOW.DniDoKonceSveta + 2));
                    if (datumG.Year <= 9600)
                    {
                        datumG = datumG.AddDays(-366);
                    }
                }
            }

            if (rozdil <= -3280640)
            {
                rozdil += 3;
                datumG=datumG.AddDays(3);
            }
                datumEOW.AddDays(rozdil);





            int zmena = ciloveDnyDoKonceSveta < datumEOW.DniDoKonceSveta ? 1 : -1;
            while (ciloveDnyDoKonceSveta != datumEOW.DniDoKonceSveta)
            {
                try
                {
                    datumG = datumG.AddDays(zmena);
                    if (datumG.Year == 9600 && presahRoku == -1)
                        datumG = datumG.AddYears(-1);
                    if (datumG.Year == 399)
                    {
                        datumG = new DateTime(9999, 12, 31);
                        presahRoku--;
                    }
                }
                catch (ArgumentOutOfRangeException)
                {
                    datumG = new DateTime(400, 1, 1);
                    presahRoku++;
                }
                datumEOW.AddDays(zmena);
            }

            return (datumEOW, datumG, presahRoku);
        }
    }
}
