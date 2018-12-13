using System;
using System.Windows.Forms;

namespace NeuralNetworkForms
{
	public partial class Form5 : Form
	{
		private readonly Form3 _form3;

		private int n, nMain;

		public Form5(Form3 form3)
		{
			_form3 = form3;

			InitializeComponent();

			var path = Application.StartupPath + "\\Photo\\";
			p1.Load(path + "//p1//1.jpg");
			label1.Text = "Порівняння обробки фільтром та мережею";
			p2.Load(path + "//p2//1.jpg");
		}

		private void LoadPic()
		{
			string st;
			st = nMain + ".jpg";
			var path = Application.StartupPath + "\\Photo\\";
			p1.Load(path + "//p1//" + st);
			p2.Load(path + "//p2//" + st);
		}

		private void Form5_Load(object sender, EventArgs e)
		{
			nMain = 3;
			n = 1;
			var path = Application.StartupPath;
			LoadPic();
		}

		private void a1_Click(object sender, EventArgs e)
		{
			var path = Application.StartupPath;
			nMain = n;
			p1.Load(path + nMain + ".jpg");
			p2.Load(path + nMain + ".jpg");
			if (nMain < 4)
				label1.Text = "Порівняння обробки фільтрами та мережами";
			else
				label1.Text = "Імітація авторського стилю";
		}

		private void a2_Click(object sender, EventArgs e)
		{
			var path = Application.StartupPath + "\\Photo\\";
			nMain = n + 1;
			p1.Load(path + nMain + ".jpg");
			p2.Load(path + nMain + ".jpg");
			if (nMain < 4)
				label1.Text = "Порівняння обробки фільтрами та мережами";
			else
				label1.Text = "Імітація авторського стилю";
		}

		private void a2_Click_1(object sender, EventArgs e)
		{
			var path = Application.StartupPath + "\\Photo\\";
			nMain = n;
			p1.Load(path + "//p1//" + nMain + ".jpg");
			p2.Load(path + "//p2//" + nMain + ".jpg");
			if (nMain < 4)
				label1.Text = "Порівняння обробки фільтрами та мережами";
			else
				label1.Text = "Імітація авторського стилю";
		}

		private void pictureBox5_Click(object sender, EventArgs e)
		{
			_form3.Show();
			Hide();
		}

		private void pictureBox4_Click(object sender, EventArgs e)
		{
			var path = Application.StartupPath + "\\Photo\\";
			nMain = n + 1;
			p1.Load(path + "//p1//" + nMain + ".jpg");
			p2.Load(path + "//p2//" + nMain + ".jpg");
			if (nMain < 4)
				label1.Text = "Порівняння обробки фільтрами та мережами";
			else
				label1.Text = "Імітація авторського стилю";
		}
	}
}