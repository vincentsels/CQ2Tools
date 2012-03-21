using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using CQ2Tools.Logic;

namespace CQ2Tools.UI
{
	public partial class FrmTravelCalc : Form
	{
		#region Constructor
		public FrmTravelCalc()
		{
			InitializeComponent();
			TopMost = true;

			// Only activate this when not in debug mode. Crashes otherwise.
			if (!System.Diagnostics.Debugger.IsAttached)
				this.clipboardMonitor1.ClipboardChanged += 
					new System.EventHandler<CQ2Tools.Controls.ClipboardChangedEventArgs>(this.clipboardMonitor1_ClipboardChanged);
		}
		#endregion

		#region External Methods
		[DllImport("User32.dll")]
		public static extern Int32 SetForegroundWindow(int hWnd);
		#endregion

		#region Event Handlers
		private void clipboardMonitor1_ClipboardChanged(object sender, Controls.ClipboardChangedEventArgs e)
		{
			string text = e.DataObject.GetData(typeof(string)).ToString();

			if (CreatureParser.ContainsCreatureInfo(text))
				ucTravelMode1.SetCreatureText(CreatureParser.CleanTravelCreatureList(text));
			else if (ResourceParser.ContainsResourceInfo(text))
				ucTravelMode1.SetResourcesText(ResourceParser.CleanInput(text));
		}
		#endregion
	}
}
