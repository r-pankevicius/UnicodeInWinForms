using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnicodeInWinForms
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			// You can't change CompatibleTextRenderingDefault for Application after container has called it once. You'll get:
			// System.InvalidOperationException:
			// SetCompatibleTextRenderingDefault must be called before the first IWin32Window object is created in the application.
			// Application.SetCompatibleTextRenderingDefault(false);

			InitializeComponent();
		}
	}
}
