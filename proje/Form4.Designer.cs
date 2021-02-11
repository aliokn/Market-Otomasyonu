namespace proje
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BarkodNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Miktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToplamFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarih = new System.Windows.Forms.Label();
            this.Tf = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Tarihi = new System.Windows.Forms.Label();
            this.Tfiyat = new System.Windows.Forms.Label();
            this.Once = new System.Windows.Forms.Button();
            this.Sonra = new System.Windows.Forms.Button();
            this.Fis = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BarkodNo,
            this.Ad,
            this.Miktar,
            this.Fiyat,
            this.ToplamFiyat});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 293);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 157);
            this.dataGridView1.TabIndex = 0;
            // 
            // BarkodNo
            // 
            this.BarkodNo.HeaderText = "Barkod No";
            this.BarkodNo.Name = "BarkodNo";
            // 
            // Ad
            // 
            this.Ad.HeaderText = "Ad";
            this.Ad.Name = "Ad";
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
            // Tarih
            // 
            this.Tarih.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Tarih.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tarih.Location = new System.Drawing.Point(656, 123);
            this.Tarih.Name = "Tarih";
            this.Tarih.Size = new System.Drawing.Size(86, 25);
            this.Tarih.TabIndex = 1;
            this.Tarih.Text = "TARİH";
            this.Tarih.Click += new System.EventHandler(this.Tarih_Click);
            // 
            // Tf
            // 
            this.Tf.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tf.Location = new System.Drawing.Point(58, 123);
            this.Tf.Name = "Tf";
            this.Tf.Size = new System.Drawing.Size(82, 20);
            this.Tf.TabIndex = 2;
            this.Tf.Text = "Fiyat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(657, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Tarihi
            // 
            this.Tarihi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Tarihi.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tarihi.Location = new System.Drawing.Point(657, 166);
            this.Tarihi.Name = "Tarihi";
            this.Tarihi.Size = new System.Drawing.Size(93, 57);
            this.Tarihi.TabIndex = 4;
            this.Tarihi.Text = "label2";
            // 
            // Tfiyat
            // 
            this.Tfiyat.Font = new System.Drawing.Font("MS Reference Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tfiyat.Location = new System.Drawing.Point(57, 150);
            this.Tfiyat.Name = "Tfiyat";
            this.Tfiyat.Size = new System.Drawing.Size(92, 56);
            this.Tfiyat.TabIndex = 5;
            this.Tfiyat.Text = "label2";
            this.Tfiyat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Once
            // 
            this.Once.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Once.BackColor = System.Drawing.Color.NavajoWhite;
            this.Once.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Once.FlatAppearance.BorderSize = 0;
            this.Once.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Once.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Once.Location = new System.Drawing.Point(191, 167);
            this.Once.Name = "Once";
            this.Once.Size = new System.Drawing.Size(106, 39);
            this.Once.TabIndex = 6;
            this.Once.Text = "Önceki";
            this.Once.UseVisualStyleBackColor = false;
            this.Once.Click += new System.EventHandler(this.Once_Click);
            // 
            // Sonra
            // 
            this.Sonra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Sonra.BackColor = System.Drawing.Color.NavajoWhite;
            this.Sonra.FlatAppearance.BorderSize = 0;
            this.Sonra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sonra.Location = new System.Drawing.Point(505, 166);
            this.Sonra.Name = "Sonra";
            this.Sonra.Size = new System.Drawing.Size(106, 40);
            this.Sonra.TabIndex = 7;
            this.Sonra.Text = "Sonraki";
            this.Sonra.UseVisualStyleBackColor = false;
            this.Sonra.Click += new System.EventHandler(this.Sonra_Click);
            // 
            // Fis
            // 
            this.Fis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Fis.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fis.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Fis.Location = new System.Drawing.Point(312, 87);
            this.Fis.Name = "Fis";
            this.Fis.Size = new System.Drawing.Size(187, 82);
            this.Fis.TabIndex = 8;
            this.Fis.Text = "label2";
            this.Fis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(94, 20);
            this.textBox1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(112, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Fişe Git";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Fis);
            this.Controls.Add(this.Sonra);
            this.Controls.Add(this.Once);
            this.Controls.Add(this.Tfiyat);
            this.Controls.Add(this.Tarihi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tf);
            this.Controls.Add(this.Tarih);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Tarih;
        private System.Windows.Forms.Label Tf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Tarihi;
        private System.Windows.Forms.Label Tfiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn BarkodNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Miktar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToplamFiyat;
        private System.Windows.Forms.Button Once;
        private System.Windows.Forms.Button Sonra;
        private System.Windows.Forms.Label Fis;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}