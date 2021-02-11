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
    public partial class Toplu_Fiyat_Değiştir : Form
    {
        public Toplu_Fiyat_Değiştir()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(Islm.adrs);

        private void ara()
        {
            SqlCommand cmd = new SqlCommand("Select ID,Ad,Fiyat from Tablo where Ad like '%'+@ad+'%'", baglanti);
            baglanti.Open();
            cmd.Parameters.AddWithValue("@ad", textBox2.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            
           
            
             
                while (dr.Read())
                {

                dataGridView1.Rows.Add(Scm.Selected=false,dr["ID"], dr["Ad"], dr["Fiyat"]);
                   
                }
            
            baglanti.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            ara();
        }

       private void degistir()
            {
            SqlCommand cmd = new SqlCommand("Update Tablo set fiyat=@fiyat where ID=@id", baglanti);
            baglanti.Open();
            for (int i = 0; i < dataGridView2.RowCount-1; i++)
            {
                cmd.Parameters.AddWithValue("@id", dataGridView2.Rows[i].Cells[0].Value);
                cmd.Parameters.AddWithValue("@fiyat", Convert.ToDouble(textBox1.Text = textBox1.Text.Replace('.', ',')));
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            baglanti.Close();





            }

        DataTable dt = new DataTable();
        private void button1_Click(object sender, EventArgs e)
        {
            
            
            dt.Clear();
            




            foreach (DataGridViewRow row in dataGridView1.Rows)
             {




               


                bool sec = Convert.ToBoolean(row.Cells[0].Value);
                if (sec) { dt.Rows.Add(row.Cells[1].Value, row.Cells[2].Value, row.Cells[3].Value); }










            }
            dataGridView2.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            degistir();
            MessageBox.Show("Fiyatlar Değiştirildi");
            dt.Clear();

            dataGridView1.Rows.Clear();
            textBox2.Clear();
            textBox1.Clear();
            
        }

        private void Toplu_Fiyat_Değiştir_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("Barkod Numarası");
            dt.Columns.Add("Ürün Adı");
            dt.Columns.Add("Eski Fiyatı");
        }
    }
}
