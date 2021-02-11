using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Data.SqlClient;
namespace proje
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            
            InitializeComponent();
            this.Text = "Yeni Ürün";
            comboBox1.Items.Add("Tekel");
            comboBox1.Items.Add("Manav");
            comboBox1.Items.Add("Temel Ürün");

        }
        
        SqlConnection baglanti = new SqlConnection(Islm.adrs);
        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {


            textBox2.Text = textBox2.Text.ToUpper(new CultureInfo("tr-TR", false));
            textBox2.SelectionStart = textBox2.Text.Length;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
       
       

        private void button1_Click(object sender, EventArgs e)
        {

            
            SqlCommand komut = new SqlCommand("insert into Tablo (id,ad,fiyat,miktar,sinif) values(@id,@Ad,@Fiyat,@miktar,@tr)", baglanti);
            if (textBox3.Text == ""||textBox1.Text==""||textBox2.Text=="" || comboBox1.Text=="")
            {
                MessageBox.Show("LÜTFEN GEREKLİ BİLGİLERİ GİRİN");
            }
            else{
                baglanti.Open();
            komut.Parameters.AddWithValue("@id", textBox1.Text);
            komut.Parameters.AddWithValue("@Ad", textBox2.Text);
            komut.Parameters.AddWithValue("@Fiyat",Convert.ToDouble(textBox3.Text=textBox3.Text.Replace('.',',')));
            komut.Parameters.AddWithValue("@miktar", textBox4.Text);
            komut.Parameters.AddWithValue("@tr", comboBox1.Text);
            
                komut.ExecuteNonQuery();
                MessageBox.Show("Kaydedildi!");
                baglanti.Close();
                this.Close();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
                
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void Form2_Shown(object sender, EventArgs e)
        {
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text = Form1.kopya;
            this.ActiveControl = textBox2;

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
