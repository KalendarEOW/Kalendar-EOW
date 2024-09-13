using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalendář_EOW_Release
{
    public class DatumEOW
    {
        private const int DNI_V_MESICI = 69;
        private const int MESICU_V_ROCE = 13;
        private bool jeUpravenProMinus = false;


        private decimal rok;
        private int mesic;
        private int den;
        private decimal dniDoKonceSveta;

        public DatumEOW(decimal rok, int mesic, int den)
        {
            if (rok % 1 != 0)
                throw new ArgumentException("Rok musí být celé číslo");
            if (rok == 0)
                throw new ArgumentOutOfRangeException("Rok nemůže být 0");
            if (mesic < 1 || mesic > MESICU_V_ROCE)
                throw new ArgumentOutOfRangeException("Měsíc musí být v rozmezí 1-" + MESICU_V_ROCE);
            if (den < 1 || den > DNI_V_MESICI)
                throw new ArgumentOutOfRangeException("Den musí být v rozmezí 1-" + DNI_V_MESICI);

            if (rok < 0)
                jeUpravenProMinus = true;

            this.mesic = mesic;
            this.den = den;
            this.rok = rok;
            try
            {
                aktualizujDniDoKonceSveta();
            }
            catch (Exception)
            {
                throw new ArgumentOutOfRangeException("Toto datum je příliš velké nebo příliš malé.");
            }
        }
        public DatumEOW(DatumEOW k1) : this(k1.Rok, k1.Mesic, k1.Den)
        {
        }

        public decimal Rok
        {

            get
            {
                return rok;
            }
            private set
            {
                rok = value;
                if (jeUpravenProMinus && rok >= 0)
                {
                    rok += 1;
                    jeUpravenProMinus = false;
                }
                else if (!jeUpravenProMinus && rok <= 0)
                {
                    rok -= 1;
                    jeUpravenProMinus = true;
                }
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
                if (value > MESICU_V_ROCE)
                {
                    mesic = value - MESICU_V_ROCE;
                    rok -= 1;
                }
                else if (value <= 0)
                {
                    mesic = value + MESICU_V_ROCE;
                    rok += 1;
                }
                else
                    mesic = value;
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
                if (value > DNI_V_MESICI)
                {
                    den = value - DNI_V_MESICI;
                    mesic += 1;
                }
                else if (value <= 0)
                {
                    den = value + DNI_V_MESICI;
                    mesic -= 1;
                }
                else
                    den = value;
            }
        }
        public decimal DniDoKonceSveta
        {
            get
            {
                return dniDoKonceSveta;
            }
        }
        private void aktualizujDniDoKonceSveta()
        {
            if (rok > 0)
            {
                if (rok % 2 == 1 && 0.5m*rok * MESICU_V_ROCE * DNI_V_MESICI % 1 == 0)
                {
                    dniDoKonceSveta = (0.5m*rok * MESICU_V_ROCE * DNI_V_MESICI) - (mesic * DNI_V_MESICI) + (DNI_V_MESICI - den) + 2 + (0.5m * rok * MESICU_V_ROCE * DNI_V_MESICI);
                }
                else
                {
                    dniDoKonceSveta = (0.5m*rok * MESICU_V_ROCE * DNI_V_MESICI) - (mesic * DNI_V_MESICI) + (DNI_V_MESICI - den) + 1 + (0.5m * rok * MESICU_V_ROCE * DNI_V_MESICI);
                }
            }
            else
                dniDoKonceSveta = (rok + 1) * MESICU_V_ROCE * DNI_V_MESICI - (mesic - 1) * DNI_V_MESICI - den;
        }
        

        /// <summary>
        /// Simuluje posun o několik dní.
        /// </summary>
        /// <param name="value">Celé číslo. Kladná hodnota posouvá do budoucnosti.</param>
        public void AddDays(decimal value)
        {
            if (value % 1 != 0)
                throw new ArgumentException();
            Den += (int)(value % DNI_V_MESICI);
            AddMonths(Math.Truncate(value / DNI_V_MESICI));
        }

        /// <summary>
        /// Simuluje posun o několik měsíců.
        /// </summary>
        /// <param name="value">Celé číslo. Kladná hodnota posouvá do budoucnosti.</param>
        public void AddMonths(decimal value)
        {
            if (value % 1 != 0)
                throw new ArgumentException();
            Mesic += (int)(value % MESICU_V_ROCE);
            AddYears(Math.Truncate(value / MESICU_V_ROCE));
        }

        /// <summary>
        /// Simuluje posun o několik let.
        /// </summary>
        /// <param name="value">Celé číslo. Kladná hodnota posouvá do budoucnosti.</param>
        public void AddYears(decimal value)
        {
            if (value % 1 != 0)
                throw new ArgumentException();
            Rok -= value;
        }

        public override string ToString()
        {
            return den + ". " + mesic + ". " + rok;
        }

        public override bool Equals(object obj)
        {
            return obj is DatumEOW eOW &&
                   DniDoKonceSveta == eOW.DniDoKonceSveta;
        }

        public override int GetHashCode()
        {
            return 1809636484 + DniDoKonceSveta.GetHashCode();
        }

        /// <summary>
        /// Určí zda jsou dva DatumEOW stejné.
        /// </summary>
        /// <param name="k1"></param>
        /// <param name="k2"></param>
        /// <returns>true pokud k1 reprezentuje stejné datum jako k2,jinak false.</returns>
        public static bool operator ==(DatumEOW k1, DatumEOW k2)
        {
            return k1.DniDoKonceSveta == k2.DniDoKonceSveta;
        }

        /// <summary>
        /// Určí zda jsou dva DatumEOW rozdílné.
        /// </summary>
        /// <param name="k1"></param>
        /// <param name="k2"></param>
        /// <returns>true pokud k1 reprezentuje jiné datum než k2,jinak false.</returns>
        public static bool operator !=(DatumEOW k1, DatumEOW k2)
        {
            return k1.DniDoKonceSveta != k2.DniDoKonceSveta;
        }

        /// <summary>
        /// Určí zda je první DatumEOW později než druhé DatumEOW.
        /// </summary>
        /// <param name="k1"></param>
        /// <param name="k2"></param>
        /// <returns>true pokud je k1 později než k2,jinak false.</returns>
        public static bool operator >(DatumEOW k1, DatumEOW k2)
        {
            return k1.DniDoKonceSveta < k2.DniDoKonceSveta;
        }

        /// <summary>
        /// Určí zda je první DatumEOW dříve než druhé DatumEOW.
        /// </summary>
        /// <param name="k1"></param>
        /// <param name="k2"></param>
        /// <returns>true pokud je k1 dříve než k2,jinak false.</returns>
        public static bool operator <(DatumEOW k1, DatumEOW k2)
        {
            return k1.DniDoKonceSveta > k2.DniDoKonceSveta;
        }

        /// <summary>
        /// Určí zda první DatumEOW reprezentuje dřívější nebo stejné datum jako druhé DatumEOW.
        /// </summary>
        /// <param name="k1"></param>
        /// <param name="k2"></param>
        /// <returns>true pokud je k1 dříve nebo stejné jako k2,jinak false.</returns>
        public static bool operator <=(DatumEOW k1, DatumEOW k2)
        {
            return k1.DniDoKonceSveta >= k2.DniDoKonceSveta;
        }

        /// <summary>
        /// Určí zda první DatumEOW reprezentuje pozdější nebo stejné datum jako druhé DatumEOW.
        /// </summary>
        /// <param name="k1"></param>
        /// <param name="k2"></param>
        /// <returns>true pokud je k1 později nebo stejné jako k2,jinak false.</returns>
        public static bool operator >=(DatumEOW k1, DatumEOW k2)
        {
            return k1.DniDoKonceSveta <= k2.DniDoKonceSveta;
        }
    }
}
