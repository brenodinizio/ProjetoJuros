using BLinvestimento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInvestimento
{
    [TestClass]
   public class ClienteTest
    {
        [TestMethod]
        public void MediaDeIdade()
        {
            //33 anos+25+37= 31.66
            double esperado = 31.67;
            double resultado = 0;

            Cliente cli1 = new Cliente();
            cli1.Idade = 33;

            Cliente cli2 = new Cliente();
            cli2.Idade = 25;

            Cliente cli3 = new Cliente();
            cli3.Idade = 37;

            List<Cliente> lista = new List<Cliente>();
            lista.Add(cli1);
            lista.Add(cli2);
            lista.Add(cli3);

            resultado = Cliente.mediaIdade(lista);
            Assert.AreEqual(esperado, resultado);
        }



    }
    
}
