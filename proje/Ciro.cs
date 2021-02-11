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
    public partial class Ciro : Form
    {
        public Ciro()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(Islm.adrs);
        private void Ciro_Load(object sender, EventArgs e)
        {
            
        }
     private void TGetir()
        {
            double ciro = 0;
            double kar = 0;
            DateTime dt = trhs.Value;

            SqlCommand cmd = new SqlCommand("Select SUM(Ciro) from Ciro where Tarih=@trh", baglanti);
            SqlCommand cmd1 = new SqlCommand("Select SUM(Kar) from Ciro where Tarih=@trh", baglanti);
            baglanti.Open();
            cmd.Parameters.AddWithValue("@trh", dt.Date);
            cmd1.Parameters.AddWithValue("@trh", dt.Date);
            if (cmd.ExecuteScalar() == DBNull.Value || cmd1.ExecuteScalar() == DBNull.Value)
            {
                MessageBox.Show("Geçerli bir tarih seçin!");
                
            }
            else
            {
                ciro = Convert.ToDouble(cmd.ExecuteScalar());
                kar = Convert.ToDouble(cmd1.ExecuteScalar());
                label3.Text = ciro.ToString("f2") + "₺";
                label4.Text = kar.ToString("f2") + "₺";
                
                label5.Text = dt.Date.ToShortDateString();
            }
            baglanti.Close();
        }

       

        private void trhs_ValueChanged(object sender, EventArgs e)
        {
            TGetir();
        }
    }
}
