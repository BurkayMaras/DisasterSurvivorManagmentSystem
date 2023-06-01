namespace AfetzedeYonetim4._7
{
	partial class KullaniciAnasayfa
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciAnasayfa));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.ihbarisimText = new System.Windows.Forms.TextBox();
			this.ihbarsoyisimText = new System.Windows.Forms.TextBox();
			this.ihbartcText = new System.Windows.Forms.TextBox();
			this.ihbaradresText = new System.Windows.Forms.TextBox();
			this.ihbarepostaText = new System.Windows.Forms.TextBox();
			this.ihbarresimEklebtn = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.ihbarresimText = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.eklenenResim = new System.Windows.Forms.PictureBox();
			this.cameraBox2 = new Emgu.CV.UI.ImageBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.eklenenResim)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cameraBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(218, 67);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(86, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Afetzedenin ismi:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(200, 111);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(104, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Afetzedenin Soyismi:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(231, 153);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(24, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "TC:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(218, 193);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(37, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Adres:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(200, 238);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "İletişim için E-Posta:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(218, 288);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(39, 13);
			this.label6.TabIndex = 5;
			this.label6.Text = "Resim:";
			// 
			// ihbarisimText
			// 
			this.ihbarisimText.Location = new System.Drawing.Point(306, 63);
			this.ihbarisimText.Name = "ihbarisimText";
			this.ihbarisimText.Size = new System.Drawing.Size(100, 20);
			this.ihbarisimText.TabIndex = 6;
			this.ihbarisimText.TextChanged += new System.EventHandler(this.ihbarisimText_TextChanged);
			// 
			// ihbarsoyisimText
			// 
			this.ihbarsoyisimText.Location = new System.Drawing.Point(306, 108);
			this.ihbarsoyisimText.Name = "ihbarsoyisimText";
			this.ihbarsoyisimText.Size = new System.Drawing.Size(100, 20);
			this.ihbarsoyisimText.TabIndex = 7;
			this.ihbarsoyisimText.TextChanged += new System.EventHandler(this.ihbarsoyisimText_TextChanged);
			// 
			// ihbartcText
			// 
			this.ihbartcText.Location = new System.Drawing.Point(306, 153);
			this.ihbartcText.Name = "ihbartcText";
			this.ihbartcText.Size = new System.Drawing.Size(100, 20);
			this.ihbartcText.TabIndex = 8;
			this.ihbartcText.TextChanged += new System.EventHandler(this.ihbartcText_TextChanged);
			// 
			// ihbaradresText
			// 
			this.ihbaradresText.Location = new System.Drawing.Point(306, 196);
			this.ihbaradresText.Name = "ihbaradresText";
			this.ihbaradresText.Size = new System.Drawing.Size(100, 20);
			this.ihbaradresText.TabIndex = 9;
			this.ihbaradresText.TextChanged += new System.EventHandler(this.ihbaradresText_TextChanged);
			// 
			// ihbarepostaText
			// 
			this.ihbarepostaText.Location = new System.Drawing.Point(306, 235);
			this.ihbarepostaText.Name = "ihbarepostaText";
			this.ihbarepostaText.Size = new System.Drawing.Size(100, 20);
			this.ihbarepostaText.TabIndex = 10;
			// 
			// ihbarresimEklebtn
			// 
			this.ihbarresimEklebtn.Location = new System.Drawing.Point(220, 323);
			this.ihbarresimEklebtn.Name = "ihbarresimEklebtn";
			this.ihbarresimEklebtn.Size = new System.Drawing.Size(25, 20);
			this.ihbarresimEklebtn.TabIndex = 12;
			this.ihbarresimEklebtn.Text = "...";
			this.ihbarresimEklebtn.UseVisualStyleBackColor = true;
			this.ihbarresimEklebtn.Click += new System.EventHandler(this.ihbarresimEklebtn_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Plum;
			this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button1.Location = new System.Drawing.Point(324, 392);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(60, 34);
			this.button1.TabIndex = 12;
			this.button1.Text = "Ekle";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// ihbarresimText
			// 
			this.ihbarresimText.Enabled = false;
			this.ihbarresimText.Location = new System.Drawing.Point(306, 363);
			this.ihbarresimText.Name = "ihbarresimText";
			this.ihbarresimText.ReadOnly = true;
			this.ihbarresimText.Size = new System.Drawing.Size(100, 20);
			this.ihbarresimText.TabIndex = 11;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::AfetzedeYonetim4._7.Properties.Resources.AFETZEDE_İHBAR_VE_YÖNETİM_SİSTEMİ__1__removebg_preview;
			this.pictureBox1.Location = new System.Drawing.Point(494, 22);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(284, 226);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 13;
			this.pictureBox1.TabStop = false;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button2.Location = new System.Drawing.Point(26, 392);
			this.button2.Margin = new System.Windows.Forms.Padding(2);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(82, 34);
			this.button2.TabIndex = 14;
			this.button2.Text = "Geri dön";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(220, 350);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(80, 33);
			this.button3.TabIndex = 15;
			this.button3.Text = "Kamerayı Aç";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// eklenenResim
			// 
			this.eklenenResim.Location = new System.Drawing.Point(306, 261);
			this.eklenenResim.Name = "eklenenResim";
			this.eklenenResim.Size = new System.Drawing.Size(100, 96);
			this.eklenenResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.eklenenResim.TabIndex = 11;
			this.eklenenResim.TabStop = false;
			// 
			// cameraBox2
			// 
			this.cameraBox2.Location = new System.Drawing.Point(494, 253);
			this.cameraBox2.Name = "cameraBox2";
			this.cameraBox2.Size = new System.Drawing.Size(284, 193);
			this.cameraBox2.TabIndex = 2;
			this.cameraBox2.TabStop = false;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "@hotmail.com",
            "@gmail.com",
            "@outlook.com"});
			this.comboBox1.Location = new System.Drawing.Point(412, 235);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(77, 21);
			this.comboBox1.TabIndex = 16;
			// 
			// KullaniciAnasayfa
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(828, 458);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.cameraBox2);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.ihbarresimEklebtn);
			this.Controls.Add(this.eklenenResim);
			this.Controls.Add(this.ihbarresimText);
			this.Controls.Add(this.ihbarepostaText);
			this.Controls.Add(this.ihbaradresText);
			this.Controls.Add(this.ihbartcText);
			this.Controls.Add(this.ihbarsoyisimText);
			this.Controls.Add(this.ihbarisimText);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "KullaniciAnasayfa";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "KullaniciAnasayfa";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.eklenenResim)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cameraBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox ihbarisimText;
		private System.Windows.Forms.TextBox ihbarsoyisimText;
		private System.Windows.Forms.TextBox ihbartcText;
		private System.Windows.Forms.TextBox ihbaradresText;
		private System.Windows.Forms.TextBox ihbarepostaText;
		private System.Windows.Forms.Button ihbarresimEklebtn;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.TextBox ihbarresimText;
		private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.PictureBox eklenenResim;
		private Emgu.CV.UI.ImageBox cameraBox2;
		private System.Windows.Forms.ComboBox comboBox1;
	}
}