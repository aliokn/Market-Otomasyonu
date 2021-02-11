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
    public partial class StokEkle : Form
    {
        public StokEkle()
        {
            InitializeComponent();
        }
        Islm islm = new Islm();
        SqlConnection baglanti = new SqlConnection(Islm.adrs);
        private void kydt_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("Stok miktarı girin!");
            }
            else
            {
                islm.StokKayıt(textBox1.Text, Convert.ToDouble(textBox2.Text), Convert.ToDouble(stk.Text));
                textBox1.Clear();
                textBox2.Clear();
                Ad.Text = "";
                stk.Text = "";
                MessageBox.Show("Kayıt Başarılı", "Uyarı");
            }
        }
        private void Getir()
        {
            
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("Select Miktar,Ad from Tablo where id=@id", baglanti);
            ADADET sd = new ADADET();
            cmd.Parameters.AddWithValue("@id", textBox1.Text);
            using (SqlDataReader read = cmd.ExecuteReader())
            {
                read.Read();
                sd.Adet = Convert.ToDouble(read["Miktar"]);
                sd.Ad = read["Ad"].ToString();
            }
            Ad.Text = sd.Ad;
            stk.Text = sd.Adet.ToString();
            baglanti.Close();
        }

      

       

        private void StokEkle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Getir();
                e.Handled = e.SuppressKeyPress = true;
                textBox2.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
    public class ADADET
    {
        public double Adet { get; set; }
        public string Ad { get; set; }

    }
}
