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

namespace proje
{
    public partial class Sayim : Form
    {
        SqlConnection bgl = new SqlConnection(Islm.adrs);
        public Sayim()
        {
            InitializeComponent();
        }

        private void Sayim_Load(object sender, EventArgs e)
        {
            Getir();
        }
        private void Getir()
        {
            bgl.Open();
            SqlCommand cmd = new SqlCommand("Select Ad,Miktar from Tablo where Miktar <=5 Order By Miktar ASC", bgl);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr["Ad"], dr["Miktar"]);
            }
            bgl.Close();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                if (Convert.ToDouble(row.Cells[1].Value) < 5)
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.Wheat;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
  
}
