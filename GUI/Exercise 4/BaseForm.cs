﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Exercise_4
{
	public partial class BaseForm : Form
	{
		private int openedDocuments;
		public BaseForm()
		{
			InitializeComponent();
		}

		private void NewMenuItem_Click(object sender, EventArgs e)
		{
			var newChild = new ChildForm
			{
				MdiParent = this
			};
			newChild.Text = $"{newChild.Text}{++openedDocuments}";
			newChild.Show();
		}

		private void ExitMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void WindowCascadeMenuItem_Click(object sender, EventArgs e)
		{
			LayoutMdi(MdiLayout.Cascade);
		}

		private void WindowTileMenuItem_Click(object sender, EventArgs e)
		{
			LayoutMdi(MdiLayout.TileHorizontal);
		}

		private void BaseForm_Load(object sender, EventArgs e)
		{

		}

		private void FileMenuItem_Click(object sender, EventArgs e)
		{

		}
	}
}
