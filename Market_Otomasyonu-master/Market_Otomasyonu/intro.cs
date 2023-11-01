using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market_Otomasyonu.UI
{
	public partial class intro : Form
	{
		public intro()
		{
			InitializeComponent();
		}

		private void intro_Load(object sender, EventArgs e)
		{
			tmrIntro.Interval = 50;
			pgrBar.Minimum = 0;
			pgrBar.Maximum = 100;
			pgrBar.Step = 1;
			pgrBar.ForeColor = System.Drawing.Color.Orange;
			tmrIntro.Start();
		}

		private void tmrIntro_Tick(object sender, EventArgs e)
		{
			if (pgrBar.Value < pgrBar.Maximum)
			{
				pgrBar.PerformStep();
			}
			else
			{
				tmrIntro.Stop();
				LoginPage page = new LoginPage();
				page.Show();
				this.Hide();
			}
		}
	}
}
