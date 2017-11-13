using System;
using System.Collections.Generic;
using System.Linq;

namespace ListExample
{
    public class Cliente
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string cpf;
        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

        private int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public override string ToString()
        {
            return string.Format("Nome:{0}\n Cpf:{1}\n Age:{2}\n", Name, Cpf, Age);
        }

        List<Cliente> listaCliente = new List<Cliente>();


        public Cliente Add()
        {
            Cliente cli = new Cliente();
            Console.Write("Digite o nome do cliente: ");
            cli.Name = Console.ReadLine();
            Console.Write("Digite o cpf do cliente: ");
            cli.Cpf = Console.ReadLine();
            Console.Write("Digite a idade do cliente: ");
            cli.Age = int.Parse(Console.ReadLine());

            listaCliente.Add(cli);

            Console.WriteLine("Detalhes do cliente - {0}\n", cli);

            return cli;
        }

        public void showList()
        {
			Console.WriteLine("Lista de clientes: ");

			foreach (Cliente c in listaCliente)
            {
                Console.WriteLine(c.ToString());
            }
        }

        public void Remove()
        {
            Console.Write("Digite o cpf do cliente a ser removido:");
            string cpfremove = Console.ReadLine();
			var itemToRemove = listaCliente.SingleOrDefault(r => r.Cpf == cpfremove);
			if (itemToRemove != null)
				listaCliente.Remove(itemToRemove);

        }

    }
}
