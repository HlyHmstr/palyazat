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
    public partial class Form1 : Form
    {
        public string connectionString { get; set; }
        public Form1()
        {
            connectionString = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = palyazatok";
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvFill();
        }

        private void btn_kilep_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dgvFill() 
        {
            using (var c = new SqlConnection(connectionString))
            {
                dgvMain.Rows.Clear();
                c.Open();
                var r = new SqlCommand("Select palyazat.id, (palyazat.tervezetA + palyazat.tervezetC), count(szamla.szamlaszam),sum(szamla.ertek) " +
                    "from koltsegtipus,palyazat,szamla " +
                    "where palyazat.id = szamla.palyazatId " +
                    "and szamla.koltsegtipusId = koltsegtipus.id " +
                    "group by palyazat.id,(palyazat.tervezetA + palyazat.tervezetC) " +
                    "order by palyazat.id ASC", c).ExecuteReader();
                while (r.Read())
                {
                    dgvMain.Rows.Add(r[0], r[1] + "  Ft", r[2]+ " db", r[3] + "Ft");
                }
            }
        }

        private void btn_ujPalyazat_Click(object sender, EventArgs e)
        {
            var r = new ujPalyRog(connectionString);
            r.ShowDialog();
        }
    }
}
