/*
 * Creado por SharpDevelop.
 * Usuario: CC2_PC47
 * Fecha: 04/11/2026
 * Hora: 07:32 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace practica
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class Form1 : Form
	{
		public Form1()
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
			double cantidad = Convert.ToDouble(textBox1.Text);
			double resultado = 0;

		if (comboBox1.Text == "Dólares" && comboBox2.Text == "Pesos")
		{
	  	  resultado = cantidad * 18;
		}
		else if (comboBox1.Text == "Pesos" && comboBox2.Text == "Dólares")
		{
	  	  resultado = cantidad / 18;
		}
		else
		{
	  	  resultado = cantidad;
		}
	
			textBox2.Text = resultado.ToString();
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox2.Clear();
			textBox1.Text="";
			textBox2.Text="";
		}
	}
}
