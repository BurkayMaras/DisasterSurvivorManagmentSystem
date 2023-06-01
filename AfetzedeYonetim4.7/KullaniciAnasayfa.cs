using Emgu.CV.Structure;
using Emgu.CV;
using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using Emgu.CV.CvEnum;
using System.Reflection.Emit;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AfetzedeYonetim4._7
{
	public partial class KullaniciAnasayfa : Form
	{
		bool clicked;
		MCvFont font = new MCvFont(Emgu.CV.CvEnum.FONT.CV_FONT_HERSHEY_TRIPLEX, 0.6d, 0.6d);
		List<string> labels = new List<string>();
		Capture camera;
		string imagePath;
		Image<Bgr, Byte> Frame;
		Image<Gray, byte> result;
		Image<Gray, byte> TrainedFace = null;
		Image<Gray, byte> grayFace = null;
		HaarCascade faceDetected = new HaarCascade("haarcascade_frontalface_default.xml");
		int Count;
		List<Image<Gray, byte>> trainingImages = new List<Image<Gray, byte>>();
		string name;
		SqlConnection baglanti = new SqlConnection(@"Data Source=" + Connection.connectionName + ";Initial Catalog=afetzedeyonetimdb;Integrated Security=True");
		public KullaniciAnasayfa()
		{
			InitializeComponent();
		}

		private void ihbarresimEklebtn_Click(object sender, EventArgs e)
		{
			openFileDialog1.Title = "Resim Seç";
			openFileDialog1.Filter = "Jpeg Dosyaları(*.jpeg)|*.jpeg| Jpg Dosyaları(*.jpg)|*.jpg| Png Dosyaları(*.png)|*.png|Bitmap Dosyaları(*.bmp)|*.bmp";
			openFileDialog1.ShowDialog();
			cameraBox2.ImageLocation = openFileDialog1.FileName;
			imagePath = openFileDialog1.FileName;
			ihbarresimText.Text = openFileDialog1.FileName;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (textlerDoluMu())
			{
					Bitmap resizedImage;
				Bitmap originalImage = new Bitmap(100, 100);
				if (clicked)
				{
					
					grayFace = camera.QueryGrayFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
					MCvAvgComp[][] DetectedFaces = grayFace.DetectHaarCascade(faceDetected, 1.2, 10, Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(20, 20));
					foreach (MCvAvgComp f in DetectedFaces[0])
					{
						TrainedFace = Frame.Copy(f.rect).Convert<Gray, byte>();
						break;
					}
					TrainedFace = result.Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
					cameraBox2.Image = TrainedFace;
					originalImage = TrainedFace.ToBitmap();
				}
				else if (ihbarresimText.Text != "")
				{
					FileStream fileStream = new FileStream(imagePath, FileMode.Open, FileAccess.Read);
					BinaryReader binaryReader = new BinaryReader(fileStream);
					byte[] resim = binaryReader.ReadBytes((int)fileStream.Length);
					binaryReader.Close();
					fileStream.Close();
					originalImage = new Bitmap(imagePath);
				}
				else MessageBox.Show("Afetzede resim olmadan eklenecek!");
					

					// Resmi yeniden boyutlandırın

					resizedImage = new Bitmap(originalImage, new Size(100, 100));

					// Yeniden boyutlandırılmış resmi byte dizisine dönüştürün
					MemoryStream memoryStream = new MemoryStream();
					resizedImage.Save(memoryStream, ImageFormat.Jpeg);
					byte[] yenidenBoyutlandirilmisResim = memoryStream.ToArray();
					memoryStream.Close();

					baglanti.Open();
					string sorgu = "INSERT INTO afetzedes(isim, soyisim, tc, eposta, adres, resim) VALUES (@isim, @soyisim, @tc, @eposta, @adres, @resim)";
					SqlCommand komut = new SqlCommand(sorgu, baglanti);
					komut.Parameters.AddWithValue("@isim", ihbarisimText.Text);
					komut.Parameters.AddWithValue("@soyisim", ihbarsoyisimText.Text);
					komut.Parameters.AddWithValue("@tc", ihbartcText.Text);
					komut.Parameters.AddWithValue("@eposta", ihbarepostaText.Text + comboBox1.Text);
					komut.Parameters.AddWithValue("@adres", ihbaradresText.Text);
					komut.Parameters.Add("@resim", SqlDbType.Image, yenidenBoyutlandirilmisResim.Length).Value = yenidenBoyutlandirilmisResim;
					komut.ExecuteNonQuery();
					baglanti.Close();

					MessageBox.Show("Kayıt Eklendi!");
				foreach (Control control in this.Controls)
				{
					if (control is System.Windows.Forms.TextBox textBox && textBox.ReadOnly == false)
					{
						textBox.Clear();
					}
				}


			}
			else
				MessageBox.Show("Lütfen bütün bilgileri eksiksiz doldurun!");

		}
		private bool textlerDoluMu()
		{
			foreach (Control control in this.Controls)
			{
				if (control is System.Windows.Forms.TextBox textBox && textBox.ReadOnly==false)
				{
					if (string.IsNullOrEmpty(textBox.Text))
					{
						return false;
						
					}
				}
			}
			return true;
		}
		private void button3_Click(object sender, EventArgs e)
		{
			clicked = true;
			ihbarresimEklebtn.Enabled = false;
			button3.Enabled = false;
			camera = new Capture();
			camera.QueryFrame();
			Application.Idle += new EventHandler(FrameProcedure);
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
					MCvTermCriteria termCriterias = new MCvTermCriteria(Count, 0.001);
					EigenObjectRecognizer recognizer = new EigenObjectRecognizer(trainingImages.ToArray(), labels.ToArray(), 1500, ref termCriterias);
					name = recognizer.Recognize(result);
					Frame.Draw(name, ref font, new Point(f.rect.X - 2, f.rect.Y - 2), new Bgr(Color.Red));
				}

				
			}
			cameraBox2.Image = Frame;
			
			
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Hide();
			KullaniciGiris kullaniciGiris = new KullaniciGiris();
			kullaniciGiris.ShowDialog();
			this.Close();
		}

		private void ihbartcText_TextChanged(object sender, EventArgs e)
		{
			if (ihbartcText.Text.Length > 11) // 11den fazla karakter girilirse, son 11 karakteri al
			{
				ihbartcText.Text = ihbartcText.Text.Substring(0, 11);
				ihbartcText.SelectionStart = 11; // Cursor'ı sona taşır
			}
		}

		private void ihbarisimText_TextChanged(object sender, EventArgs e)
		{
			if (ihbarisimText.Text.Length > 50) 
			{
				ihbarisimText.Text = ihbarisimText.Text.Substring(0, 11);
				ihbarisimText.SelectionStart = 50; // Cursor'ı sona taşır
			}
		}

		private void ihbarsoyisimText_TextChanged(object sender, EventArgs e)
		{
			if (ihbarsoyisimText.Text.Length > 50) 
			{
				ihbarsoyisimText.Text = ihbarsoyisimText.Text.Substring(0, 11);
				ihbarsoyisimText.SelectionStart = 50; // Cursor'ı sona taşır
			}
		}

		private void ihbaradresText_TextChanged(object sender, EventArgs e)
		{
			if (ihbaradresText.Text.Length > 50) 
			{
				ihbaradresText.Text = ihbaradresText.Text.Substring(0, 11);
				ihbaradresText.SelectionStart = 50; // Cursor'ı sona taşır
			}
		}
	}
}
