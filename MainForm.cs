/*
 * Created by SharpDevelop.
 * User: Rodox
 * Date: 27/08/2018
 * Time: 19:36
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CalculadoraOrientadaObjeto
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
		
		void BtCalcularClick(object sender, EventArgs e)
		{
			Calculadora calc = new Calculadora();
			
			calc.setValor1(Convert.ToDecimal(txValor1.Text));
			calc.setValor2(Convert.ToDecimal(txValor2.Text));
			
			MessageBox.Show("O valor 1 é " + calc.getValor1().ToString());
		}
	}
}
