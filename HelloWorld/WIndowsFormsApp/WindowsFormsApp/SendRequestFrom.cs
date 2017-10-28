using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;

namespace WindowsFormsApp
{
    public partial class SendRequestFrom : Form
    {

        private static readonly HttpClient client = new HttpClient();

        public SendRequestFrom()
        {
            InitializeComponent();
        }

        private async void Send_ClickAsync(object sender, EventArgs e)
        {
            String link = TextBox.Text;
            try
            {
                var responseString = await client.GetStringAsync(link);
                MessageBox.Show(responseString);
            }
            catch (Exception error){
                MessageBox.Show(error.Message);

            }
        }
    }
}
