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
	public partial class AdminGiris : Form
	{
		public AdminGiris()
		{
			InitializeComponent();
		}
		SqlConnection baglanti = new SqlConnection(@"Data Source=" + Connection.connectionName + ";Initial Catalog=afetzedeyonetimdb;Integrated Security=True");

		private void button2_Click(object sender, EventArgs e)
		{
			this.Hide();
			Menu menu = new Menu();
			menu.ShowDialog();
			this.Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			baglanti.Open();
			SqlCommand cmd = new SqlCommand("select * from admins where name='" + adminIsimGiris.Text + "'and sifre='" + adminSifreGiris.Text + "'", baglanti);
			SqlDataReader reader = cmd.ExecuteReader();
			if (reader.Read())
			{
                this.Hide();
                AdminAnasayfa anasayfa = new AdminAnasayfa();//burada admin panelini açacağız
				anasayfa.ShowDialog();
                this.Close();
            }
			else
			{
				MessageBox.Show("Hatalı mail adresi veya şifre girdiniz!");
			}
			baglanti.Close();
		}

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (adminSifreGiris.UseSystemPasswordChar == false)
            {
                adminSifreGiris.UseSystemPasswordChar = true;
            }
            else
            {
                adminSifreGiris.UseSystemPasswordChar = false;
            }
        }
    }
}
