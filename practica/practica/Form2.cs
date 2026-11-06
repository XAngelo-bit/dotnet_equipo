/*
 * Creado por SharpDevelop.
 * Usuario: CC2_PC47
 * Fecha: 04/11/2026
 * Hora: 07:50 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace practica
{
	/// <summary>
	/// Description of Form2.
	/// </summary>
	public partial class Form2 : Form
	{
		public Form2()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Form2Load(object sender, EventArgs e)
		{
			
		}
		
		void Label2Click(object sender, EventArgs e)
		{
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			double x1 = Convert.ToDouble(textBox1.Text);
			double y1 = Convert.ToDouble(textBox2.Text);
			double x2 = Convert.ToDouble(textBox3.Text);
			double y2 = Convert.ToDouble(textBox4.Text);
			
			double dx = x2 - x1;
			double dy = y2 - y1;
			
			double distancia = Math.Sqrt((dx * dx) + (dy * dy));
			
			label6.Text = distancia.ToString();
		}
	}
}
