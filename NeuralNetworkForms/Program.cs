﻿// -------------------------------------------------------------------------------------------------------------
//  Program.cs created by DEP on 2018/12/01
// -------------------------------------------------------------------------------------------------------------

using System;
using System.Windows.Forms;

namespace NeuralNetworkForms
{
	internal static class Program
	{
		/// <summary>
		///     Главная точка входа для приложения.
		/// </summary>
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			var form1 = new Form1();
			Application.Run(new Form2(form1));
		}
	}
}