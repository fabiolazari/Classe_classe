using Classe_classe.Entities;
using Classe_classe.Metodos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_classe
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Cliente> cli = new List<Cliente>();

			cli.Add(new Cliente { Id = 1, Nome = "Fulano", Telefone = "2524-5784" });
			cli.Add(new Cliente { Id = 2, Nome = "Ciclano", Telefone = "3245-2567" });
			cli.Add(new Cliente { Id = 3, Nome = "Beltrano", Telefone = "3234-3657" });
			cli.Add(new Cliente { Id = 4, Nome = "Dunha", Telefone = "2524-1258" });
			cli.Add(new Cliente { Id = 5, Nome = "Locha", Telefone = "3233-3185" });

			/*
			foreach (var item in cli)
			{
				Console.WriteLine(item.Id + " - " + item.Nome + " - " + item.Telefone);
			}
			*/
			Console.WriteLine();
			cli.ForEach(item => {
				Console.WriteLine(item.Id + " - " + item.Nome + " - " + item.Telefone);
			});

			ListaCliente lCli = new ListaCliente(cli);
			lCli.Listar();

			Console.ReadKey();
		}
	}
}
