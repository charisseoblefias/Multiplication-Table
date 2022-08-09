/*
 * Created by SharpDevelop.
 * User: Charisse Oblefias
 * Date: 5/22/2021
 * Time: 3:42 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Multiplication_Table
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox txtFirstNumber;
		private System.Windows.Forms.TextBox txtSecondNumber;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtresult;
		private System.Windows.Forms.Button btnShowAnswer;
		private System.Windows.Forms.Button btnExit;
		
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
			this.txtFirstNumber = new System.Windows.Forms.TextBox();
			this.txtSecondNumber = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtresult = new System.Windows.Forms.TextBox();
			this.btnShowAnswer = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtFirstNumber
			// 
			this.txtFirstNumber.Location = new System.Drawing.Point(30, 88);
			this.txtFirstNumber.Name = "txtFirstNumber";
			this.txtFirstNumber.Size = new System.Drawing.Size(86, 22);
			this.txtFirstNumber.TabIndex = 0;
			this.txtFirstNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtSecondNumber
			// 
			this.txtSecondNumber.Location = new System.Drawing.Point(184, 88);
			this.txtSecondNumber.Name = "txtSecondNumber";
			this.txtSecondNumber.Size = new System.Drawing.Size(84, 22);
			this.txtSecondNumber.TabIndex = 3;
			this.txtSecondNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(30, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 39);
			this.label1.TabIndex = 4;
			this.label1.Text = "Enter the first number:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(169, 26);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(112, 39);
			this.label2.TabIndex = 5;
			this.label2.Text = "Enter the second number:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(142, 88);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(18, 23);
			this.label3.TabIndex = 6;
			this.label3.Text = "X";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(288, 87);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(19, 23);
			this.label4.TabIndex = 7;
			this.label4.Text = "=";
			// 
			// txtresult
			// 
			this.txtresult.Location = new System.Drawing.Point(314, 88);
			this.txtresult.Name = "txtresult";
			this.txtresult.Size = new System.Drawing.Size(82, 22);
			this.txtresult.TabIndex = 8;
			this.txtresult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// btnShowAnswer
			// 
			this.btnShowAnswer.Location = new System.Drawing.Point(90, 167);
			this.btnShowAnswer.Name = "btnShowAnswer";
			this.btnShowAnswer.Size = new System.Drawing.Size(108, 33);
			this.btnShowAnswer.TabIndex = 9;
			this.btnShowAnswer.Text = "Show Answer";
			this.btnShowAnswer.UseVisualStyleBackColor = true;
			this.btnShowAnswer.Click += new System.EventHandler(this.BtnShowAnswerClick);
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(236, 167);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(103, 34);
			this.btnExit.TabIndex = 10;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.BtnExitClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(408, 267);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnShowAnswer);
			this.Controls.Add(this.txtresult);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtSecondNumber);
			this.Controls.Add(this.txtFirstNumber);
			this.Name = "MainForm";
			this.Text = "Multiplication Table";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
