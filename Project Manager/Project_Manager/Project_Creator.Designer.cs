/*
 * Created by SharpDevelop.
 * User: Timo
 * Date: 16.06.2016
 * Time: 23:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Project_Manager
{
	partial class Project_Creator
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label Titlelabelcreator_CreateYProject;
		private System.Windows.Forms.GroupBox Containercreator_GInfo;
		private System.Windows.Forms.TextBox Textboxcreator_Name;
		private System.Windows.Forms.Label Titlelabelcreator_Name;
		private System.Windows.Forms.Button Buttoncreator_Cancel;
		private System.Windows.Forms.Button Buttoncreator_OK;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.Titlelabelcreator_CreateYProject = new System.Windows.Forms.Label();
			this.Containercreator_GInfo = new System.Windows.Forms.GroupBox();
			this.Titlelabelcreator_Name = new System.Windows.Forms.Label();
			this.Textboxcreator_Name = new System.Windows.Forms.TextBox();
			this.Buttoncreator_Cancel = new System.Windows.Forms.Button();
			this.Buttoncreator_OK = new System.Windows.Forms.Button();
			this.Containercreator_GInfo.SuspendLayout();
			this.SuspendLayout();
			// 
			// Titlelabelcreator_CreateYProject
			// 
			this.Titlelabelcreator_CreateYProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Titlelabelcreator_CreateYProject.Location = new System.Drawing.Point(13, 13);
			this.Titlelabelcreator_CreateYProject.Name = "Titlelabelcreator_CreateYProject";
			this.Titlelabelcreator_CreateYProject.Size = new System.Drawing.Size(210, 30);
			this.Titlelabelcreator_CreateYProject.TabIndex = 1;
			this.Titlelabelcreator_CreateYProject.Text = "Create your Project:";
			// 
			// Containercreator_GInfo
			// 
			this.Containercreator_GInfo.Controls.Add(this.Titlelabelcreator_Name);
			this.Containercreator_GInfo.Controls.Add(this.Textboxcreator_Name);
			this.Containercreator_GInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Containercreator_GInfo.Location = new System.Drawing.Point(13, 46);
			this.Containercreator_GInfo.Name = "Containercreator_GInfo";
			this.Containercreator_GInfo.Size = new System.Drawing.Size(370, 69);
			this.Containercreator_GInfo.TabIndex = 3;
			this.Containercreator_GInfo.TabStop = false;
			this.Containercreator_GInfo.Text = "General Informations";
			// 
			// Titlelabelcreator_Name
			// 
			this.Titlelabelcreator_Name.Location = new System.Drawing.Point(7, 25);
			this.Titlelabelcreator_Name.Name = "Titlelabelcreator_Name";
			this.Titlelabelcreator_Name.Size = new System.Drawing.Size(122, 26);
			this.Titlelabelcreator_Name.TabIndex = 25;
			this.Titlelabelcreator_Name.Text = "Name:";
			this.Titlelabelcreator_Name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Textboxcreator_Name
			// 
			this.Textboxcreator_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Textboxcreator_Name.Location = new System.Drawing.Point(135, 25);
			this.Textboxcreator_Name.Name = "Textboxcreator_Name";
			this.Textboxcreator_Name.Size = new System.Drawing.Size(229, 26);
			this.Textboxcreator_Name.TabIndex = 24;
			// 
			// Buttoncreator_Cancel
			// 
			this.Buttoncreator_Cancel.Location = new System.Drawing.Point(13, 126);
			this.Buttoncreator_Cancel.Name = "Buttoncreator_Cancel";
			this.Buttoncreator_Cancel.Size = new System.Drawing.Size(146, 23);
			this.Buttoncreator_Cancel.TabIndex = 4;
			this.Buttoncreator_Cancel.Text = "Cancel";
			this.Buttoncreator_Cancel.UseVisualStyleBackColor = true;
			this.Buttoncreator_Cancel.Click += new System.EventHandler(this.Buttoncreator_CancelClick);
			// 
			// Buttoncreator_OK
			// 
			this.Buttoncreator_OK.Location = new System.Drawing.Point(196, 126);
			this.Buttoncreator_OK.Name = "Buttoncreator_OK";
			this.Buttoncreator_OK.Size = new System.Drawing.Size(170, 23);
			this.Buttoncreator_OK.TabIndex = 5;
			this.Buttoncreator_OK.Text = "OK";
			this.Buttoncreator_OK.UseVisualStyleBackColor = true;
			this.Buttoncreator_OK.Click += new System.EventHandler(this.Buttoncreator_OKClick);
			// 
			// Project_Creator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(388, 161);
			this.Controls.Add(this.Buttoncreator_OK);
			this.Controls.Add(this.Buttoncreator_Cancel);
			this.Controls.Add(this.Containercreator_GInfo);
			this.Controls.Add(this.Titlelabelcreator_CreateYProject);
			this.Name = "Project_Creator";
			this.Text = "Project_Creator";
			this.Containercreator_GInfo.ResumeLayout(false);
			this.Containercreator_GInfo.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}
