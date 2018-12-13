using System;
using System.Windows.Forms;

namespace NeuralNetworkForms
{
	public partial class Form5 : Form
	{
		private readonly Form3 _form3;
		private readonly string _path = Application.StartupPath + "\\Photo\\";

		private int _pictureNumber;

		public Form5(Form3 form3)
		{
			_form3 = form3;
			InitializeComponent();
		}

		private void Form5_Load(object sender, EventArgs e)
		{
			_pictureNumber = 0;
			SetPictures(_pictureNumber);
		}

		private void arrowUp_Click(object sender, EventArgs e)
		{
			if (_pictureNumber < 4)
				_pictureNumber++;

			SetPictures(_pictureNumber);
		}

		private void arrowDown_Click(object sender, EventArgs e)
		{
			if (_pictureNumber > 0)
				_pictureNumber--;

			SetPictures(_pictureNumber);
		}

		private void SetPictures(int pictNumber)
		{
			p1.Load(_path + "//p1//" + pictNumber + ".jpg");
			p2.Load(_path + "//p2//" + pictNumber + ".jpg");
			if (pictNumber < 4)
				label1.Text = "Порівняння обробки фільтрами та мережами";
			else
				label1.Text = "Імітація авторського стилю";
		}

		private void pictureBox5_Click(object sender, EventArgs e)
		{
			_form3.Show();
			Hide();
		}
	}
}