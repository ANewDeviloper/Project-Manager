/*
 * Created by SharpDevelop.
 * User: Timo
 * Date: 15.06.2016
 * Time: 00:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Project_Manager
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public static Shelf Projects = new Shelf();
		
		
		Project_Creator projectCreatorForm = new Project_Creator();
		
		public MainForm()
		{
			InitializeComponent();
			Projects.getExsitingProjects();
			foreach(Project p in Projects.getContent()){
				Projectmain_Select.Items.Add(p.name);
			}
			Projectmain_Select.Items.Remove("");
		}
		
		//Button Region Begin
		
		void Button_EnterClick(object sender, EventArgs e)
		{
			
		}
		void Button_NewClick(object sender, EventArgs e)
		{
			//1. Get Project Data
			//2. Create Project Folder/Entry
			//3. Clean Up
			
			if(projectCreatorForm.ShowDialog() == DialogResult.OK){
				FileStream fs = new FileStream(@"Projects.Txt", FileMode.Append, FileAccess.Write, FileShare.None);
				StreamWriter fp = new StreamWriter(fs);
				Projects.addProject(Project_Transmitter.getProjectTransmitter());
				Projectmain_Select.Items.Add(Project_Transmitter.getProjectTransmitter().name);
				fp.WriteLine("");
				fp.Write(Project_Transmitter.getProjectTransmitter().name + ";");
				Directory.CreateDirectory(@Project_Transmitter.getProjectTransmitter().name);
				fp.Close();
				fs.Close();
				Project_Transmitter.resetProjectTransmitter();
				
			}
			
		}
		void Button_DeleteClick(object sender, EventArgs e)
		{
			//Does not work yet.
			string toDelete = Projectmain_Select.Text;
			FileStream fs = new FileStream(@"Projects.Txt", FileMode.Open, FileAccess.ReadWrite, FileShare.None);
			StreamWriter writer = new StreamWriter(fs);
			StreamReader reader = new StreamReader(fs);
			
			string Content = reader.ReadToEnd();
			string[] Projects = Content.Split(';');
			
			for(int i = 1; i < Projects.Length; i++){
				if(Projects[i].Equals(";" + toDelete)){
					
				}
				else{
					writer.Write(Projects[i]);
				}
			}
			Projectmain_Select.Items.Remove(toDelete);
			Projectmain_Select.Text = "";
			writer.Close();
			reader.Close();
			fs.Close();
		}
		//Button Region End
		void FillGInfo(Project project){
			Label_Projectname.Text = project.name;
		}
	}
}
