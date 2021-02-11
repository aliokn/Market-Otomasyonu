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
        SqlConnection baglanti = new SqlConnection(Islm.adrs);
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            try
            {
                if (textBox2.Text == "" || textBox1.Text == "")
                {
                    MessageBox.Show("ÜRÜN ADI VEYA BARKOD NUMARASI GİRİN");
                }
                else
                {
                   
                    SqlCommand kayit = new SqlCommand("update Tablo set ad=@ad,fiyat=@fiyat where id=@id", baglanti);
                    kayit.Parameters.AddWithValue("@id", textBox1.Text);
                    kayit.Parameters.AddWithValue("@ad", textBox2.Text);
                    kayit.Parameters.AddWithValue("@fiyat", Convert.ToDouble(textBox3.Text = textBox3.Text.Replace('.', ',')));
                    kayit.ExecuteNonQuery();
                    MessageBox.Show("Kayıt edildi!");
                    baglanti.Close();
                    dataGridView1.Rows.Clear();
                  
                }
            }
            catch(Exception hata) { MessageBox.Show(hata.ToString()); }
            finally
            {
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                baglanti.Close();
            }
        }

        private void Ara_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                SqlCommand komut = new SqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "Select * from Tablo where id = @id";
                komut.Parameters.AddWithValue("@id", textBox1.Text);
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
            if (textBox1.Text == "") {
                baglanti.Open();
                textBox2.CharacterCasing = CharacterCasing.Upper;
                dataGridView1.Rows.Clear();
                ara();
                baglanti.Close();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
          
             
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

        private void ara()
        {       
                
            SqlCommand kmt = new SqlCommand("Select * From Tablo where Ad=@ad", baglanti);
            kmt.Parameters.AddWithValue("@ad", textBox2.Text);
            SqlDataReader dr = kmt.ExecuteReader();
            
                while (dr.Read())
                {
                    dataGridView1.Rows.Add(dr["id"], dr["Ad"], dr["Fiyat"]);
                textBox1.Text = dr["id"].ToString();
                textBox2.Text = dr["Ad"].ToString();
                textBox3.Text = dr["Fiyat"].ToString();
            }
               
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Toplu_Fiyat_Değiştir tf = new Toplu_Fiyat_Değiştir();
            tf.Show();
        }

        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = e.SuppressKeyPress = true;
                Ara.PerformClick();
                textBox3.Focus();
               
            }
        }

    

        private void button8_Click(object sender, EventArgs e)
        {
            textBox3.Text += "8";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox3.Text += "2";
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            textBox3.Text += "3";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox3.Text += "6";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox3.Text += "5";
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            textBox3.Text += "4";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox3.Text += "7";

        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox3.Text += "1";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox3.Text += "9";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox3.Text += "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                textBox3.Text = textBox3.Text.Remove(textBox3.Text.Length - 1);
                textBox3.Focus();
            }
            catch { MessageBox.Show("Daha fazla silinemez");
                textBox3.Focus();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox3.Text += ",";
        }
    }
}
