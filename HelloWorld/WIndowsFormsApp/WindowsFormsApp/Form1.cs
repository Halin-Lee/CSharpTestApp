using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void YesButton_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.FormClosed += new FormClosedEventHandler(Form2Closed);
            form2.Show();
            this.Hide();
        }

        public void Form2Closed(object sender, FormClosedEventArgs e) {
            this.Show();
        }

        private void NoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Never Say No!!!");
        }
    }
}
