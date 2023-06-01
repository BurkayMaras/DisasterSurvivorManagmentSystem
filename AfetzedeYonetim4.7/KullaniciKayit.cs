using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AfetzedeYonetim4._7
{
	public partial class KullaniciKayit : Form
	{
		public KullaniciKayit()
		{
			InitializeComponent();
		}
		SqlConnection baglanti = new SqlConnection(@"Data Source=" + Connection.connectionName + ";Initial Catalog=afetzedeyonetimdb;Integrated Security=True");

		private void kayitButon_Click(object sender, EventArgs e)
		{
			string sorgu = "insert into kullanici(ad,soyad,eposta,sifre)values(@ad,@soyad,@eposta,@sifre)";
			SqlCommand komut = new SqlCommand(sorgu, baglanti);
			komut.Parameters.AddWithValue("@ad", adKayit.Text);
			komut.Parameters.AddWithValue("@soyad", soyadKayit.Text);
			komut.Parameters.AddWithValue("@eposta", epostaKayit.Text+comboBox1.Text);
			komut.Parameters.AddWithValue("@sifre", sifreKayit.Text);
			baglanti.Open();
			komut.ExecuteNonQuery();
			MessageBox.Show("kayıt edildi");
			adKayit.Clear(); soyadKayit.Clear(); epostaKayit.Clear(); sifreKayit.Clear();
			baglanti.Close();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Hide();
			KullaniciGiris kullaniciGiris = new KullaniciGiris();
			kullaniciGiris.ShowDialog();
			this.Close();
		}

        private void pictureBox2_Click(object sender, EventArgs e)
        {
			if (sifreKayit.UseSystemPasswordChar == false)
			{
				sifreKayit.UseSystemPasswordChar = true;
			}
			else
			{
				sifreKayit.UseSystemPasswordChar= false;
			}
        }
    }
}
