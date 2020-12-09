using System;
using Abstracao_POO.Classes;

namespace Abstracao_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Boleto boleto = new Boleto(); // Instanciando boleto

            // boleto.Registar("123456");

            // boleto.Cancelar();

            // System.Console.WriteLine(boleto.CodigoDeBarras);

            // Pagamento pagamento = new Pagamento(); 

            // Cartao cartao = new Cartao(); // instanciando cartao

            Credito credito = new Credito();

            Debito debito = new Debito();
        }
    }
}
