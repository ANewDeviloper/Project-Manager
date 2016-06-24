/*
 * Created by SharpDevelop.
 * User: Timo
 * Date: 16.06.2016
 * Time: 23:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Project_Manager
{
	/// <summary>
	/// Form to get the Ginfo of a new Project.
	/// </summary>
	public partial class Project_Creator : Form
	{
		public Project_Creator()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Buttoncreator_OKClick(object sender, EventArgs e)
		{
			if(Textboxcreator_Name.Text.Equals("")){
				
			}
			else
			{
				//Getting the GInfo.
				Project_Transmitter.setProjectTransmitter(Textboxcreator_Name.Text);
				this.DialogResult = DialogResult.OK;
			}
			
		}
		
		void Buttoncreator_CancelClick(object sender, EventArgs e)
		{
		this.DialogResult = DialogResult.Cancel;
		}

	}
}
