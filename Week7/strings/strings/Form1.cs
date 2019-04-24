using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace strings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AutoSize = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringWorker st = new StringWorker(label1);
            //st.getString(label1);
            st.getChar(label2, 2, 4);
        }
    }
}
