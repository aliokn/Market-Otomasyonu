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
using System.Drawing.Drawing2D;
using System.Text.RegularExpressions;

namespace proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Karaoğulları";
            
        }

        SqlConnection baglanti = new SqlConnection(Islm.adrs);

        public static string kopya;
        private void Form1_Load(object sender, EventArgs e)
        {
            artma();
            panel2.Visible = false;
            panel3.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            textBox1.Focus();

        }
       
        private string a;
        double b;
        double t1;
        int fisci;
        object mdon;

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text == "") { MessageBox.Show("LÜTFEN BARKOD GİRİN", "HATA"); }
            else
            {
                dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;
                SqlCommand comm = new SqlCommand
                {
                    Connection = baglanti,
                    CommandText = "Select * from Tablo where id = @id"
                };
                baglanti.Open();
                comm.Parameters.AddWithValue("@id", textBox1.Text);
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
                                dataGridView1.Rows.Add(dr["id"], dr["Ad"], 1, dr["Fiyat"]);

                                
                                try
                                {
                                    foreach (DataGridViewRow row in dataGridView1.Rows)
                                    {
                                        row.Cells[4].Value = Convert.ToDouble(row.Cells[2].Value) * Convert.ToDouble(row.Cells[3].Value);
                                    }
                                }
                                catch {  }
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
                        label2.Text = t1.ToString("F2");
                       
                       
                    }
                   
                }
                else
                {
                    MessageBox.Show("Ürün bulunamadı", "HATA");
                    Form2 f1 = new Form2();
                    kopya = textBox1.Text;
                    f1.ShowDialog();
                    textBox1.Focus();


                }
                miktarci();
                baglanti.Close();
                label9.Text = StokGetir();
                textBox1.Clear();
            }
            
        }

    
       
        
      

        private void button3_Click(object sender, EventArgs e)//YENİ SATIŞ
        {//YENİ SATIŞ
            if (label2.Text == "")
            {
                MessageBox.Show("Lütfen önce satış yapın");
            }
            else
            {
                label9.Text = "";
                kayit();
                kar();
                artma();
                stokcu();
                label2.Text = "";
                dataGridView1.Rows.Clear();
                t1 = 0;
                textBox1.Focus();
                s = 0;
                miktarci();
            }
            
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

            textBox1.Focus();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "00000000002";
            button2.PerformClick();
            textBox1.Focus();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "00000000003";
            button2.PerformClick();
            textBox1.Focus();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = "00000000004";
            button2.PerformClick();
            textBox1.Focus();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = "00000000005";
            button2.PerformClick();
            textBox1.Focus();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = "00000000006";
            button2.PerformClick();
            textBox1.Focus();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = "00000000007";
            button2.PerformClick();
            textBox1.Focus();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0000000432";
            button2.PerformClick();
            textBox1.Focus();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = "00000000009";
            button2.PerformClick();
            textBox1.Focus();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = "00000000091";
            button2.PerformClick();
            textBox1.Focus();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = "00000000092";
            button2.PerformClick();
            textBox1.Focus();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = "00000000093";
            button2.PerformClick();
            textBox1.Focus();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "00000000094";
            button2.PerformClick();
            textBox1.Focus();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "00000000095";
            button2.PerformClick();
            textBox1.Focus();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = "00000000096";
            button2.PerformClick();
            textBox1.Focus();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text = "00000000097";
            button2.PerformClick();
            textBox1.Focus();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = "00000000098";
            button2.PerformClick();
            textBox1.Focus();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Text = "00000000099";
            button2.PerformClick();
            textBox1.Focus();
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

                    //ÜRÜN SİLME 
                    
                    dataGridView1.Rows.RemoveAt(rowIndex);

                    t1 = t1 - b;
                    if (t1 < 0)
                    {
                        t1 = 0;
                    }
                    label2.Text = t1.ToString("F2");
                    b = 0;
                    textBox1.Focus();
                }
                catch (Exception)
                {
                    MessageBox.Show("Seçili Ürün yok", "HATA");
                }
                miktarci();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)    
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    a = dataGridView1.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                    b = Convert.ToDouble(a);
                }
                if (dataGridView1.CurrentCell.ColumnIndex.Equals(3) && e.RowIndex != -1 && dataGridView1.CurrentRow.Cells[0].Value != null)
                {
                    Manuel_Fiyat.eski = Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
                    Manuel_Fiyat mf = new Manuel_Fiyat();
                    mf.ShowDialog();
                    dataGridView1.Rows[e.RowIndex].Cells[3].Value = Manuel_Fiyat.ftt;
                    dataGridView1.Rows[e.RowIndex].Cells[4].Value = Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells[2].Value) * Manuel_Fiyat.ftt;
                    dataGridView1.RefreshEdit();
                    yenile();
                    textBox1.Focus();
                }
                if (dataGridView1.CurrentCell.ColumnIndex.Equals(2) && e.RowIndex != -1 && dataGridView1.CurrentRow.Cells[0].Value.ToString() != "")
                {
                    ManuelMiktar mm = new ManuelMiktar(); mm.ShowDialog();
                    dataGridView1.Rows[e.RowIndex].Cells[2].Value = ManuelMiktar.mmi;
                    dataGridView1.Rows[e.RowIndex].Cells[4].Value = Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells[3].Value) * ManuelMiktar.mmi;
                    dataGridView1.RefreshEdit();
                    yenile();
                    textBox1.Focus();
                }
                miktarci();
            }
            catch { }
            
            //FİYAT DEĞİŞTİRME
        }
        double fr;
       
        private void yenile()
        {
            

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                fr += Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value);

            }
            t1 = fr;
            label2.Text = t1.ToString("F2");
            b = 0;
            fr = 0;
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
                cmd.Parameters.AddWithValue("@fiyat", Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value));
                cmd.Parameters.AddWithValue("@tfiyat", Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value));
                cmd.Parameters.AddWithValue("@fis",fisci);
                cmd.Parameters.AddWithValue("@miktar", Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value));
                cmd.Parameters.AddWithValue("@tarih",DateTime.Now);
                cmd.ExecuteNonQuery();
                
            }
            
            baglanti.Close();
           
            
 
        }

        private void kar()
        {
            double kar=0;
            double ciro=0;
            int fis;
            string a;
            SqlCommand fs = new SqlCommand("select max(Fis) as mx from Ciro", baglanti);
            SqlCommand cmd = new SqlCommand("insert into Ciro (Ciro,Kar,Tarih,Fis) Values (@ciro,@kar,@tarih,@fis)", baglanti);
            SqlCommand cmd1 = new SqlCommand("Select Sinif from Tablo where id=@id", baglanti);
            baglanti.Open();
            if (fs.ExecuteScalar() == DBNull.Value)
            {
                fis = 1;
            }
            else
            {
                fis = Convert.ToInt32(fs.ExecuteScalar());
                fis++;
            }
             
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    cmd.Parameters.Clear();
                    cmd1.Parameters.Clear();
                    cmd1.Parameters.AddWithValue("@id", dataGridView1.Rows[i].Cells[0].Value);
                    a = cmd1.ExecuteScalar().ToString();
                    if (a == "Tekel")
                    {
                        ciro = Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value);
                        kar = (Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value) * 5.5) / 100;
                    }
                    if (a == "Manav")
                    {
                        ciro = Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value);
                        kar = (Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value) * 50) / 100;
                    }
                    if (a == "Temel Ürün")
                    {
                        ciro = Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value);
                        kar = (Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value) * 25) / 100;

                    }
                    cmd.Parameters.AddWithValue("@ciro", ciro);
                    cmd.Parameters.AddWithValue("@kar", kar);
                    cmd.Parameters.AddWithValue("@tarih", DateTime.Today);
                    cmd.Parameters.AddWithValue("@fis", fis);
                    cmd.ExecuteNonQuery();
                }
                
            
            baglanti.Close();


        }
        private void artma()
        {
            baglanti.Open();
            string query = "select max(FisNo) from Fisci";
            SqlCommand cmd = new SqlCommand(query, baglanti)
            {
                CommandType = CommandType.Text
            };

            
            if (cmd.ExecuteScalar() == DBNull.Value)
            {
                fisci = 1;
            }
            else
            {
                fisci = Convert.ToInt32(cmd.ExecuteScalar());
                fisci++;
            }

            
            baglanti.Close();
        }
        int s;
        private void miktarci() {
            s = 0;
            for 
                (int i = 0; i < dataGridView1.Rows.Count-1; i++) {
                s += Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
            }

            label3.Text = s.ToString();

        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "00000000111";
            button2.PerformClick();
            textBox1.Focus();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = false;
          
        }

        private void button22_Click_1(object sender, EventArgs e)
        {
            Yedek y1 = new Yedek();
            y1.ShowDialog();
        }

       

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult snc = MessageBox.Show("Programı kapatmadan önce dosyaları yedeklemek ister misiniz?", "Yedekleme", MessageBoxButtons.YesNo);
            if (snc == DialogResult.Yes)
            {
                Yedek y1 = new Yedek();
                y1.ShowDialog();
            }
            if (snc == DialogResult.No)
            { this.Hide(); }
        }

      

        private void button23_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
        private void stokcu()
        {
         
            int b = 0;
            SqlCommand kmt = new SqlCommand("Select Miktar from Tablo where ID=@id1", baglanti);
            SqlCommand cmd = new SqlCommand("Update Tablo set Miktar=@mktr where ID=@id", baglanti);
            baglanti.Open();
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                kmt.Parameters.Clear();
                cmd.Parameters.Clear();
                kmt.Parameters.AddWithValue("@id1", dataGridView1.Rows[i].Cells[0].Value);
                b = Convert.ToInt32(kmt.ExecuteScalar());
                cmd.Parameters.AddWithValue("@id", dataGridView1.Rows[i].Cells[0].Value);
                cmd.Parameters.AddWithValue("@mktr", (b - Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value)));
                cmd.ExecuteNonQuery();

            }
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu f1 = new Menu();
            f1.ShowDialog();
            textBox1.Focus();
        }

        private void button22_Click_2(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel1.Visible = false;
            textBox1.Focus();
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel1.Visible = true;
            textBox1.Focus();
        }

   

      

        private void button75_Click(object sender, EventArgs e)
        {
            textBox1.Text = "00000000013";
            button2.PerformClick();
            textBox1.Focus();
        }

        private void button61_Click(object sender, EventArgs e)
        {
            textBox1.Text = "00000000019";
            button2.PerformClick();
            textBox1.Focus();
        }

        private void button66_Click(object sender, EventArgs e)
        {
            textBox1.Text = "00000000012";
            button2.PerformClick();
            textBox1.Focus();
        }

        private void button59_Click(object sender, EventArgs e)
        {
            textBox1.Text = "00000000020";
            button2.PerformClick();
            textBox1.Focus();
        }

        private void button73_Click(object sender, EventArgs e)
        {
            textBox1.Text = "00000000017";
            button2.PerformClick();
            textBox1.Focus();
        }

        private void button64_Click(object sender, EventArgs e)
        {
            textBox1.Text = "00000000016";
            button2.PerformClick();
            textBox1.Focus();
        }

        private void button72_Click(object sender, EventArgs e)
        {
            textBox1.Text = "00000000021";
            button2.PerformClick();
            textBox1.Focus();
        }

        private void button67_Click(object sender, EventArgs e)
        {
            textBox1.Text = "00000000022";
            button2.PerformClick();
            textBox1.Focus();
        }

        private void button68_Click(object sender, EventArgs e)
        {
            textBox1.Text = "00000000024";
            button2.PerformClick();
            textBox1.Focus();
        }

        private void button63_Click(object sender, EventArgs e)
        {
            textBox1.Text = "00000000018";
            button2.PerformClick();
            textBox1.Focus();
        }

        private void button62_Click(object sender, EventArgs e)
        {
            textBox1.Text = "00000000025";
            button2.PerformClick();
            textBox1.Focus();
        }

        private void button74_Click(object sender, EventArgs e)
        {
            textBox1.Text = "00000000015";
            button2.PerformClick();
            textBox1.Focus();
        }

        private void button71_Click(object sender, EventArgs e)
        {
            textBox1.Text = "00000000026";
            button2.PerformClick();
            textBox1.Focus();
        }

        private void button76_Click(object sender, EventArgs e)
        {
            textBox1.Text = "00000000011";
            button2.PerformClick();
            textBox1.Focus();
        }

        private void button60_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0000000324111";
            button2.PerformClick();
            textBox1.Focus();
        }

        private void button70_Click(object sender, EventArgs e)
        {
            textBox1.Text = "00000000023";
            button2.PerformClick();
            textBox1.Focus();
        }

        private void button65_Click(object sender, EventArgs e)
        {
            textBox1.Text = "00000000027";
            button2.PerformClick();
            textBox1.Focus();
        }

        private void button69_Click(object sender, EventArgs e)
        {
            textBox1.Text = "00000000028";
            button2.PerformClick();
            textBox1.Focus();
        }
        

        private void label5_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count==1)
            {

                
                string s = b1;
                string[] lines = s.Split('\n');
                int iFail = 0, iRow = 0;
                int iCol = 0;
                DataGridViewCell oCell;
                if (dataGridView1.Rows.Count < lines.Length)
                    dataGridView1.Rows.Add(lines.Length - 1);
                foreach (string line in lines)
                {
                    if (iRow < dataGridView1.RowCount && line.Length > 0)
                    {
                        string[] sCells = line.Split('\t');
                        for (int i = 0; i < sCells.GetLength(0); ++i)
                        {
                            if (iCol + i < this.dataGridView1.ColumnCount)
                            {
                                oCell = dataGridView1[iCol + i, iRow];
                                if (!oCell.ReadOnly)
                                {
                                    if (oCell.Value == null || oCell.Value.ToString() != sCells[i])
                                    {
                                        oCell.Value = Convert.ChangeType(sCells[i],
                                                              oCell.ValueType);
                                        //  oCell.Style.BackColor = Color.Tomato;
                                    }
                                    else
                                        iFail++;
                                    //only traps a fail if the data has changed 
                                    //and you are pasting into a read only cell
                                }
                            }
                            else
                            { break; }
                        }
                        iRow++;
                    }
                    else
                    { break; }
                    if (iFail > 0)
                        MessageBox.Show(string.Format("{0} updates failed due" +
                                        " to read only column setting", iFail));
                }
                yenile();
                miktarci();
                label5.Text = "";
                label5.Visible = false;
                textBox1.Focus();
            }
            else
            {
                MessageBox.Show("Satışı tamamlayın!");
                textBox1.Focus();
            }
        
            

        }
        string b1;
        string b2;
        string b3;
        private void button23_Click_1(object sender, EventArgs e)
        {
            panel3.Visible = true;
            double a;
            int b;
            dataGridView1.SelectAll();
            DataObject d = dataGridView1.GetClipboardContent();
            Clipboard.SetDataObject(d);
            if (label2.Text == "")
            {
                MessageBox.Show("Lütfen Önce Satış Yapın!");
                textBox1.Focus();
            }
            else
            {
                a = Convert.ToDouble(label2.Text);
                b = Convert.ToInt32(label3.Text);
                dataGridView1.Rows.Clear();
                label2.Text = "";
                label3.Text = "";
                if (label5.Text == "")
                {
                    label5.Visible = true;
                    b1 = Clipboard.GetText();
                    label5.Text = a.ToString();
                    textBox1.Focus();
                }
                else if (label6.Text == "")
                {
                    label6.Visible = true;
                    b2 = Clipboard.GetText();
                    label6.Text = a.ToString();
                    textBox1.Focus();
                }
                else if (label7.Text == "")
                {
                    label7.Visible = true;
                    b3 = Clipboard.GetText();
                    label7.Text = a.ToString();
                    textBox1.Focus();
                }
                else
                {

                    MessageBox.Show("Daha fazla beklet yapamazsınız");
                    textBox1.Focus();
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 1)
            {
                string s = b2;
                string[] lines = s.Split('\n');
                int iFail = 0, iRow = 0;
                int iCol = 0;
                DataGridViewCell oCell;
                if (dataGridView1.Rows.Count < lines.Length)
                    dataGridView1.Rows.Add(lines.Length - 1);
                foreach (string line in lines)
                {
                    if (iRow < dataGridView1.RowCount && line.Length > 0)
                    {
                        string[] sCells = line.Split('\t');
                        for (int i = 0; i < sCells.GetLength(0); ++i)
                        {
                            if (iCol + i < this.dataGridView1.ColumnCount)
                            {
                                oCell = dataGridView1[iCol + i, iRow];
                                if (!oCell.ReadOnly)
                                {
                                    if (oCell.Value == null || oCell.Value.ToString() != sCells[i])
                                    {
                                        oCell.Value = Convert.ChangeType(sCells[i],
                                                              oCell.ValueType);
                                        //  oCell.Style.BackColor = Color.Tomato;
                                    }
                                    else
                                        iFail++;
                                    //only traps a fail if the data has changed 
                                    //and you are pasting into a read only cell
                                }
                            }
                            else
                            { break; }
                        }
                        iRow++;
                    }
                    else
                    { break; }
                    if (iFail > 0)
                        MessageBox.Show(string.Format("{0} updates failed due" +
                                        " to read only column setting", iFail));
                }
                yenile();
                miktarci();
                label6.Text = "";
                label6.Visible = false;
                textBox1.Focus();
            }
            else
            {
                MessageBox.Show("Satışı tamamlayın!");
                textBox1.Focus();
            }

        }

        private void label7_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 1)
            { 
            string s = b3;
            string[] lines = s.Split('\n');
            int iFail = 0, iRow = 0;
            int iCol = 0;
            DataGridViewCell oCell;
            if (dataGridView1.Rows.Count < lines.Length)
                dataGridView1.Rows.Add(lines.Length - 1);
            foreach (string line in lines)
            {
                if (iRow < dataGridView1.RowCount && line.Length > 0)
                {
                    string[] sCells = line.Split('\t');
                    for (int i = 0; i < sCells.GetLength(0); ++i)
                    {
                        if (iCol + i < this.dataGridView1.ColumnCount)
                        {
                            oCell = dataGridView1[iCol + i, iRow];
                            if (!oCell.ReadOnly)
                            {
                                if (oCell.Value == null || oCell.Value.ToString() != sCells[i])
                                {
                                    oCell.Value = Convert.ChangeType(sCells[i],
                                                          oCell.ValueType);
                                    //  oCell.Style.BackColor = Color.Tomato;
                                }
                                else
                                    iFail++;
                                //only traps a fail if the data has changed 
                                //and you are pasting into a read only cell
                            }
                        }
                        else
                        { break; }
                    }
                    iRow++;
                }
                else
                { break; }
                if (iFail > 0)
                    MessageBox.Show(string.Format("{0} updates failed due" +
                                    " to read only column setting", iFail));
            }
            yenile();
            miktarci();
            label7.Text = "";
            label7.Visible = false;
            textBox1.Focus();
            }
            else
            {
                MessageBox.Show("Satışı tamamlayın!");
                textBox1.Focus();
            }
        }

       public string StokGetir()
        {   
            SqlCommand cmd = new SqlCommand("Select Miktar from Tablo where id=@id", baglanti);
            baglanti.Open();
            cmd.Parameters.AddWithValue("@id", textBox1.Text);
           
                mdon = cmd.ExecuteScalar();
            if (mdon != null && DBNull.Value!=mdon) {
               
                baglanti.Close();
                return mdon.ToString();
            }
               
            
            else
            {
                mdon = "0";
                baglanti.Close();
                return mdon.ToString();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0123456789";
            button2.PerformClick();
            textBox1.Focus();
        }
    }
    
}
