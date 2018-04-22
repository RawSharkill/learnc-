using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace showpicinform
{
	public partial class btnchoosefile : Form
	{
		public btnchoosefile()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			loadpicture();
		}
		private void loadpicture()//传入图片
		{
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				//MessageBox.Show(openFileDialog1.FileName);
				pictureBox1.ImageLocation = openFileDialog1.FileName;
			}
			else
				MessageBox.Show("User canceled");
		}
		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}
	}
}
