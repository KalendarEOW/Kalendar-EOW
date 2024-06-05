using System;

namespace Kalendář_EOW
{
    class KalendarEOW
    {
        private const int DNI_V_MESICI = 69;
        private const int MESICU_V_ROCE = 13;

        public KalendarEOW(int rok, int mesic, int den)
        {
            Rok = rok;
            Mesic = mesic;
            Den = den;
        }

        public int Rok
        {

            get
            {
                return rok;
            }
            private set
            {
                rok = value;
                aktualizujDniDoKonceSveta();
            }
        }
        public int Mesic
        {
            get
            {
                return mesic;
            }
            private set
            {
                if (value > mesic)
                {
                    Rok -= value / (MESICU_V_ROCE + 1);
                    mesic = value % (MESICU_V_ROCE + 1);
                    mesic = Math.Max(mesic, 1);
                }
                else
                {
                    if (value > 0)
                    {
                        Rok -= value / (MESICU_V_ROCE + 1);
                        mesic = value % (MESICU_V_ROCE + 1);
                    }
                    else if (value < 0)
                    {
                        Rok -= (int)Math.Floor((decimal)value / (MESICU_V_ROCE + 1));
                        mesic = MESICU_V_ROCE + value;
                    }
                    else
                    {
                        Rok += 1;
                        mesic = MESICU_V_ROCE;
                    }
                }
            }
        }
        public int Den
        {
            get
            {
                return den;
            }
            private set
            {

                if (value > den)
                {
                    Mesic += value / (DNI_V_MESICI + 1);
                    den = value % (DNI_V_MESICI + 1);
                    den = Math.Max(den, 1);
                }
                else
                {
                    if (value > 0)
                    {
                        Mesic += value / (DNI_V_MESICI + 1);
                        den = value % (DNI_V_MESICI + 1);
                    }
                    else if (value < 0)
                    {
                        Mesic += (int)Math.Floor((decimal)value / (DNI_V_MESICI + 1));
                        den = DNI_V_MESICI + value;
                    }
                    else
                    {
                        Mesic -= 1;
                        den = DNI_V_MESICI;

                    }
                }
            }
        }
        public long DniDoKonceSveta
        {
            get
            {
                return dniDoKonceSveta;
            }
        }
        private void aktualizujDniDoKonceSveta()
        {
            dniDoKonceSveta = (rok - 1) * MESICU_V_ROCE * DNI_V_MESICI + (MESICU_V_ROCE - mesic) * DNI_V_MESICI + (DNI_V_MESICI - den);
        }
        private int rok;
        private int mesic;
        private int den;
        private long dniDoKonceSveta;

        public void AddDays(int value)
        {
            Den += value;
        }
        public void AddMonths(int value)
        {
            Mesic += value;
        }
        public void AddYears(int value)
        {
            Rok += value;
        }
        public override string ToString()
        {
            return den + ". " + mesic + ". " + rok;
        }

        public static bool operator ==(KalendarEOW k1, KalendarEOW k2)
        {
            bool odpovidajiRoky = k1.Rok == k2.Rok;
            bool odpovidajiMesice = k1.Mesic == k2.Mesic;
            bool odpovidajiDny = k1.Den == k2.Den;
            return odpovidajiDny && odpovidajiMesice && odpovidajiRoky;
        }

        public static bool operator !=(KalendarEOW k1, KalendarEOW k2)
        {
            bool odpovidajiRoky = k1.Rok == k2.Rok;
            bool odpovidajiMesice = k1.Mesic == k2.Mesic;
            bool odpovidajiDny = k1.Den == k2.Den;
            return !(odpovidajiDny && odpovidajiMesice && odpovidajiRoky);
        }
    }
}
