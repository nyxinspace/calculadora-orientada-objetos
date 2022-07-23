using System;

namespace CalculadoraOrientadaObjeto
{
	public class Calculadora
	{
		//Private garante o 
		//ENCAPSULAMENTO
		private decimal valor1;
		private decimal valor2;
		private decimal resultado;
		private string operacao;
		
		//Métodos SETS PARA SETAR VALOR NAS VARIÁVEIS
		public void setValor1(decimal valor)
		{
			this.valor1 = valor;
		}
		
		public void setValor2(decimal valor)
		{
			this.valor2 = valor;
		}
		
		public void setResultado(decimal valor)
		{
			this.resultado = valor;
		}
		
		public void setOperacao(string valor)
		{
			this.operacao = valor;
		}
		
		//MÉTODOS GETS QUE RETORNAM VALOR DAS VARIÁVEIS
		public decimal getValor1()
		{
			return this.valor1;
		}
		
		public decimal getValor2()
		{
			return this.valor2;
		}
		
		public decimal getResultado()
		{
			return this.resultado;
		}
		
		public string getOperacao()
		{
			return this.operacao;
		}
		
		//MÉTODO CONSTRUTOR
		public Calculadora()
		{
		}
	}
}
