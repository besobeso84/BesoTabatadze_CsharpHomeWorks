using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test6Code
{
    class tvitmfrinavi
    {
        private double bakistevadoba;
        private double mandzili;

        public tvitmfrinavi()
        {

        }

        public tvitmfrinavi(double b, double m)
        {
            this.bakistevadoba = b;
            this.mandzili = m;
        }

        public void gamotana(Label l1, Label l2)
        {
            l1.Text = bakistevadoba.ToString();
            l2.Text = mandzili.ToString();
        }
    }
}
