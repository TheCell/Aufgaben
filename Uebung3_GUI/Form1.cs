using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uebung3_GUI
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			
			// nicht per Property als Methode gesetzt, deshalb per Code
			buttonOk2.Click += ButtonOK2Click;
			btnClear.Click += buttonClearClick;
			numericUpDown1.ValueChanged += numericUpDownChange;

			// std behaviour
			textBox1.Text = numericUpDown1.Value.ToString();
			checkboxCheckNegativeValue(numericUpDown1.Value);

			// Auf Solution properties, Output Type Console damit
			// console Fenster auch eingeblendet wird
			Console.WriteLine("Console output");
		}

		private void ButtonOK2Click(object sender, EventArgs e)
		{
			MessageBox.Show(
				"Button 2 clicked",
				"Info",
				MessageBoxButtons.OK,
				MessageBoxIcon.Information);
		}

		private void ButtonOKClick(object sender, EventArgs e)
		{
			MessageBox.Show(
				"Button clicked",
				"Info",
				MessageBoxButtons.OK,
				MessageBoxIcon.Information);
		}

		private void buttonClearClick(object sender, EventArgs e)
		{
			numericUpDown1.Value = 0;
		}

		private void numericUpDownChange(object sender, EventArgs e)
		{
			textBox1.Text = Math.Abs(numericUpDown1.Value).ToString();
			checkboxCheckNegativeValue(numericUpDown1.Value);
		}

		private void checkboxCheckNegativeValue(decimal number)
		{
			if (number < 0)
			{
				checkBox1.Checked = true;
			}
			else
			{
				checkBox1.Checked = false;
			}
		}
	}
}
