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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            EskiGetir();
            getir();
            Topla();
            this.Text = "Son Satış";
            
        }
        SqlConnection baglanti = new SqlConnection(Islm.adrs);
        double toplam=0;
        int sayi;
        int max;
        string query = "select max(FisNo) as pa from Fisci";
        private void getir()
        {   
            SqlCommand cmd = new SqlCommand("Select BarkodNo,Ad,Miktar,Fiyat,Tarih,ToplamFiyat,FisNo from Fisci where FisNo=(Select max(FisNo) From Fisci)",baglanti);
            baglanti.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr["BarkodNo"], dr["Ad"], dr["Miktar"], dr["Fiyat"], dr["ToplamFiyat"]);
                Tarihi.Text = dr["Tarih"].ToString();
                Fis.Text = dr["FisNo"].ToString();
            }
            baglanti.Close();
           
        }


        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Tarih_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
      


        private void Sonra_Click(object sender, EventArgs e)
        {
            if (sayi == max)
            {
                MessageBox.Show("Son Satışınız görüntüleniyor");
            }
            else
            sayi++;
            Yap();

        }
        private void Topla()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                toplam += Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value);

            }
            Tfiyat.Text = toplam.ToString();
        }
        private void EskiGetir()
        {
            baglanti.Open();
            SqlCommand cmd1 = new SqlCommand(query, baglanti)
            {
                CommandType = CommandType.Text
            };

            string a = cmd1.ExecuteScalar().ToString();
            sayi = Convert.ToInt32(a);
            max = Convert.ToInt32(a);
            baglanti.Close();
        }
        private void Once_Click(object sender, EventArgs e)
        {
          
            sayi--; Yap();
        }

        
        private void Yap()
        {
            toplam = 0;
            if (sayi == 0)
            {
                MessageBox.Show("BAŞKA KAYIT YOK");
                sayi = 1;
            }
            dataGridView1.Rows.Clear();
            Tfiyat.Text = "";
            baglanti.Open();


            SqlCommand kmt = new SqlCommand("Select BarkodNo,Ad,Miktar,Fiyat,Tarih,ToplamFiyat,FisNo from Fisci where FisNo='" + sayi + "'", baglanti);
            SqlDataReader dr = kmt.ExecuteReader();
            while (dr.Read())
            {

                dataGridView1.Rows.Add(dr["BarkodNo"], dr["Ad"], dr["Miktar"], dr["Fiyat"], dr["ToplamFiyat"]);
                Tarihi.Text = dr["Tarih"].ToString();
                Fis.Text = dr["FisNo"].ToString();

            }
            baglanti.Close();
            Topla();
        }

        private void SeciliGetir()
        {
            dataGridView1.Rows.Clear();
            toplam = 0;    
            baglanti.Open();


            SqlCommand kmt = new SqlCommand("Select BarkodNo,Ad,Miktar,Fiyat,Tarih,ToplamFiyat,FisNo from Fisci where FisNo=@ad", baglanti);
            kmt.Parameters.AddWithValue("@ad", Convert.ToInt32(textBox1.Text));
            SqlDataReader dr = kmt.ExecuteReader();
            while (dr.Read())
            {

                dataGridView1.Rows.Add(dr["BarkodNo"], dr["Ad"], dr["Miktar"], dr["Fiyat"], dr["ToplamFiyat"]);
                Tarihi.Text = dr["Tarih"].ToString();
                Fis.Text = dr["FisNo"].ToString();

            }
            
            baglanti.Close();
            Topla();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SeciliGetir();
        }
    }
}
