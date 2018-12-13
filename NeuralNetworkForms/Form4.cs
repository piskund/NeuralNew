using System;
using System.Windows.Forms;

namespace NeuralNetworkForms
{
	public partial class Form4 : Form
	{
		private readonly Form3 _form3;

		public Form4(Form3 form3)
		{
			_form3 = form3;
			InitializeComponent();
		}

		private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
		{
			var path = Application.StartupPath;
			var st1 = treeView1.SelectedNode.Text;
			var sqq = treeView1.SelectedNode.Index;
			if (st1 == "Станкова графіка") webBrowser1.Navigate(path + "\\texts\\0.htm");
			if (st1 == "Книжкова графіка") webBrowser1.Navigate(path + "\\texts\\1.html");
			if (st1 == "Журнальна та газетна графіка") webBrowser1.Navigate(path + "\\texts\\2.html");
			if (st1 == "Прикладна та промислова графіка") webBrowser1.Navigate(path + "\\texts\\3.html");
			if (st1 == "Плакат") webBrowser1.Navigate(path + "\\texts\\4.html");
			if (st1 == "Комп'ютерна графіка") webBrowser1.Navigate(path + "\\texts\\5.html");
		}

		private void Form4_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			_form3.Show();
			Hide();
		}
	}
}