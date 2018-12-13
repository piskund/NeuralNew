using System;
using System.Windows.Forms;

namespace NeuralNetworkForms
{
	public partial class Form2 : Form
	{
		public Form3 _form3;

		public Form2(Form1 form1)
		{
			InitializeComponent();
			_form3 = new Form3(form1, this);
			AddOwnedForm(_form3);
		}

		private void label7_Click(object sender, EventArgs e)
		{
		}

		private void button1_Click(object sender, EventArgs e)
		{
			_form3.Show();
			Hide();
		}

		private void Form2_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}
	}
}