using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test6Code
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tvitmfrinavi tvit = new tvitmfrinavi(525, 300);
            tvit.gamotana(label1, label2);
            tvitmfrinavi tvit1 = new tvitmfrinavi();
        }
    }
}
