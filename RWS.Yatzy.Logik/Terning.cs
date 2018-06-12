using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RWS.Yatzy.Logik
{
    public class Terning
    {
        private static Random rnd = new Random();
        private int _værdi;
        private bool _hold;

        public Terning()
        {
            this._hold = false;
            Ryst();
        }

        public int Værdi
        {
            get { return _værdi; }
            set { _værdi = value; }
        }

        public bool Hold
        {
            get { return _hold; }
            set { _hold = value; }
        }

        public void Ryst()
        {
            if (this.Hold)
            {
            }
            else
            {
                this._værdi = rnd.Next(1, 6 + 1);
                this._hold = false;
            }
        }
    }
}
