using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie1_Forms_PM01_N1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				double x = double.Parse(textBox1.Text);
				double y = double.Parse(textBox2.Text);

				if ((x > 50 || x < -50) & (y > 25 || y < -25))
				{
					textBox3.Text = string.Format("Точка находится вне области");
					return;
				}
				else if ((x >= -50 & x <= 50) & (y == 25 || y == -25))
				{
					textBox3.Text = string.Format("Точка находится на границе области");
					return;
				}
				else if ((y >= -25 & y <= 25) & (x == 50 || x == -50))
				{
					textBox3.Text = string.Format("Точка находится на границе области");
					return;
				}
				else if ((x < 50 & x > -50) & (y < 25 & y > -25))
				{
					textBox3.Text = string.Format("Точка находится внутри области");
					return;
				}
			}
			catch
			{
				textBox3.Text = string.Format("Некорректный ввод данных!");
				return;
			}
		}
	}
}
