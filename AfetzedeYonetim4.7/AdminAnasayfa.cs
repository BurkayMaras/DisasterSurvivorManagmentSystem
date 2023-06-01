using Emgu.CV.Structure;
using Emgu.CV;
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
using System.Collections;
using System.IO;

namespace AfetzedeYonetim4._7
{
	public partial class AdminAnasayfa : Form
	{
		public static bool flag = false;
		MCvFont font = new MCvFont(Emgu.CV.CvEnum.FONT.CV_FONT_HERSHEY_TRIPLEX, 0.6d, 0.6d);
		string query1 = "SELECT * FROM afetzedes where bulundu is null";
		string query2 = "SELECT isim FROM afetzedes where bulundu is null";
		HaarCascade faceDetected = new HaarCascade("haarcascade_frontalface_default.xml");
		Image<Bgr, Byte> Frame;
		Capture camera;
		Image<Gray, byte> result;
		Image<Gray, byte> TrainedFace = null;
		Image<Gray, byte> grayFace = null;
		List<Image<Gray, byte>> trainingImages = new List<Image<Gray, byte>>();
		List<string> labels = new List<string>();
		
		
		int Count, NumLables, t;
		string name;
		string tc;
		public AdminAnasayfa()
		{
			InitializeComponent();
		}
		SqlConnection baglanti = new SqlConnection(@"Data Source=" + Connection.connectionName + ";Initial Catalog=afetzedeyonetimdb;Integrated Security=True");
		

		private void button1_Click_1(object sender, EventArgs e)
		{
			this.Hide();
			AdminGiris kullaniciGiris = new AdminGiris();
			kullaniciGiris.ShowDialog();
			this.Close();
		}

		private void AdminAnasayfa_Load_1(object sender, EventArgs e)
		{
			DataTable dataTable = new DataTable();
			baglanti.Open();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from afetzedes where bulundu is  null", baglanti); //buraya sadece bulundu biti null olanları çek dedim, en son bulduğumu 1e set edeceğim "Buruk
			sqlDataAdapter.Fill(dataTable);
			dataGridView1.DataSource = dataTable;
			dataGridView1.RowTemplate.Resizable = DataGridViewTriState.True;

			using (SqlCommand command = new SqlCommand(query1, baglanti))
			{
				using (SqlDataReader reader = command.ExecuteReader())
				{
					while (reader.Read())
					{
						byte[] imageBytes = (byte[])reader["resim"]; // Resim verisini byte dizisine alın
						MemoryStream stream = new MemoryStream(imageBytes); // Byte dizisini MemoryStream'e yükleyin
						Image<Gray, byte> image = new Image<Gray, byte>(new Bitmap(stream)); // MemoryStream'deki veriden Image<Gray, byte> oluşturun
						trainingImages.Add(image); // Resmi List<Image<Gray, byte>> listesine ekleyin
					}
				}
			}
			using (SqlCommand command2 = new SqlCommand(query2, baglanti))
			{
				using (SqlDataReader reader = command2.ExecuteReader())
				{
					while (reader.Read())
					{
						string deger = reader.GetString(0); // Sütun indeksine göre değeri alın (0 ilk sütunu temsil eder)
						labels.Add(deger);
					}
				}
			}

			baglanti.Close();
		}

        private void button3_Click(object sender, EventArgs e)
        {

			MailGonderForm(name);
        }

		private void MailGonderForm(string foundedName)
		{
			this.Hide();
			MailGonderme mailGonderme = new MailGonderme(foundedName);
			mailGonderme.ShowDialog();
			this.Close();
		}

		private void button2_Click_1(object sender, EventArgs e)
		{
			camera = new Capture();
			camera.QueryFrame();
			Application.Idle += new EventHandler(FrameProcedure);
			button2.Visible = false;
		}

		private void FrameProcedure(object sender, EventArgs e)
		{
			
			Frame = camera.QueryFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
			grayFace = Frame.Convert<Gray, Byte>();
			MCvAvgComp[][] facesDetectedNow = grayFace.DetectHaarCascade(faceDetected, 1.2, 10, Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(20, 20));
			foreach (MCvAvgComp f in facesDetectedNow[0])
			{
				result = Frame.Copy(f.rect).Convert<Gray, Byte>().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
				Frame.Draw(f.rect, new Bgr(Color.Green), 3);
				if (trainingImages.ToArray().Length != 0)
				{
					MCvTermCriteria termCriterias = new MCvTermCriteria(labels.Count, 0.001);
					EigenObjectRecognizer recognizer = new EigenObjectRecognizer(trainingImages.ToArray(), labels.ToArray(), 1500, ref termCriterias);
					name = recognizer.Recognize(result);
					Frame.Draw(name, ref font, new Point(f.rect.X - 2, f.rect.Y - 2), new Bgr(Color.Red));
					if (name != ""&&flag==false)
					{
						flag = true;
						MailGonderForm(name);		
						

					}

				}

            }
			
			camerabox.Image = Frame;	
			
		}
	}
}
