using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab521
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] nishnebi = {100, 89, 67, 23, 45, 56, 89, 65, 98, 81};
            studenti studentObject = new studenti();
            label1.Text = studentObject.sashualoAritmetikuli(nishnebi).ToString();
        }
    }
}
