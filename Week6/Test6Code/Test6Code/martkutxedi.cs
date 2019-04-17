using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test6Code
{
    class martkutxedi
    {
        private double sigane;

        public martkutxedi()
        {
            MessageBox.Show("Hello!!!");
        }

        public martkutxedi(double s)
        {
            this.sigane = s;
        }

        public void alertSigane()
        {
            MessageBox.Show(this.sigane.ToString());
        }
    }
}
