using System;
using System.Windows.Forms;

namespace NeuralNetworkForms
{
	public partial class Form3 : Form
	{
		public readonly Form1 _form1;
		public readonly Form2 _form2;
		public readonly Form4 _form4;
		public readonly Form5 _form5;

		public Form3(Form1 form1, Form2 form2)
		{
			_form1 = form1;
			_form2 = form2;
			_form4 = new Form4(this);
			_form5 = new Form5();
			InitializeComponent();
			AddOwnedForm(_form4);
			AddOwnedForm(_form5);
		}

		private void button3_Click(object sender, EventArgs e)
		{
		}

		private void label1_MouseEnter(object sender, EventArgs e)
		{
		}

		private void label1_Click(object sender, EventArgs e)
		{
			_form4.Show();
			Hide();
		}

		private void button1_Click(object sender, EventArgs e)
		{
		}

		private void label3_Click(object sender, EventArgs e)
		{
			_form1.Show();
			Hide();
		}

		private void Form3_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}

		private void Form3_Load(object sender, EventArgs e)
		{
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			_form2.Show();
			Hide();
		}

		private void label2_Click(object sender, EventArgs e)
		{
			_form5.Show();
			Hide();
		}
	}
}