using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_Otomasyonu.UI.Extensions
{
	public static class Helper
	{
		public static void Clean(Control.ControlCollection controls)
		{
			foreach (Control control in controls)
			{
				if (control is TextBox textBox)
				{
					textBox.Text = string.Empty;
				}
				else if (control is RichTextBox rich)
				{
					rich.Text = string.Empty;
				}
				else if (control is MaskedTextBox mask)
				{
					mask.Text = string.Empty;
				}
				else if (control is ComboBox comboBox)
				{
					comboBox.SelectedIndex = -1;
				}
				else if (control is CheckBox checkBox)
				{
					checkBox.Checked = false;
				}
				else if (control is RadioButton radioButton)
				{
					if (radioButton.Name == "rdErkek")
					{
						radioButton.Checked = true;
					}
					else { radioButton.Checked = false; }
				}
				else if (control is NumericUpDown nud)
				{
					nud.Value = 0;
				}

				else if (control is ListBox list)
				{
					list.Items.Clear();
				}
				else if (control is GroupBox groupBox)
				{
					Clean(groupBox.Controls);
				}
				else if (control is FlowLayoutPanel panel)
				{
					Clean(panel.Controls);
				}
			}
		}
		public static bool CheckArea(Control.ControlCollection controls)
		{
			bool bosAlanVar = false;

			foreach (Control control in controls)
			{
				if (control is TextBox textBox && string.IsNullOrEmpty(textBox.Text))
				{
					bosAlanVar = true;
					break;
				}
				else if (control is RichTextBox rich && string.IsNullOrEmpty(rich.Text))
				{
					bosAlanVar = true;
					break;
				}

				else if (control is ComboBox comboBox && comboBox.SelectedIndex == -1)
				{
					bosAlanVar = true;
					break;
				}
				else if (control is CheckBox checkBox && !checkBox.Checked)
				{
					bosAlanVar = true;
					break;
				}
				else if (control is RadioButton radioButton && !radioButton.Checked)
				{
					bosAlanVar = true;
					break;
				}
				else if (control is NumericUpDown nud && nud.Value == default)
				{
					bosAlanVar = true;
					break;
				}
				else if (control is ListBox list && list.Items.Count == 0)
				{
					bosAlanVar = true;
					break;
				}
				else if (control is GroupBox groupBox)
				{
					if (CheckArea(groupBox.Controls))
					{
						bosAlanVar = true;
						break;
					}
				}

			}

			return bosAlanVar;
		}

		public static bool CheckAreaAddProduct(Control.ControlCollection controls)
		{
			bool bosAlanVar = false;
			foreach (Control control in controls)
			{
				if (control is TextBox textBox && string.IsNullOrEmpty(textBox.Text))
				{
					bosAlanVar = true;
					break;
				}
				else if (control is NumericUpDown nud && nud.Value == default)
				{
					bosAlanVar = true;
					break;
				}
				else if (control is ComboBox comboBox && comboBox.SelectedIndex == -1)
				{
					bosAlanVar = true;
					break;
				}
				else if (control is GroupBox groupBox)
				{
					if (CheckAreaAddProduct(groupBox.Controls))
					{
						bosAlanVar = true;
						break;
					}
				}


			}
			return bosAlanVar;
		}
		public static bool CheckAreaAddUser(Control.ControlCollection controls)
		{
			bool bosAlanVar = false;
			foreach (Control control in controls)
			{
				if (control is TextBox textBox && string.IsNullOrEmpty(textBox.Text))
				{
					bosAlanVar = true;
					break;
				}
				else if (control is ComboBox comboBox && comboBox.SelectedIndex == -1)
				{
					bosAlanVar = true;
					break;
				}
				else if (control is GroupBox groupBox)
				{
					if (CheckAreaAddProduct(groupBox.Controls))
					{
						bosAlanVar = true;
						break;
					}
				}


			}
			return bosAlanVar;
		}

		public static bool AlanlariKontrolEtLogin(Control.ControlCollection controls)
		{
			bool bosAlanVar = false;
			foreach (Control control in controls)
			{
				if (control is TextBox textBox && string.IsNullOrEmpty(textBox.Text))
				{
					bosAlanVar = true;
					break;
				}
				else if (control is GroupBox groupBox)
				{
					if (AlanlariKontrolEtLogin(groupBox.Controls))
					{
						bosAlanVar = true;
						break;
					}
				}
			}

			return bosAlanVar;

		}
	}
}
