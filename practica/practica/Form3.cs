/*
 * Creado por SharpDevelop.
 * Usuario: CC2_PC47
 * Fecha: 04/11/2026
 * Hora: 08:05 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace practica
{
	/// <summary>
	/// Description of Form3.
	/// </summary>
	public partial class Form3 : Form
	{
		public Form3()
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
			double x = Convert.ToDouble(textBox1.Text);
			double y = Convert.ToDouble(textBox2.Text);
		
		if (x > 0 && y > 0)
		{
		    label4.Text = "Primer cuadrante";
		}
		else if (x < 0 && y > 0)
		{
		    label4.Text = "Segundo cuadrante";
		}
		else if (x < 0 && y < 0)
		{
		    label4.Text = "Tercer cuadrante";
		}
		else if (x > 0 && y < 0)
		{
		    label4.Text = "Cuarto cuadrante";
		}
		else if (x == 0 && y == 0)
		{
		    label4.Text = "Origen";
		}
		else
		{
		    label4.Text = "Sobre un eje";
		}
		}
		
		void Form3Load(object sender, EventArgs e)
		{
			
		}
	}
}
