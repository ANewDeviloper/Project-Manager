/*
 * Created by SharpDevelop.
 * User: Timo
 * Date: 15.06.2016
 * Time: 00:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
// */
using System;
using System.Collections;
using System.Windows.Forms;

namespace Project_Manager
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
		
	}
}
