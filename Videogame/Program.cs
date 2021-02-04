using System;

namespace Videogame
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
		}

		public class VideoGame
		{

			private string Nome;
			private string Tela;
			private string Jogo;
			private bool Rodando;
			private bool Ligado;



			//Não sei definir quais varíaveis declarar no construtor
			public VideoGame(String Nome, String Jogo)
			{
				Nome = "PS4";
				Jogo = Jogo;

			}

			public bool LigarOuDesligar()
			{
				if (Ligado == true)
				{
					return false;
				}
				else
					return true;
				string Tela = "Menu";
				string Jogo = "";
				bool Rodando = false;

			}

			public string ConsultarJogoAtual()
			{
				return Jogo;
			}
			public bool EstaRodandoJogo()
			{
				return Rodando; 
			}

			public void RodarJogo(string nomeJogo)
			{
				string Jogo = nomeJogo;
				string Tela = "rodando jogo...";

			}

			public void VoltarMenu()
			{
				string Tela = "Menu";
			}













		}




	}


}





}
