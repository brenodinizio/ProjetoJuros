using BLinvestimento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investimento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente1 = new Cliente();
            cliente1.Capital = 1400;
            cliente1.Idade = 33;
            cliente1.Nome = "Filaupe";
            //---------------------------------------
            Cliente cliente2 = new Cliente();
            cliente2.Capital = 1400;
            cliente2.Idade = 25;
            cliente2.Nome = "Adson";

            //------------------------------------------
            Cliente cliente3 = new Cliente();
            cliente3.Capital = 1400;
            cliente3.Idade = 37;
            cliente3.Nome = "Antonio";

            investimento invest = new investimento();
            List<Cliente> lista = new List<Cliente>();
            lista.Add(cliente1);
            lista.Add(cliente2);
            lista.Add(cliente3);


            Console.WriteLine("Simulação");
            Console.WriteLine("Juros Acumulado: "+ invest.retornarJurosAcumulado(lista, 24).ToString());
            //--------------------------------
            foreach (var item in lista)
            {
                Console.WriteLine($"Cliente: {item.Nome} " + "/" + $" Juros: {invest.retornarJurosCliente(item, 24).ToString()} ");

         
            }
            Console.WriteLine($"Média de idade: {Cliente.mediaIdade(lista)} ");

            Console.ReadKey();

        }
    }
}
