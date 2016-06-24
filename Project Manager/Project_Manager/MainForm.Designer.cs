/*
 * Created by SharpDevelop.
 * User: Timo
 * Date: 15.06.2016
 * Time: 00:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Project_Manager
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox Containermain_Managment;
		private System.Windows.Forms.ComboBox Projectmain_Select;
		private System.Windows.Forms.Button Buttonmain_Delete;
		private System.Windows.Forms.Button Buttonmain_New;
		private System.Windows.Forms.Button Buttonmain_Enter;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox Containermain_GInfo;
		private System.Windows.Forms.Label Titlelabelmain_Project;
		private System.Windows.Forms.Button Buttonmain_EditGInfo;
		private System.Windows.Forms.Button Buttonmain_ViewToDo;
		private System.Windows.Forms.Label Titlelabelmain_CurrentStep;
		private System.Windows.Forms.Label Titlelabelmain_GithubLink;
		private System.Windows.Forms.Label Titlelabelmain_CreationDate;
		private System.Windows.Forms.PictureBox Picturboxmain_Logo;
		private System.Windows.Forms.Label Label_Projectname;
		private System.Windows.Forms.Label Titlelabelmain_Creator;
		private System.Windows.Forms.Label Titlelabelmain_LastChangeDate;
		private System.Windows.Forms.Label Labelmain_GithubLink;
		private System.Windows.Forms.Label Labelmain_CurrentStep;
		private System.Windows.Forms.Label Labelmain_Creator;
		private System.Windows.Forms.Label Labelmain_LastChange;
		private System.Windows.Forms.Label Labelmain_CreationDate;
		private System.Windows.Forms.Label Label_Describtion;
		private System.Windows.Forms.Label Labelmain_License;
		private System.Windows.Forms.Label Titlelabelmain_License;
		
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
			this.Containermain_Managment = new System.Windows.Forms.GroupBox();
			this.Titlelabelmain_Project = new System.Windows.Forms.Label();
			this.Projectmain_Select = new System.Windows.Forms.ComboBox();
			this.Buttonmain_Delete = new System.Windows.Forms.Button();
			this.Buttonmain_New = new System.Windows.Forms.Button();
			this.Buttonmain_Enter = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.Containermain_GInfo = new System.Windows.Forms.GroupBox();
			this.Labelmain_License = new System.Windows.Forms.Label();
			this.Titlelabelmain_License = new System.Windows.Forms.Label();
			this.Label_Describtion = new System.Windows.Forms.Label();
			this.Labelmain_GithubLink = new System.Windows.Forms.Label();
			this.Labelmain_CurrentStep = new System.Windows.Forms.Label();
			this.Labelmain_Creator = new System.Windows.Forms.Label();
			this.Labelmain_LastChange = new System.Windows.Forms.Label();
			this.Labelmain_CreationDate = new System.Windows.Forms.Label();
			this.Label_Projectname = new System.Windows.Forms.Label();
			this.Titlelabelmain_CurrentStep = new System.Windows.Forms.Label();
			this.Titlelabelmain_GithubLink = new System.Windows.Forms.Label();
			this.Titlelabelmain_Creator = new System.Windows.Forms.Label();
			this.Titlelabelmain_LastChangeDate = new System.Windows.Forms.Label();
			this.Titlelabelmain_CreationDate = new System.Windows.Forms.Label();
			this.Picturboxmain_Logo = new System.Windows.Forms.PictureBox();
			this.Buttonmain_EditGInfo = new System.Windows.Forms.Button();
			this.Buttonmain_ViewToDo = new System.Windows.Forms.Button();
			this.Containermain_Managment.SuspendLayout();
			this.Containermain_GInfo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Picturboxmain_Logo)).BeginInit();
			this.SuspendLayout();
			// 
			// Containermain_Managment
			// 
			this.Containermain_Managment.Controls.Add(this.Titlelabelmain_Project);
			this.Containermain_Managment.Controls.Add(this.Projectmain_Select);
			this.Containermain_Managment.Controls.Add(this.Buttonmain_Delete);
			this.Containermain_Managment.Controls.Add(this.Buttonmain_New);
			this.Containermain_Managment.Controls.Add(this.Buttonmain_Enter);
			this.Containermain_Managment.Location = new System.Drawing.Point(12, 12);
			this.Containermain_Managment.Name = "Containermain_Managment";
			this.Containermain_Managment.Size = new System.Drawing.Size(370, 82);
			this.Containermain_Managment.TabIndex = 0;
			this.Containermain_Managment.TabStop = false;
			this.Containermain_Managment.Text = "Management";
			// 
			// Titlelabelmain_Project
			// 
			this.Titlelabelmain_Project.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Titlelabelmain_Project.Location = new System.Drawing.Point(7, 51);
			this.Titlelabelmain_Project.Name = "Titlelabelmain_Project";
			this.Titlelabelmain_Project.Size = new System.Drawing.Size(64, 23);
			this.Titlelabelmain_Project.TabIndex = 4;
			this.Titlelabelmain_Project.Text = "Project:";
			this.Titlelabelmain_Project.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Projectmain_Select
			// 
			this.Projectmain_Select.FormattingEnabled = true;
			this.Projectmain_Select.Location = new System.Drawing.Point(77, 51);
			this.Projectmain_Select.Name = "Projectmain_Select";
			this.Projectmain_Select.Size = new System.Drawing.Size(287, 21);
			this.Projectmain_Select.TabIndex = 3;
			// 
			// Buttonmain_Delete
			// 
			this.Buttonmain_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Buttonmain_Delete.Location = new System.Drawing.Point(265, 20);
			this.Buttonmain_Delete.Name = "Buttonmain_Delete";
			this.Buttonmain_Delete.Size = new System.Drawing.Size(100, 25);
			this.Buttonmain_Delete.TabIndex = 2;
			this.Buttonmain_Delete.Text = "Delete";
			this.Buttonmain_Delete.UseVisualStyleBackColor = true;
			this.Buttonmain_Delete.Click += new System.EventHandler(this.Button_DeleteClick);
			// 
			// Buttonmain_New
			// 
			this.Buttonmain_New.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Buttonmain_New.Location = new System.Drawing.Point(135, 20);
			this.Buttonmain_New.Name = "Buttonmain_New";
			this.Buttonmain_New.Size = new System.Drawing.Size(100, 25);
			this.Buttonmain_New.TabIndex = 1;
			this.Buttonmain_New.Text = "New";
			this.Buttonmain_New.UseVisualStyleBackColor = true;
			this.Buttonmain_New.Click += new System.EventHandler(this.Button_NewClick);
			// 
			// Buttonmain_Enter
			// 
			this.Buttonmain_Enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Buttonmain_Enter.Location = new System.Drawing.Point(5, 20);
			this.Buttonmain_Enter.Name = "Buttonmain_Enter";
			this.Buttonmain_Enter.Size = new System.Drawing.Size(100, 25);
			this.Buttonmain_Enter.TabIndex = 0;
			this.Buttonmain_Enter.Text = "Enter";
			this.Buttonmain_Enter.UseVisualStyleBackColor = true;
			this.Buttonmain_Enter.Click += new System.EventHandler(this.Button_EnterClick);
			// 
			// groupBox2
			// 
			this.groupBox2.Location = new System.Drawing.Point(388, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(484, 538);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "groupBox2";
			// 
			// Containermain_GInfo
			// 
			this.Containermain_GInfo.Controls.Add(this.Labelmain_License);
			this.Containermain_GInfo.Controls.Add(this.Titlelabelmain_License);
			this.Containermain_GInfo.Controls.Add(this.Label_Describtion);
			this.Containermain_GInfo.Controls.Add(this.Labelmain_GithubLink);
			this.Containermain_GInfo.Controls.Add(this.Labelmain_CurrentStep);
			this.Containermain_GInfo.Controls.Add(this.Labelmain_Creator);
			this.Containermain_GInfo.Controls.Add(this.Labelmain_LastChange);
			this.Containermain_GInfo.Controls.Add(this.Labelmain_CreationDate);
			this.Containermain_GInfo.Controls.Add(this.Label_Projectname);
			this.Containermain_GInfo.Controls.Add(this.Titlelabelmain_CurrentStep);
			this.Containermain_GInfo.Controls.Add(this.Titlelabelmain_GithubLink);
			this.Containermain_GInfo.Controls.Add(this.Titlelabelmain_Creator);
			this.Containermain_GInfo.Controls.Add(this.Titlelabelmain_LastChangeDate);
			this.Containermain_GInfo.Controls.Add(this.Titlelabelmain_CreationDate);
			this.Containermain_GInfo.Controls.Add(this.Picturboxmain_Logo);
			this.Containermain_GInfo.Controls.Add(this.Buttonmain_EditGInfo);
			this.Containermain_GInfo.Controls.Add(this.Buttonmain_ViewToDo);
			this.Containermain_GInfo.Location = new System.Drawing.Point(12, 100);
			this.Containermain_GInfo.Name = "Containermain_GInfo";
			this.Containermain_GInfo.Size = new System.Drawing.Size(370, 450);
			this.Containermain_GInfo.TabIndex = 2;
			this.Containermain_GInfo.TabStop = false;
			this.Containermain_GInfo.Text = "General Informations";
			// 
			// Labelmain_License
			// 
			this.Labelmain_License.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Labelmain_License.Location = new System.Drawing.Point(134, 275);
			this.Labelmain_License.Name = "Labelmain_License";
			this.Labelmain_License.Size = new System.Drawing.Size(219, 23);
			this.Labelmain_License.TabIndex = 22;
			this.Labelmain_License.Text = "License";
			this.Labelmain_License.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Titlelabelmain_License
			// 
			this.Titlelabelmain_License.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Titlelabelmain_License.Location = new System.Drawing.Point(5, 275);
			this.Titlelabelmain_License.Name = "Titlelabelmain_License";
			this.Titlelabelmain_License.Size = new System.Drawing.Size(125, 23);
			this.Titlelabelmain_License.TabIndex = 21;
			this.Titlelabelmain_License.Text = "License:";
			this.Titlelabelmain_License.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Label_Describtion
			// 
			this.Label_Describtion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label_Describtion.Location = new System.Drawing.Point(123, 52);
			this.Label_Describtion.Name = "Label_Describtion";
			this.Label_Describtion.Size = new System.Drawing.Size(230, 68);
			this.Label_Describtion.TabIndex = 20;
			this.Label_Describtion.Text = "Describtion";
			this.Label_Describtion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Labelmain_GithubLink
			// 
			this.Labelmain_GithubLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Labelmain_GithubLink.Location = new System.Drawing.Point(134, 382);
			this.Labelmain_GithubLink.Name = "Labelmain_GithubLink";
			this.Labelmain_GithubLink.Size = new System.Drawing.Size(230, 23);
			this.Labelmain_GithubLink.TabIndex = 19;
			this.Labelmain_GithubLink.Text = "Link";
			this.Labelmain_GithubLink.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Labelmain_CurrentStep
			// 
			this.Labelmain_CurrentStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Labelmain_CurrentStep.Location = new System.Drawing.Point(134, 328);
			this.Labelmain_CurrentStep.Name = "Labelmain_CurrentStep";
			this.Labelmain_CurrentStep.Size = new System.Drawing.Size(230, 23);
			this.Labelmain_CurrentStep.TabIndex = 18;
			this.Labelmain_CurrentStep.Text = "Step";
			this.Labelmain_CurrentStep.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Labelmain_Creator
			// 
			this.Labelmain_Creator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Labelmain_Creator.Location = new System.Drawing.Point(134, 228);
			this.Labelmain_Creator.Name = "Labelmain_Creator";
			this.Labelmain_Creator.Size = new System.Drawing.Size(230, 23);
			this.Labelmain_Creator.TabIndex = 16;
			this.Labelmain_Creator.Text = "Creator";
			this.Labelmain_Creator.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Labelmain_LastChange
			// 
			this.Labelmain_LastChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Labelmain_LastChange.Location = new System.Drawing.Point(135, 180);
			this.Labelmain_LastChange.Name = "Labelmain_LastChange";
			this.Labelmain_LastChange.Size = new System.Drawing.Size(230, 23);
			this.Labelmain_LastChange.TabIndex = 15;
			this.Labelmain_LastChange.Text = "Date";
			this.Labelmain_LastChange.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Labelmain_CreationDate
			// 
			this.Labelmain_CreationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Labelmain_CreationDate.Location = new System.Drawing.Point(135, 138);
			this.Labelmain_CreationDate.Name = "Labelmain_CreationDate";
			this.Labelmain_CreationDate.Size = new System.Drawing.Size(230, 23);
			this.Labelmain_CreationDate.TabIndex = 14;
			this.Labelmain_CreationDate.Text = "Date";
			this.Labelmain_CreationDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Label_Projectname
			// 
			this.Label_Projectname.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label_Projectname.Location = new System.Drawing.Point(113, 20);
			this.Label_Projectname.Name = "Label_Projectname";
			this.Label_Projectname.Size = new System.Drawing.Size(251, 32);
			this.Label_Projectname.TabIndex = 13;
			this.Label_Projectname.Text = "Project";
			this.Label_Projectname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Titlelabelmain_CurrentStep
			// 
			this.Titlelabelmain_CurrentStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Titlelabelmain_CurrentStep.Location = new System.Drawing.Point(5, 328);
			this.Titlelabelmain_CurrentStep.Name = "Titlelabelmain_CurrentStep";
			this.Titlelabelmain_CurrentStep.Size = new System.Drawing.Size(125, 23);
			this.Titlelabelmain_CurrentStep.TabIndex = 12;
			this.Titlelabelmain_CurrentStep.Text = "Current Step:";
			this.Titlelabelmain_CurrentStep.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Titlelabelmain_GithubLink
			// 
			this.Titlelabelmain_GithubLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Titlelabelmain_GithubLink.Location = new System.Drawing.Point(5, 382);
			this.Titlelabelmain_GithubLink.Name = "Titlelabelmain_GithubLink";
			this.Titlelabelmain_GithubLink.Size = new System.Drawing.Size(125, 23);
			this.Titlelabelmain_GithubLink.TabIndex = 11;
			this.Titlelabelmain_GithubLink.Text = "Github:";
			this.Titlelabelmain_GithubLink.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Titlelabelmain_Creator
			// 
			this.Titlelabelmain_Creator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Titlelabelmain_Creator.Location = new System.Drawing.Point(6, 228);
			this.Titlelabelmain_Creator.Name = "Titlelabelmain_Creator";
			this.Titlelabelmain_Creator.Size = new System.Drawing.Size(125, 23);
			this.Titlelabelmain_Creator.TabIndex = 9;
			this.Titlelabelmain_Creator.Text = "Creator/s:";
			this.Titlelabelmain_Creator.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Titlelabelmain_LastChangeDate
			// 
			this.Titlelabelmain_LastChangeDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Titlelabelmain_LastChangeDate.Location = new System.Drawing.Point(7, 180);
			this.Titlelabelmain_LastChangeDate.Name = "Titlelabelmain_LastChangeDate";
			this.Titlelabelmain_LastChangeDate.Size = new System.Drawing.Size(125, 23);
			this.Titlelabelmain_LastChangeDate.TabIndex = 8;
			this.Titlelabelmain_LastChangeDate.Text = "Last Change:";
			this.Titlelabelmain_LastChangeDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Titlelabelmain_CreationDate
			// 
			this.Titlelabelmain_CreationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Titlelabelmain_CreationDate.Location = new System.Drawing.Point(6, 138);
			this.Titlelabelmain_CreationDate.Name = "Titlelabelmain_CreationDate";
			this.Titlelabelmain_CreationDate.Size = new System.Drawing.Size(125, 23);
			this.Titlelabelmain_CreationDate.TabIndex = 5;
			this.Titlelabelmain_CreationDate.Text = "Creation Date:";
			this.Titlelabelmain_CreationDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Picturboxmain_Logo
			// 
			this.Picturboxmain_Logo.Location = new System.Drawing.Point(7, 20);
			this.Picturboxmain_Logo.Name = "Picturboxmain_Logo";
			this.Picturboxmain_Logo.Size = new System.Drawing.Size(100, 100);
			this.Picturboxmain_Logo.TabIndex = 7;
			this.Picturboxmain_Logo.TabStop = false;
			// 
			// Buttonmain_EditGInfo
			// 
			this.Buttonmain_EditGInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Buttonmain_EditGInfo.Location = new System.Drawing.Point(135, 419);
			this.Buttonmain_EditGInfo.Name = "Buttonmain_EditGInfo";
			this.Buttonmain_EditGInfo.Size = new System.Drawing.Size(100, 25);
			this.Buttonmain_EditGInfo.TabIndex = 5;
			this.Buttonmain_EditGInfo.Text = "Edit";
			this.Buttonmain_EditGInfo.UseVisualStyleBackColor = true;
			// 
			// Buttonmain_ViewToDo
			// 
			this.Buttonmain_ViewToDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Buttonmain_ViewToDo.Location = new System.Drawing.Point(7, 419);
			this.Buttonmain_ViewToDo.Name = "Buttonmain_ViewToDo";
			this.Buttonmain_ViewToDo.Size = new System.Drawing.Size(100, 25);
			this.Buttonmain_ViewToDo.TabIndex = 6;
			this.Buttonmain_ViewToDo.Text = "ToDo List";
			this.Buttonmain_ViewToDo.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(884, 562);
			this.Controls.Add(this.Containermain_GInfo);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.Containermain_Managment);
			this.Name = "MainForm";
			this.Text = "Project_Manager";
			this.Containermain_Managment.ResumeLayout(false);
			this.Containermain_GInfo.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Picturboxmain_Logo)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
