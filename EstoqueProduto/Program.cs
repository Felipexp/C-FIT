using System;

namespace EstoqueProduto
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
		}

		public class EstoqueProduto
		{
			string NomeProduto;
			int QuantidadeProduto;
			int LimiteProduto;
			float PrecoProduto;



			// inicializar é com 0 ou com this.nomedavariável?
			public EstoqueProduto(string nomeProduto, int quantidadeProduto, int limiteProduto, float precoProduto)
			{
				NomeProduto = nomeProduto;
				QuantidadeProduto = quantidadeProduto;
				LimiteProduto = limiteProduto;
				PrecoProduto = precoProduto;
			}

			public void BaixaProduto(int quantidade)
			{
				if (QuantidadeProduto > 0)
				{ if (QuantidadeProduto >= LimiteProduto)
					{
						Console.WriteLine("Tá lotado mano!!!");
					}
					else
						QuantidadeProduto++;
				}
				else if (QuantidadeProduto == 0) 
				{
					Console.WriteLine("Tem tudo isso não mano!");
				}
				else QuantidadeProduto--;

			}

			public int ConsultarQuantidadeAtual() 
			{
				return QuantidadeProduto;
			}

			public int ConsultarValorTotal()
			{
				return (int)(QuantidadeProduto * PrecoProduto);
			}












		}
	}
}
