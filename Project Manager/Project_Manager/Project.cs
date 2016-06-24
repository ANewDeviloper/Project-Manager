/*
 * Created by SharpDevelop.
 * User: Timo
 * Date: 15.06.2016
 * Time: 23:34
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Project_Manager
{
	/// <summary>
	/// The data of a Project can be found here.
	/// </summary>
	public struct Project
	{
		//GInfo
		
		public string name;
		public string describition;
		string stepList;
		string currentStep;
		DateTime creationDate;
		DateTime lastCommitDate;
		string githubLink;
		
		//Paths
		
		
		
		//Methods
		public void reset(){
			this.name = "";
		}
	}
}
