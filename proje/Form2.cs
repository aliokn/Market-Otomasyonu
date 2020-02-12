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
    public partial class Form2 : Form
    {
        public Form2()
        {
            
            InitializeComponent();
            this.Text = "Yeni Ürün";
           

        }
        
        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Pos;Integrated Security=True;");
        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.CharacterCasing = CharacterCasing.Upper;
            textBox1.Text = Form1.kopya;
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
       
       

        private void button1_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Tablo (id,ad,fiyat,miktar) values(@id,@Ad,@Fiyat,1)", baglanti);
            if (textBox3.Text == "")
            {
                MessageBox.Show("LÜTFEN FİYAT GİRİN");
            }
            else{
            komut.Parameters.AddWithValue("@id", textBox1.Text);
            komut.Parameters.AddWithValue("@Ad", textBox2.Text);
            komut.Parameters.AddWithValue("@Fiyat",Convert.ToDouble(textBox3.Text=textBox3.Text.Replace('.',',')));

            
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
            textBox2.Focus();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
