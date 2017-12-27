using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Dapper;
using System.Linq;

namespace WindowsFormsApp.SQLServer
{
    public partial class SQLServerForm : Form
    {
        IDbConnection connection = new SqlConnection("Server=tcp:192.168.1.186,1433;" +
                      "Database=Halin_Sample;User ID=sa;" +
                      "Password=HalinDev;Encrypt=True;" +
                      "TrustServerCertificate=True;Connection Timeout=30;");

        public SQLServerForm()
        {
            InitializeComponent();
        }


        private async void Connect(object sender, EventArgs e)
        {
            var ip = ipTextBox.Text;
            var port = portTextBox.Text;

            var state = await Task<ConnectionState>.Run(() =>
            {
                connection.Open();
                return ConnectState.Connected;
            });



            StateLabel.Text = state.ToString();
            controlPanel.Enabled = state == ConnectState.Connected;

        }


        private void pkTextBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(pkTextBox.Text, "[^0-9]"))
            {
                pkTextBox.Text = pkTextBox.Text.Remove(pkTextBox.Text.Length - 1);
            }
        }

        private void Insert(object sender, EventArgs e)
        {
            string query = "INSERT INTO Sample_Table(Sample_PK,Sample_Text) VALUES (@Sample_PK,@Sample_Text)";
            try
            {
                var model = GetModelFromInput();
                connection.Execute(query, model);
                SetMessageLabel(true, model, null);
            }
            catch (SqlException exception)
            {
                SetMessageLabel(false, null, exception.Message);
            }
        }
        private void Update(object sender, EventArgs e)
        {
            string query = "Update Sample_Table SET Sample_PK=@Sample_PK,Sample_Text=@Sample_Text WHERE Sample_PK=@Sample_PK";
            try
            {
                var model = GetModelFromInput();
                connection.Execute(query, model);
                SetMessageLabel(true, model, null);
            }
            catch (SqlException exception)
            {
                SetMessageLabel(false, null, exception.Message);
            };
        }

        private void Delete(object sender, EventArgs e)
        {
            string query = "DELETE FROM Sample_Table WHERE Sample_PK=@Sample_PK";
            try
            {
                var model = GetModelFromInput();
                connection.Execute(query, model);
                SetMessageLabel(true, null, null);
            }
            catch (SqlException exception)
            {
                SetMessageLabel(false, null, exception.Message);
            }
        }

        private void Query(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Sample_Table WHERE Sample_PK=@Sample_PK";

            try
            {
                var model = connection.Query<Sample_Table>(query, new { Sample_PK = 0, Sample_Text = "error" }).SingleOrDefault();
                SetMessageLabel(true, model, null);
            }
            catch (SqlException exception)
            {
                SetMessageLabel(false, null, exception.Message);
            }
        }



        private Sample_Table GetModelFromInput()
        {

            return new Sample_Table()
            {
                Sample_PK = Convert.ToInt32(pkTextBox.Text),
                Sample_Text = textTextBox.Text
            };


        }

        private void SetMessageLabel(bool isSucceed, Sample_Table item, string message)
        {
            if (isSucceed)
            {
                if (item != null)
                {
                    resultLabel.Text = "操作成功,PK:" + item.Sample_PK + "TEXT:" + item.Sample_Text;
                }
                else {
                    resultLabel.Text = "操作成功";
                }
                
            }
            else
            {
                resultLabel.Text = "操作失败:" + message;
            }
        }


    }

    enum ConnectState
    {
        Connected,
        DisConnected
    }
}
