using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	internal class Calculate
	{
        private int Height { get; set; }
		private int Weight { get; set; }
		private double BMI { get; set; }
		public Calculate() { }
		public int? GetHeightValue(TextBox ctrl,string value)//int?代表值可以為null
		{
			ErrorProvider errorProvider = new ErrorProvider();
			if (string.IsNullOrEmpty(value))//未填任何值
			{
				errorProvider.SetError(ctrl, "身高必填");
				return null;
			}
			else if (int.TryParse(value, out int num) == false)//亂填，ex"160A"
			{
				errorProvider.SetError(ctrl, "身高必為正整數");
				return null;
			}
			else if (num <= 0)//填到負數，ex"-170"
			{
				errorProvider.SetError(ctrl, "身高必為正整數");
				return null;
			}
			else {
				errorProvider.SetError(ctrl, string.Empty);
				Height = num;
				return num; }
		}
		public int? GetWeightValue(TextBox ctrl, string value)
		{

			ErrorProvider errorProvider = new ErrorProvider();
			if (string.IsNullOrEmpty(value))
			{
				errorProvider.SetError(ctrl, "體重必填");
				return null;
			}
			if (int.TryParse(value, out int num) == false)
			{
				errorProvider.SetError(ctrl, "體重必為正整數");
				return null;
			}
			if (num <= 0)
			{
				errorProvider.SetError(ctrl, "體重必為正整數");
				return null;
			}
			errorProvider.SetError(ctrl, string.Empty);
			Weight = num;
			return num;
		}
		public double CalBMI()
		{
			//BMI=Weight(kg)/ (Height(m)*Height(m))
			double bmi = Weight / Math.Pow(Height / 100d, 2);
			bmi = Math.Round(bmi, 1, MidpointRounding.AwayFromZero);
			//bmiLabel.Text = bmi.ToString("f1");//顯示至小數點後一位
			BMI = bmi;
			return bmi;
		}
		public string DisplayNote()
		{
			string note = string.Empty;
			if (BMI < 18.5)
			{
				note = "體重過輕";
			}
			else if (BMI < 24)
			{
				note = "正常";
			}
			else if (BMI < 27)
			{
				note = "過重";
			}
			else if (BMI < 30)
			{
				note = "輕度肥胖";
			}
			else if (BMI < 35)
			{
				note = "中度肥胖";
			}
			else
			{
				note = "重度肥胖";
			}
			return note;
		}
	}
}
