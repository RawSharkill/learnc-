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
		private int counter = 0;
		private void button1_Click(object sender, EventArgs e)
		{
			this.counter++;
			if (counter < 10)
				textBox1.Text = counter.ToString();
			else
				textBox1.Text = "i love you ";

		}
		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
