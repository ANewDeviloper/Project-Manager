/*
 * Created by SharpDevelop.
 * User: Timo
 * Date: 20.06.2016
 * Time: 00:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Collections;

namespace Project_Manager
{
	/// <summary>
	/// Class that can hold a list of Objects (Projects, Notes, ...)
	/// </summary>
	public class Shelf
	{
		public Shelf()
		{
		}
		
		
		
		ArrayList ShelfContent = new ArrayList();
		
		public void getExsitingProjects(){
			FileStream fs = new FileStream(@"Projects.Txt", FileMode.Open, FileAccess.Read, FileShare.None);
			StreamReader reader = new StreamReader(fs);
			string Content = reader.ReadToEnd();
			reader.Close();
			string[] Projects = Content.Split(';');
			for(int i = 0; i < Projects.Length; i++){
				Project project = new Project();
				project.name = Projects[i];
				ShelfContent.Add(project);
			}
			fs.Close();
		}
		
		public void addProject(Project project){
			ShelfContent.Add(project);
		}
		
		public ArrayList getContent(){
			return ShelfContent;
		}
	}
}
