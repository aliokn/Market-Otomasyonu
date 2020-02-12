namespace proje
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.arama = new System.Windows.Forms.Button();
            this.Yenisatis = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ürün = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Miktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToplamFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button21 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.silme = new System.Windows.Forms.Button();
            this.SonSatis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(634, 20);
            this.textBox1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.Color.DarkKhaki;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button2.Location = new System.Drawing.Point(12, 61);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 31);
            this.button2.TabIndex = 4;
            this.button2.Text = "ARA";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(716, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Toplam Fiyat";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 65F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(717, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(357, 110);
            this.label2.TabIndex = 8;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // arama
            // 
            this.arama.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.arama.BackColor = System.Drawing.Color.PowderBlue;
            this.arama.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.arama.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.arama.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arama.Location = new System.Drawing.Point(1134, 254);
            this.arama.Name = "arama";
            this.arama.Size = new System.Drawing.Size(189, 36);
            this.arama.TabIndex = 9;
            this.arama.Text = "Ürün Ara";
            this.arama.UseVisualStyleBackColor = false;
            this.arama.Click += new System.EventHandler(this.button1_Click);
            // 
            // Yenisatis
            // 
            this.Yenisatis.BackColor = System.Drawing.Color.LimeGreen;
            this.Yenisatis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Yenisatis.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.Yenisatis.FlatAppearance.BorderSize = 0;
            this.Yenisatis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Yenisatis.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Yenisatis.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Yenisatis.Location = new System.Drawing.Point(12, 254);
            this.Yenisatis.Name = "Yenisatis";
            this.Yenisatis.Size = new System.Drawing.Size(340, 36);
            this.Yenisatis.TabIndex = 10;
            this.Yenisatis.Text = "YENİ SATIŞ";
            this.Yenisatis.UseVisualStyleBackColor = false;
            this.Yenisatis.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Ürün,
            this.Miktar,
            this.Fiyat,
            this.ToplamFiyat});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(0, 296);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.Size = new System.Drawing.Size(1335, 298);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Barkod No";
            this.Column1.Name = "Column1";
            // 
            // Ürün
            // 
            this.Ürün.HeaderText = "Ürün Adı";
            this.Ürün.Name = "Ürün";
            // 
            // Miktar
            // 
            this.Miktar.HeaderText = "Miktar";
            this.Miktar.Name = "Miktar";
            // 
            // Fiyat
            // 
            this.Fiyat.HeaderText = "Fiyat";
            this.Fiyat.Name = "Fiyat";
            // 
            // ToplamFiyat
            // 
            this.ToplamFiyat.HeaderText = "Toplam Fiyat";
            this.ToplamFiyat.Name = "ToplamFiyat";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.button21);
            this.panel1.Controls.Add(this.button20);
            this.panel1.Controls.Add(this.button19);
            this.panel1.Controls.Add(this.button18);
            this.panel1.Controls.Add(this.button17);
            this.panel1.Controls.Add(this.button16);
            this.panel1.Controls.Add(this.button15);
            this.panel1.Controls.Add(this.button14);
            this.panel1.Controls.Add(this.button13);
            this.panel1.Controls.Add(this.button12);
            this.panel1.Controls.Add(this.button11);
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Location = new System.Drawing.Point(0, 148);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1335, 100);
            this.panel1.TabIndex = 11;
            // 
            // button21
            // 
            this.button21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button21.Location = new System.Drawing.Point(1149, 59);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(112, 23);
            this.button21.TabIndex = 17;
            this.button21.Text = "Zeytin";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // button20
            // 
            this.button20.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button20.Location = new System.Drawing.Point(686, 59);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(111, 23);
            this.button20.TabIndex = 16;
            this.button20.Text = "Sucuk";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // button19
            // 
            this.button19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button19.Location = new System.Drawing.Point(904, 59);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(113, 23);
            this.button19.TabIndex = 15;
            this.button19.Text = "Ekmek";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // button18
            // 
            this.button18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button18.Location = new System.Drawing.Point(556, 59);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(113, 23);
            this.button18.TabIndex = 14;
            this.button18.Text = "Kavurma";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button17
            // 
            this.button17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button17.Location = new System.Drawing.Point(437, 59);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(113, 23);
            this.button17.TabIndex = 13;
            this.button17.Text = "Taze Kaşar";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(296, 59);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(113, 23);
            this.button16.TabIndex = 12;
            this.button16.Text = "Salam";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(164, 59);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(126, 23);
            this.button15.TabIndex = 11;
            this.button15.Text = "Peynir";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(10, 59);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(135, 23);
            this.button14.TabIndex = 10;
            this.button14.Text = "Toz Şeker";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button13
            // 
            this.button13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button13.Location = new System.Drawing.Point(1149, 18);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(112, 23);
            this.button13.TabIndex = 9;
            this.button13.Text = "Portakal";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button12
            // 
            this.button12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button12.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button12.Location = new System.Drawing.Point(1026, 18);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(107, 23);
            this.button12.TabIndex = 8;
            this.button12.Text = "Mandalina";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button11
            // 
            this.button11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button11.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button11.Location = new System.Drawing.Point(1026, 59);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(107, 23);
            this.button11.TabIndex = 7;
            this.button11.Text = "Kiraz";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button10
            // 
            this.button10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button10.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button10.Location = new System.Drawing.Point(904, 18);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(113, 23);
            this.button10.TabIndex = 6;
            this.button10.Text = "Limon";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button9.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button9.Location = new System.Drawing.Point(686, 18);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(111, 23);
            this.button9.TabIndex = 5;
            this.button9.Text = "Erik";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button8.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button8.Location = new System.Drawing.Point(556, 18);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(113, 23);
            this.button8.TabIndex = 4;
            this.button8.Text = "Elma";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button7.Location = new System.Drawing.Point(437, 18);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(113, 23);
            this.button7.TabIndex = 3;
            this.button7.Text = "Salatalık";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(296, 18);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(113, 23);
            this.button6.TabIndex = 2;
            this.button6.Text = "Domates";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(164, 18);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(126, 23);
            this.button5.TabIndex = 1;
            this.button5.Text = "Soğan";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(10, 18);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(135, 23);
            this.button4.TabIndex = 0;
            this.button4.Text = "Patates";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // silme
            // 
            this.silme.BackColor = System.Drawing.Color.Red;
            this.silme.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.silme.FlatAppearance.BorderSize = 0;
            this.silme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.silme.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.silme.Location = new System.Drawing.Point(363, 254);
            this.silme.Name = "silme";
            this.silme.Size = new System.Drawing.Size(193, 36);
            this.silme.TabIndex = 12;
            this.silme.Text = "Ürünü Sil";
            this.silme.UseVisualStyleBackColor = false;
            this.silme.Click += new System.EventHandler(this.button22_Click);
            // 
            // SonSatis
            // 
            this.SonSatis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SonSatis.BackColor = System.Drawing.Color.SandyBrown;
            this.SonSatis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SonSatis.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SonSatis.Location = new System.Drawing.Point(992, 254);
            this.SonSatis.Name = "SonSatis";
            this.SonSatis.Size = new System.Drawing.Size(127, 36);
            this.SonSatis.TabIndex = 13;
            this.SonSatis.Text = "Son Satış";
            this.SonSatis.UseVisualStyleBackColor = false;
            this.SonSatis.Click += new System.EventHandler(this.SonSatis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1335, 594);
            this.Controls.Add(this.SonSatis);
            this.Controls.Add(this.silme);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Yenisatis);
            this.Controls.Add(this.arama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button arama;
        private System.Windows.Forms.Button Yenisatis;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ürün;
        private System.Windows.Forms.DataGridViewTextBoxColumn Miktar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToplamFiyat;
        private System.Windows.Forms.Button silme;
        private System.Windows.Forms.Button SonSatis;
    }
}

