/*
 * Created by SharpDevelop.
 * User: CC2_PC47
 * Date: 04/11/2026
 * Time: 07:24 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace practica
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
		
		void Button1Click(object sender, EventArgs e)
		{
			Form1 formulario = new Form1();
			formulario.Show();
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			Form2 formulario = new Form2();
			formulario.Show();
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			Form3 formulario = new Form3();
			formulario.Show();
		}
	}
}
