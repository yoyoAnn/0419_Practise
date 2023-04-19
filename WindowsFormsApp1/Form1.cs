using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			EmptyResult();
		}
		private void EmptyResult()
		{
			bmiLabel.Text = string.Empty;
			noteLabel.Text = string.Empty;
		}

		private void calcButton_Click(object sender, EventArgs e)
		{
			EmptyResult();
			TextBox ctrl = heightTextBox;
			string value = heightTextBox.Text;
			TextBox ctrl2 = weightTextBox;
			string value2 = weightTextBox.Text;

			Calculate calculate = new Calculate();
			int? height = calculate.GetHeightValue(ctrl, value);
			int? weight = calculate.GetWeightValue(ctrl2, value2);

			if (height.HasValue == false || weight.HasValue == false)
			{
				EmptyResult();
				return;
			}
			bmiLabel.Text = calculate.CalBMI().ToString("f1");
			noteLabel.Text = calculate.DisplayNote();
		}
		
	}
}
