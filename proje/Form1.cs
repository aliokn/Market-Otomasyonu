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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Karaoğulları";
        }

        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Pos;Integrated Security=True;");
        public static string kopya;
        private void Form1_Load(object sender, EventArgs e)
        {
            artma();

        }
        private string a;
        double b;
        double t1;
        int sayici = 0;
        int fisci;

        private void button2_Click(object sender, EventArgs e)
        {
           if (textBox1.Text == "") { MessageBox.Show("LÜTFEN BARKOD GİRİN", "HATA"); }
            else
            {
                dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;
                SqlCommand comm = new SqlCommand();
                comm.Connection = baglanti;
                comm.CommandText = "Select * from Tablo where id = '"+textBox1.Text+"'";
                baglanti.Open();
                SqlDataReader dr = comm.ExecuteReader();

                if (dr.HasRows)
                {
                    
                    
                    while (dr.Read())
                    {

                        double toplam = 0;

                        if (dataGridView1.Rows.Count > 0)
                        {   //satir no internetten alındı
                            int satirNo = -1;
                            double miktar = 1;
                            double fiyat;
                            
                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                if (Convert.ToString(row.Cells[0].Value) == textBox1.Text)
                                {
                                    //aynı fiyat safhası
                                    row.Cells[4].Value = Convert.ToDouble(row.Cells[2].Value) * Convert.ToDouble(row.Cells[3].Value);
                                    miktar = Convert.ToInt32(row.Cells[2].Value) + 1;
                                    satirNo = row.Cells[0].RowIndex;
                                    fiyat = Convert.ToDouble(row.Cells[3].Value);

                                    break;
                                }

                            }
                            if (satirNo < 0)
                            {
                                dataGridView1.Rows.Add(dr["id"], dr["Ad"], dr["Miktar"], dr["Fiyat"]);
                                foreach (DataGridViewRow row in dataGridView1.Rows)
                                {
                                    row.Cells[4].Value = Convert.ToDouble(row.Cells[2].Value) * Convert.ToDouble(row.Cells[3].Value);
                                }
                            }
                            else
                            {
                                dataGridView1.Rows[satirNo].Cells[2].Value = miktar;
                                dataGridView1.Rows[satirNo].Cells[4].Value = miktar * Convert.ToDouble(dataGridView1.Rows[satirNo].Cells[3].Value);
                            }
                        }



                        for (int i = 0; i < dataGridView1.Rows.Count; i++)
                        {
                            toplam += Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value);
                           
                        }
                        t1 = toplam;
                        label2.Text = t1.ToString();
                       
                        textBox1.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Ürün bulunamadı", "HATA");
                    Form2 f1 = new Form2();
                    kopya = textBox1.Text;
                    f1.ShowDialog();

                }
                
                baglanti.Close();
                
            }
            sayici++;
        }

    
       
        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f2 = new Form3();
           
            f2.ShowDialog();
            
        }
      

        private void button3_Click(object sender, EventArgs e)//YENİ SATIŞ
        {
            kayit();
            artma();
            label2.Text = "";
            dataGridView1.Rows.Clear();
            
            
        }
        
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = e.SuppressKeyPress = true;
                button2.PerformClick();
                textBox1.Clear();

            }
            if(e.KeyCode== Keys.F1)
            {
                Yenisatis.PerformClick();
            }
            
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
          
            
            textBox1.Text = "00000000001";
            button2.PerformClick();



        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "00000000002";
            button2.PerformClick();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "00000000003";
            button2.PerformClick();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = "00000000004";
            button2.PerformClick();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = "00000000005";
            button2.PerformClick();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = "00000000006";
            button2.PerformClick();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = "00000000007";
            button2.PerformClick();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = "00000000008";
            button2.PerformClick();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = "00000000009";
            button2.PerformClick();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = "00000000091";
            button2.PerformClick();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = "00000000092";
            button2.PerformClick();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = "00000000093";
            button2.PerformClick();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "00000000094";
            button2.PerformClick();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "00000000095";
            button2.PerformClick();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = "00000000096";
            button2.PerformClick();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text = "00000000097";
            button2.PerformClick();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = "00000000098";
            button2.PerformClick();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Text = "00000000099";
            button2.PerformClick();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (b == 0)
            {
                MessageBox.Show("Lütfen silinecek ürün seçin", "HATA");
            }
            else
            {
                try
                {
                    int rowIndex = dataGridView1.CurrentCell.RowIndex;


                    dataGridView1.Rows.RemoveAt(rowIndex);

                    t1 = t1 - b;
                    if (t1 < 0)
                    {
                        t1 = 0;
                    }
                    label2.Text = t1.ToString();
                    b = 0;
                }
                catch (Exception)
                {
                    MessageBox.Show("Seçili Ürün yok", "HATA");
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           a=dataGridView1.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
           b = Convert.ToDouble(a);
            
        }

        private void SonSatis_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }

        private void kayit()
        {
            
            SqlCommand cmd = new SqlCommand("insert into Fisci (BarkodNo,Ad,Fiyat,ToplamFiyat,FisNo,Miktar,Tarih) Values (@no,@ad,@fiyat,@tfiyat,@fis,@miktar,@tarih)",baglanti);
            
            baglanti.Open();
            
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@no", dataGridView1.Rows[i].Cells[0].Value);
                cmd.Parameters.AddWithValue("@ad", dataGridView1.Rows[i].Cells[1].Value);
                cmd.Parameters.AddWithValue("@fiyat", dataGridView1.Rows[i].Cells[3].Value);
                cmd.Parameters.AddWithValue("@tfiyat", dataGridView1.Rows[i].Cells[4].Value);
                cmd.Parameters.AddWithValue("@fis",fisci);
                cmd.Parameters.AddWithValue("@miktar", dataGridView1.Rows[i].Cells[2].Value);
                cmd.Parameters.AddWithValue("@tarih",DateTime.Now);
                cmd.ExecuteNonQuery();
                
            }
            
            baglanti.Close();
           
            
 
        }
        private void artma()
        {
            baglanti.Open();
            string query = "select max(FisNo) as pa from Fisci";
            SqlCommand cmd = new SqlCommand(query, baglanti);
            cmd.CommandType = CommandType.Text;
            
                string a = cmd.ExecuteScalar().ToString();
            if (a == "")
            {
                fisci = 1;
            }
            else
            {
                fisci = Convert.ToInt32(a);
                fisci = fisci + 1;
            }

            
            baglanti.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
            /*kayit();
            artma();*/
            
        }
        
    }
}
