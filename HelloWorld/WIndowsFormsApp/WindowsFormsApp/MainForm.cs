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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public void otherFormClosed(object sender, FormClosedEventArgs e) {
            this.Show();
        }

        private void Toast_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World!!!");
        }

        private void OpenForm_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.FormClosed += new FormClosedEventHandler(otherFormClosed);
            form2.Show();
            this.Hide();

        }

        private void Title_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Don't Touch Me!!!");
        }

        private void SendRequest_Click(object sender, EventArgs e)
        {
            SendRequestFrom requestForm = new SendRequestFrom();
            requestForm.FormClosed += new FormClosedEventHandler(otherFormClosed);
            requestForm.Show();
            this.Hide();
        }
    }
}
