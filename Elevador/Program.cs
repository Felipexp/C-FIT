using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{

			




		}

		public class Elevador
		{
			private byte AndarAtual;
			private byte AndarTotal;
			private byte PessoasCapacidade;
			private byte PessoasAtual;

			public Elevador(byte andarAtual, byte andarTotal, byte pessoasCapacidade, byte pessoasAtual)
			{
				AndarAtual = andarAtual;
				AndarTotal = andarTotal;
				PessoasCapacidade = pessoasCapacidade;
				PessoasAtual = pessoasAtual;
			}


			public void Subir()
			{
				if (AndarAtual <= AndarTotal)
				{
					AndarAtual++;
				}
				else
					Console.WriteLine("Ultimo andar!!!");
			}

			public void Descer()
			{
				if (AndarAtual > 0)
				{
					AndarAtual--;
				}
				else
					Console.WriteLine("Térreo!!!");
			}

			public void EntrarPessoas(byte quantidadePessoas)

			{
				PessoasAtual++;
				if (PessoasAtual == PessoasCapacidade)
				{
					Console.WriteLine("Tá Cheio!!!");
				}


			}

			public void SairPessoas(byte quantidadePessoas)

			{
				PessoasAtual--;
				if (PessoasAtual == 0)
				{
					Console.WriteLine("Heim???");
				}

			}
			public byte ConsultarAndarAtual()
			{
				return AndarAtual;
			}
			public byte ConsultarQuantidadePessoas()
			{
				return PessoasAtual;
			}


			//Dúvida: pq a diferenciação na caixa das variáveis para os construtores
			//Dúvida: pq entrarPessoas e sairPessoas tem uma variável entre parênteses? 
		



		}


	}
}
