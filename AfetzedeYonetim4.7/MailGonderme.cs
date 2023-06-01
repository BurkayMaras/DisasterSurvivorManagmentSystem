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
using System.Net.Mail;
using System.Reflection.Emit;
using Emgu.CV;

namespace AfetzedeYonetim4._7
{
    public partial class MailGonderme : Form
    {
        string mailAdresi = "";
        string query3 = "select eposta from afetzedes";
        string bulunanKisiIsim;
        

		SqlConnection baglanti = new SqlConnection(@"Data Source=" + Connection.connectionName + ";Initial Catalog=afetzedeyonetimdb;Integrated Security=True");


        public MailGonderme(string foundedName)
        {
			InitializeComponent();

			label4.Text = foundedName;
            bulunanKisiIsim = foundedName;
            
           
            sehirekle();
        }

        void sehirekle()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from iller", baglanti);
            SqlDataReader dr= komut.ExecuteReader();    
            while (dr.Read())
            {
                comboBox2.Items.Add(dr[1]);
            }
            baglanti.Close();
        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Items.Clear();
            comboBox3.Text = "";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from hastaneler where sehirid=@p1",baglanti);
            komut.Parameters.AddWithValue("@p1", comboBox2.SelectedIndex + 1);
            SqlDataReader dr=komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox3.Items.Add(dr[1]);
            }
            baglanti.Close();
        }

        private void kayitButon_Click(object sender, EventArgs e)
        {
            MailMessage mesaj = new MailMessage();
            SmtpClient istemci = new SmtpClient("smtp.office365.com", 587);
            istemci.Credentials = new System.Net.NetworkCredential("afetzedeihbaryonetim@hotmail.com", "1234afet1234");
            istemci.EnableSsl = true;
            mesaj.To.Add(mailAdresi); //GÖNDERİLECEK ADRES
            mesaj.From = new MailAddress("afetzedeihbaryonetim@hotmail.com");
            mesaj.Subject="Afetzedenizin Durumu Hakkında";
            mesaj.Body = bulunanKisiIsim + " isimli afetzede yakınınız "+comboBox1.Text+" halde "+comboBox2.Text+" ilinde bulunmuştur. Afetzedeniz "+comboBox3.Text +" ne sevk edilmektedir.";
            istemci.Send(mesaj);
            MessageBox.Show("Mail gönderildi.");
            bulundu_Isaretle(bulunanKisiIsim);
			
			this.Hide();
			AdminAnasayfa kullaniciGiris = new AdminAnasayfa();
			kullaniciGiris.ShowDialog();
			this.Close();

		}

		private void MailGonderme_Load(object sender, EventArgs e)
		{
            baglanti.Open();
			using (SqlCommand command2 = new SqlCommand(query3, baglanti))
			{
				using (SqlDataReader reader = command2.ExecuteReader())
				{
					while (reader.Read())
					{
						mailAdresi= reader.GetString(0); // Sütun indeksine göre değeri alın (0 ilk sütunu temsil eder)
						
					}
				}
			}
            baglanti.Close();
		}
        private void bulundu_Isaretle(string bulunanKisi) {
			baglanti.Open();
			SqlCommand komut = new SqlCommand("UPDATE afetzedes SET bulundu = 1 WHERE isim = '"+ bulunanKisiIsim + "';" , baglanti);
			SqlDataReader dr = komut.ExecuteReader();
            baglanti.Close() ;
		}

        private void button2_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            AdminAnasayfa kullaniciGiris = new AdminAnasayfa();
            AdminAnasayfa.flag = false;
            kullaniciGiris.ShowDialog();
            this.Close();
        }
    }
}
