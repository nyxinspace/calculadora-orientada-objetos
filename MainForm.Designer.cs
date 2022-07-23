/*
 * Created by SharpDevelop.
 * User: Rodox
 * Date: 27/08/2018
 * Time: 19:36
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace CalculadoraOrientadaObjeto
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lbResultado = new System.Windows.Forms.Label();
			this.txValor1 = new System.Windows.Forms.TextBox();
			this.txValor2 = new System.Windows.Forms.TextBox();
			this.txOperacao = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btCalcular = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Digite o valor 1";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 63);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Digite o valor 2";
			// 
			// lbResultado
			// 
			this.lbResultado.Location = new System.Drawing.Point(12, 215);
			this.lbResultado.Name = "lbResultado";
			this.lbResultado.Size = new System.Drawing.Size(100, 23);
			this.lbResultado.TabIndex = 2;
			this.lbResultado.Text = "Resultado é:";
			// 
			// txValor1
			// 
			this.txValor1.Location = new System.Drawing.Point(12, 25);
			this.txValor1.Name = "txValor1";
			this.txValor1.Size = new System.Drawing.Size(260, 20);
			this.txValor1.TabIndex = 3;
			// 
			// txValor2
			// 
			this.txValor2.Location = new System.Drawing.Point(12, 79);
			this.txValor2.Name = "txValor2";
			this.txValor2.Size = new System.Drawing.Size(260, 20);
			this.txValor2.TabIndex = 4;
			// 
			// txOperacao
			// 
			this.txOperacao.Location = new System.Drawing.Point(12, 135);
			this.txOperacao.Name = "txOperacao";
			this.txOperacao.Size = new System.Drawing.Size(260, 20);
			this.txOperacao.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 109);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 6;
			this.label3.Text = "Operação (+, -, *, /)";
			// 
			// btCalcular
			// 
			this.btCalcular.Location = new System.Drawing.Point(12, 172);
			this.btCalcular.Name = "btCalcular";
			this.btCalcular.Size = new System.Drawing.Size(260, 23);
			this.btCalcular.TabIndex = 7;
			this.btCalcular.Text = "Calcular";
			this.btCalcular.UseVisualStyleBackColor = true;
			this.btCalcular.Click += new System.EventHandler(this.BtCalcularClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.btCalcular);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txOperacao);
			this.Controls.Add(this.txValor2);
			this.Controls.Add(this.txValor1);
			this.Controls.Add(this.lbResultado);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "CalculadoraOrientadaObjeto";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btCalcular;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txOperacao;
		private System.Windows.Forms.TextBox txValor2;
		private System.Windows.Forms.TextBox txValor1;
		private System.Windows.Forms.Label lbResultado;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
