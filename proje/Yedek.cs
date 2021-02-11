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
//using Microsoft.SqlServer.Management.Smo;
//using Microsoft.SqlServer.Management.Common;



namespace proje
{
    public partial class Yedek : Form
    {
        public Yedek()
        {
            InitializeComponent();
        }
        string Secili_Klsaor_Yolu = "";
        SqlConnection baglanti = new SqlConnection(Islm.adrs);
        string a;
        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox2.Text == "") { MessageBox.Show("Veritabanı adı giriniz!"); }
            else
            {
                FolderBrowserDialog Klasor = new FolderBrowserDialog();
                if (Klasor.ShowDialog() == DialogResult.OK)
                {
                    Secili_Klsaor_Yolu = Klasor.SelectedPath;
                    if (textBox2.Text != "")

                        textBox1.Text = Secili_Klsaor_Yolu + "\\" + textBox2.Text + ".bak";
                    a = textBox1.Text;
                    SqlCommand cmd = new SqlCommand("backup database Pos to disk=@ad", baglanti);
                    cmd.Parameters.AddWithValue("@ad", a);
                    baglanti.Open();
                    cmd.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Kayıt Başarılı!");
                    textBox1.Clear();
                    textBox2.Clear();

                    /*
                     Windows çalıştır menüsüne services.msc yazarak hizmetler menüsüne gelinir. 
                     Burada "SQL Server (SQLEXPRESS)"  hizmetinin içerisine gelinerek Log On kısmına gelinir 
                     ve NT AUTHORITY\NetworkService olan oturum açma şekli Local System Account olarak değiştirilir
                     */
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Hiçbir Klasör Seçilmedi");
                    textBox2.Clear();
                }
            }
        }

        private void Yedek_Load(object sender, EventArgs e)
        {

        }
    }
}
