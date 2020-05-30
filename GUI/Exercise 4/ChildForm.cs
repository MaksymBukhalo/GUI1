using System;
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
	public partial class ChildForm : Form
	{
		public ChildForm()
		{
			InitializeComponent();
		}

		private void ChildForm_Load(object sender, EventArgs e)
		{

		}

		private void ToggleMenuItem_Click_1(object sender, EventArgs e)
		{
            if (ToggleMenuItem.Checked)
            {
                ToggleMenuItem.Checked = false;
                ChildTextBox.ForeColor = Color.Black;
            }
            else
            {
                ToggleMenuItem.Checked = true;
                ChildTextBox.ForeColor = Color.Blue;
            }
        }
	}
}
