using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RWS.Yatzy.Logik
{
    public class Styrring
    {
        Terning t1 = new Terning();
        Terning t2 = new Terning();
        Terning t3 = new Terning();
        Terning t4 = new Terning();
        Terning t5 = new Terning();

        Terning[] terningArray = new Terning[5];
        
        public Styrring()
        {
            NytSpil();
        }

        public void NytSpil()
        {
            terningArray[0] = t1;
            terningArray[1] = t2;
            terningArray[2] = t3;
            terningArray[3] = t4;
            terningArray[4] = t5;

            for (int i = 0; i < terningArray.Length; i++)
            {
                terningArray[i].Ryst();
            }
        }

        public int[] HvadViserTerningerne()
        {
            int[] terningeVærdier = new int[5];
            for (int i = 0; i < terningArray.Length; i++)
            {
                terningeVærdier[i] = terningArray[i].Værdi;
            }
            return terningeVærdier;
        }

        public bool[] ErTerningerHoldt()
        {
            bool[] terningeVærdier = new bool[5];
            for (int i = 0; i < terningArray.Length; i++)
            {
                terningeVærdier[i] = terningArray[i].Hold;
            }
            return terningeVærdier;
        }

        public void HoldTerning(int terningNummer)
        {
            switch (terningNummer)
            {
                case 1:
                    if (t1.Hold)
                    {
                        t1.Hold = false;
                    }
                    else
                    {
                        t1.Hold = true;
                    }
                    break;
                case 2:
                    if (t2.Hold)
                    {
                        t2.Hold = false;
                    }
                    else
                    {
                        t2.Hold = true;
                    }
                    break;
                case 3:
                    if (t3.Hold)
                    {
                        t3.Hold = false;
                    }
                    else
                    {
                        t3.Hold = true;
                    }
                    break;
                case 4:
                    if (t4.Hold)
                    {
                        t4.Hold = false;
                    }
                    else
                    {
                        t4.Hold = true;
                    }
                    break;
                case 5:
                    if (t5.Hold)
                    {
                        t5.Hold = false;
                    }
                    else
                    {
                        t5.Hold = true;
                    }
                    break;
                default:
                    break;
            }
        }

        public void RystTerninger()
        {
            for (int i = 0; i < terningArray.Length; i++)
            {
                terningArray[i].Ryst();
            }
        }

    }
}
