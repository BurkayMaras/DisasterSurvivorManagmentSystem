namespace AfetzedeYonetim4._7
{
	partial class AdminAnasayfa
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminAnasayfa));
			this.button1 = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.afetzedeyonetimdbDataSet = new AfetzedeYonetim4._7.afetzedeyonetimdbDataSet();
			this.afetzedeyonetimdbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.camerabox = new Emgu.CV.UI.ImageBox();
			this.button2 = new System.Windows.Forms.Button();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewImageColumn();
			this.bulundu = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.afetzedeyonetimdbDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.afetzedeyonetimdbDataSetBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.camerabox)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Plum;
			this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button1.Location = new System.Drawing.Point(3, 545);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Geri dön";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column6,
            this.Column3,
            this.Column4,
            this.Column5,
            this.bulundu});
			this.dataGridView1.Location = new System.Drawing.Point(54, 258);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 100;
			this.dataGridView1.Size = new System.Drawing.Size(775, 281);
			this.dataGridView1.TabIndex = 1;
			// 
			// afetzedeyonetimdbDataSet
			// 
			this.afetzedeyonetimdbDataSet.DataSetName = "afetzedeyonetimdbDataSet";
			this.afetzedeyonetimdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// afetzedeyonetimdbDataSetBindingSource
			// 
			this.afetzedeyonetimdbDataSetBindingSource.DataSource = this.afetzedeyonetimdbDataSet;
			this.afetzedeyonetimdbDataSetBindingSource.Position = 0;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::AfetzedeYonetim4._7.Properties.Resources.AFETZEDE_İHBAR_VE_YÖNETİM_SİSTEMİ__1__removebg_preview;
			this.pictureBox1.Location = new System.Drawing.Point(676, 10);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(153, 164);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 12;
			this.pictureBox1.TabStop = false;
			// 
			// camerabox
			// 
			this.camerabox.Location = new System.Drawing.Point(302, 10);
			this.camerabox.Name = "camerabox";
			this.camerabox.Size = new System.Drawing.Size(235, 231);
			this.camerabox.TabIndex = 2;
			this.camerabox.TabStop = false;
			// 
			// button2
			// 
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button2.Image = global::AfetzedeYonetim4._7.Properties.Resources._8666672_camera_icon__1_;
			this.button2.Location = new System.Drawing.Point(96, 53);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(115, 121);
			this.button2.TabIndex = 0;
			this.button2.Text = "Kamerayı Aç";
			this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click_1);
			// 
			// Column1
			// 
			this.Column1.DataPropertyName = "isim";
			this.Column1.FillWeight = 80F;
			this.Column1.HeaderText = "İsim";
			this.Column1.MinimumWidth = 6;
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Width = 80;
			// 
			// Column2
			// 
			this.Column2.DataPropertyName = "soyisim";
			this.Column2.FillWeight = 80F;
			this.Column2.HeaderText = "Soyisim";
			this.Column2.MinimumWidth = 6;
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			this.Column2.Width = 80;
			// 
			// Column6
			// 
			this.Column6.DataPropertyName = "tc";
			this.Column6.HeaderText = "TC";
			this.Column6.MinimumWidth = 6;
			this.Column6.Name = "Column6";
			this.Column6.ReadOnly = true;
			// 
			// Column3
			// 
			this.Column3.DataPropertyName = "eposta";
			this.Column3.HeaderText = "İletişim";
			this.Column3.MinimumWidth = 6;
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			this.Column3.Width = 125;
			// 
			// Column4
			// 
			this.Column4.DataPropertyName = "adres";
			this.Column4.HeaderText = "Adres";
			this.Column4.MinimumWidth = 6;
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			this.Column4.Width = 125;
			// 
			// Column5
			// 
			this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column5.DataPropertyName = "resim";
			this.Column5.HeaderText = "Resim";
			this.Column5.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
			this.Column5.MinimumWidth = 6;
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// bulundu
			// 
			this.bulundu.DataPropertyName = "bulundu";
			this.bulundu.HeaderText = "Bulunma Durumu";
			this.bulundu.Name = "bulundu";
			this.bulundu.ReadOnly = true;
			this.bulundu.Visible = false;
			// 
			// AdminAnasayfa
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(864, 574);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.camerabox);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "AdminAnasayfa";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AdminAnasayfa";
			this.Load += new System.EventHandler(this.AdminAnasayfa_Load_1);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.afetzedeyonetimdbDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.afetzedeyonetimdbDataSetBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.camerabox)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.BindingSource afetzedeyonetimdbDataSetBindingSource;
		private afetzedeyonetimdbDataSet afetzedeyonetimdbDataSet;
		private System.Windows.Forms.Button button2;
		private Emgu.CV.UI.ImageBox camerabox;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewImageColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn bulundu;
	}
}