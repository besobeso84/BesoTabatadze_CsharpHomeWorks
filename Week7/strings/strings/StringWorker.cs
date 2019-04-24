using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace strings
{
    class StringWorker
    {
        private string s = "This is a String";

        public StringWorker()
        { }

        public StringWorker(Label l)
        {
            l.Text = s;
        }

        public void getString(Label l)
        {
            l.Text = s;
        }

        public void getChar(Label l, int n=0)
        {
            l.Text = s[n-1].ToString();
        }

        public void getChar(Label l, int n = 0, int m = 0)
        {
            string rangeS="";
            for (int i = n-1; i < m; i++)
            {
                rangeS += s[i];
            }
            l.Text = rangeS;
        }
    }
}
