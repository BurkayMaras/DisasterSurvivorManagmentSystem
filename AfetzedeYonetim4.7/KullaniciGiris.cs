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
	public partial class KullaniciGiris : Form
	{
		public KullaniciGiris()
		{
			InitializeComponent();
		}
		SqlConnection baglanti = new SqlConnection(@"Data Source=" + Connection.connectionName + ";Initial Catalog=afetzedeyonetimdb;Integrated Security=True");
		private void button1_Click(object sender, EventArgs e)
		{
			baglanti.Open();
			SqlCommand cmd = new SqlCommand("select * from kullanici where eposta='" + postaGiris.Text + "'and sifre='" + sifreGiris.Text + "'", baglanti);
			SqlDataReader reader = cmd.ExecuteReader();
			if (reader.Read())
			{
				this.Hide();
				KullaniciAnasayfa anasayfa = new KullaniciAnasayfa();
				anasayfa.ShowDialog();
				this.Close();
			}
			else
			{
				MessageBox.Show("Hatalı mail adresi veya şifre girdiniz!");
			}
			baglanti.Close();
		}

		private void button2_Click(object sender, EventArgs e)
		{
            this.Hide();
            Menu kullaniciGiris = new Menu();
			kullaniciGiris.ShowDialog();
            this.Close();
        }

		private void button3_Click(object sender, EventArgs e)
		{
			this.Hide();
			KullaniciKayit kullaniciKayit = new KullaniciKayit();
			kullaniciKayit.ShowDialog();
			this.Close();
		}

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (sifreGiris.UseSystemPasswordChar == false)
            {
                sifreGiris.UseSystemPasswordChar = true;
            }
            else
            {
                sifreGiris.UseSystemPasswordChar = false;
            }
        }
    }
}
