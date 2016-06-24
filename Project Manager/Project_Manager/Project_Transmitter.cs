/*
 * Created by SharpDevelop.
 * User: Timo
 * Date: 21.06.2016
 * Time: 00:14
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Project_Manager
{
	/// <summary>
	/// Class for the Communication between the Creator-Form and the Main-Form
	/// </summary>
	public static class Project_Transmitter
	{
		public static Project Transmitter;
		
		public static Project getProjectTransmitter(){
			return Transmitter;
		}
		public static void setProjectTransmitter(String Name){
			Transmitter.name = Name;
		}
		
		public static void resetProjectTransmitter(){
			Transmitter.reset();
		}
		
	}
}
