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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            this.Text = "Ürün Arama";
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Pos;Integrated Security=True;");
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox1.Text == "")
            {
                MessageBox.Show("ÜRÜN ADI VEYA BARKOD NUMARASI GİRİN");
            }
            else
            {
                baglanti.Open();
                SqlCommand kayit = new SqlCommand("update Tablo set ad=@ad,fiyat=@fiyat where id=@id", baglanti);
                kayit.Parameters.AddWithValue("@id", textBox1.Text);
                kayit.Parameters.AddWithValue("@ad", textBox2.Text);
                kayit.Parameters.AddWithValue("@fiyat", Convert.ToDouble(textBox3.Text = textBox3.Text.Replace('.', ',')));
                kayit.ExecuteNonQuery();
                MessageBox.Show("Kayıt edildi!");
                baglanti.Close();
                dataGridView1.Rows.Clear();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
        }

        private void Ara_Click(object sender, EventArgs e)
        {   
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText="Select * from Tablo where id ='"+textBox1.Text+"'";
            baglanti.Open();
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    dataGridView1.Rows.Add(dr["id"], dr["Ad"], dr["Fiyat"]);
                    textBox1.Text = dr["id"].ToString();
                    textBox2.Text = dr["Ad"].ToString();
                    textBox3.Text = dr["Fiyat"].ToString();
                }
            }
            else
            {
                MessageBox.Show("Böyle bir ürün yok!");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                dataGridView1.Rows.Clear();
            }
            baglanti.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.CharacterCasing = CharacterCasing.Upper;
            if (textBox1.Text == "")
            {
                baglanti.Open();
                SqlCommand kmt = new SqlCommand("Select * From Tablo where Ad='" + textBox2.Text + "'",baglanti);
                
                SqlDataReader dr = kmt.ExecuteReader();
                while (dr.Read())
                {
                    dataGridView1.Rows.Add(dr["id"], dr["Ad"], dr["Fiyat"]);
                    textBox1.Text = dr["id"].ToString();
                    textBox2.Text = dr["Ad"].ToString();
                    textBox3.Text = dr["Fiyat"].ToString();
                }
                baglanti.Close();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            dataGridView1.Rows.Clear();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
    }
}
