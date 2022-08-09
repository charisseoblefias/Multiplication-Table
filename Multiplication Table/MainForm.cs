/*
 * Created by SharpDevelop.
 * User: Charisse Oblefias
 * Date: 5/22/2021
 * Time: 3:42 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Multiplication_Table
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void BtnShowAnswerClick(object sender, EventArgs e)
		{
			int first_number = Convert.ToInt16(txtFirstNumber.Text);
			int second_number = Convert.ToInt16(txtSecondNumber.Text);
			
			int result = first_number * second_number;
			txtresult.Text = result.ToString();
		}
		void BtnExitClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
