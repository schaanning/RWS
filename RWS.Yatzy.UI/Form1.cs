using System;
using System.Windows.Forms;
using RWS.Yatzy.Logik;

namespace RWS.Yatzy.UI
{
    public partial class Form1 : Form
    {
        Styrring s1 = new Styrring();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonKastTerninger_Click(object sender, EventArgs e)
        {
            s1.RystTerninger();

            int[] værdiAlleTerninger = new int[5];
            værdiAlleTerninger = s1.HvadViserTerningerne();

            labelTerning1.Text = værdiAlleTerninger[0].ToString();
            labelTerning2.Text = værdiAlleTerninger[1].ToString();
            labelTerning3.Text = værdiAlleTerninger[2].ToString();
            labelTerning4.Text = værdiAlleTerninger[3].ToString();
            labelTerning5.Text = værdiAlleTerninger[4].ToString();
        }

        private void buttonNytSpil_Click(object sender, EventArgs e)
        {
            s1.NytSpil();
        }

        private void knapHold1_Click(object sender, EventArgs e)
        {
            s1.HoldTerning(1);
            bool[] holdAlleTerninger = new bool[5];
            holdAlleTerninger = s1.ErTerningerHoldt();
            if (holdAlleTerninger[0])
            {
                knapHold1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            }
            else
            {
                knapHold1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
            }
        }

        private void knapHold2_Click(object sender, EventArgs e)
        {
            s1.HoldTerning(2);
            bool[] holdAlleTerninger = new bool[5];
            holdAlleTerninger = s1.ErTerningerHoldt();
            if (holdAlleTerninger[1])
            {
                knapHold2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            }
            else
            {
                knapHold2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
            }
        }

        private void knapHold3_Click(object sender, EventArgs e)
        {
            s1.HoldTerning(3);
            bool[] holdAlleTerninger = new bool[5];
            holdAlleTerninger = s1.ErTerningerHoldt();
            if (holdAlleTerninger[2])
            {
                knapHold3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            }
            else
            {
                knapHold3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
            }
        }

        private void knapHold4_Click(object sender, EventArgs e)
        {
            s1.HoldTerning(4);
            bool[] holdAlleTerninger = new bool[5];
            holdAlleTerninger = s1.ErTerningerHoldt();
            if (holdAlleTerninger[3])
            {
                knapHold4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            }
            else
            {
                knapHold4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
            }
        }

        private void knapHold5_Click(object sender, EventArgs e)
        {
            s1.HoldTerning(5);
            bool[] holdAlleTerninger = new bool[5];
            holdAlleTerninger = s1.ErTerningerHoldt();
            if (holdAlleTerninger[4])
            {
                knapHold5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            }
            else
            {
                knapHold5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
            }

        }
    }
}
