using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CQ2Tools.Logic;
using System.Threading;
using System.Runtime.InteropServices;

namespace CQ2Tools.UI
{
	public partial class FrmCQ2Tools : Form
	{
		Size _initialSize;

		#region Constructor
		public FrmCQ2Tools()
		{
			InitializeComponent();
		}
		#endregion

		#region External Methods
		[DllImport("User32.dll")]
		public static extern Int32 SetForegroundWindow(int hWnd);
		#endregion

		#region Event Handlers
		private void clipboardMonitor1_ClipboardChanged(object sender, Controls.ClipboardChangedEventArgs e)
		{
			if (!ucTravelMode1.Visible)
			{
				if (!chkAutoReadClipboard.Checked) return;

				string text = e.DataObject.GetData(typeof(string)).ToString();

				if (chkInterpretClipboard.Checked)
				{
					if (CreatureParser.ContainsCreatureInfo(text) && text.Length > 200)
						tabControl.SelectTab(tabSimpleTravelCalc);
					else if (ResourceParser.ContainsResourceInfo(text))
						tabControl.SelectTab(tabTravelIncomeCalculator);

					if (chkSetFocusAfterCopy.Checked &&
						(CreatureParser.ContainsCreatureInfo(text) ||
						ResourceParser.ContainsResourceInfo(text)))
					{
						this.TopMost = true;
						this.BringToFront();
						this.Focus();
						this.Activate();
						this.TopMost = false;
					}
				}

				if (tabControl.SelectedTab == tabSimpleCalc)
				{
					if (CreatureParser.ContainsCreatureInfo(text))
						ucSimpleCalc1.SetText(CreatureParser.CleanInput(text));
				}
				else if (tabControl.SelectedTab == tabSimpleTravelCalc)
				{
					if (CreatureParser.ContainsCreatureInfo(text))
						ucSimpleTravelCalc1.SetText(CreatureParser.CleanTravelCreatureList(text));
				}
				else if (tabControl.SelectedTab == tabTravelIncomeCalculator)
				{
					if (ResourceParser.ContainsResourceInfo(text))
						ucTravelIncomeCalculator1.SetText(ResourceParser.CleanInput(text));
				}
			}
			else
			{
				string text = e.DataObject.GetData(typeof(string)).ToString();

				if (CreatureParser.ContainsCreatureInfo(text))
					ucTravelMode1.SetCreatureText(CreatureParser.CleanTravelCreatureList(text));
				else if (ResourceParser.ContainsResourceInfo(text))
					ucTravelMode1.SetResourcesText(ResourceParser.CleanInput(text));
			}
		}

		private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			grpOptions.Visible = !grpOptions.Visible;
		}

		private void toggleTravelmodeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			tabControl.Visible = !tabControl.Visible;
			ucTravelMode1.Visible = !ucTravelMode1.Visible;
			TopMost = false;

			if (ucTravelMode1.Visible)
			{
				_initialSize = this.Size;
				this.Size = new Size(ucTravelMode1.MinimumSize.Width + 20, ucTravelMode1.MinimumSize.Height + 60);
				TopMost = true;
			}
			else
				this.Size = _initialSize;
		}
		#endregion
	}
}
