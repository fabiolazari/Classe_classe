using Classe_classe.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_classe.Metodos
{
	public class ListaCliente
	{
		public List<Cliente> Clientes { get; set; }

		public ListaCliente(List<Cliente> clientes)
		{
			Clientes = clientes;
		}

		public void Listar()
		{
			/*
			foreach (var item in Clientes)
			{
				Console.WriteLine(item.Id + " - " + item.Nome);
			}
			*/
			Clientes.ForEach(item => {
				Console.WriteLine(item.Id + " - " + item.Nome);
			});

			Console.WriteLine();
		}
	}
}
