using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace palyazat
{
    public partial class ujPalyRog : Form
    {
        public string ConnectionString { get; set; }
        public ujPalyRog(string connectionString)
        {
            ConnectionString = connectionString;
            InitializeComponent();
        }

        private void ujPalyRog_Load(object sender, EventArgs e)
        {
            id_tb();
        }
        private void id_tb()
        {
            using (var c = new SqlConnection(ConnectionString))
            {
                c.Open();
                var r = new SqlCommand("Select Top 1 id " +
                    "from palyazat " +
                    "order by id DESC;", c).ExecuteReader();
                r.Read();
                tb_id.Text = $"{r.GetInt32(0) +1}";
                tb_id.Text = $"{r.GetInt32(0) +1}";
            }
        }

        private void btn_ujPaly_Click(object sender, EventArgs e)
        {
            using (var c = new SqlConnection(ConnectionString))
            {
                c.Open();
                string id = tb_id.Text;
                string aKat = tb_aKat.Text;
                string cKat = tb_cKat.Text;
                try
                {
                    string errorMessage = "";
                    if (string.IsNullOrWhiteSpace(aKat))
                        errorMessage += "Egyik mező sem maradhat üresen!\n";
                    if (string.IsNullOrWhiteSpace(cKat))
                        errorMessage += "Egyik mező sem maradhat üresen!\n";
                    int a;
                    if (!int.TryParse(aKat, out a))
                        errorMessage += "A megadott érték nem szám!\n";
                    int d;
                    if (!int.TryParse(cKat, out d))
                        errorMessage += "A megadott érték nem szám!\n";
                    int i;
                    if (!int.TryParse(id, out i))
                        errorMessage += "A megadott érték nem szám!\n";
                    if (a <= 0 || d <= 0)
                        errorMessage += "Az ár nem lehet 0 vagy negatív!\n";
                    if (!string.IsNullOrEmpty(errorMessage))
                        throw new Exception(errorMessage);
                    new SqlCommand("Insert into palyazat values " +
                        $"'{"" + id}','{aKat}','{cKat}'",c).ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                MessageBox.Show("új termék sikeresen rögzítve!");
                Close();
            }

        }
    }
}
