using GUI.Exercise_4;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Exercise1 exercise1 = new Exercise1();
			exercise1.ShowDialog();
		}
		private void button2_Click(object sender, EventArgs e)
		{
			Exercise2 exercise2 = new Exercise2();
			exercise2.ShowDialog();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Exercise3 exercise3 = new Exercise3();
			exercise3.ShowDialog();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			BaseForm baseForm = new BaseForm();
			baseForm.ShowDialog();
		}
	}
}
