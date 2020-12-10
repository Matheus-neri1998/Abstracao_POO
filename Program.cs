using System;
using Abstracao_POO.Classes;

namespace Abstracao_POO
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite o valor da compra:"); // Entrada = digitando o valor da compra
            float valorDaCompra = float.Parse(Console.ReadLine());

            Console.WriteLine("Selecione um método de pagamento"); // escolhendo a forma de pagamento. Abaixo, a escolha do boleto
            Console.WriteLine("1 - Boleto");
            Console.WriteLine("2 - Cartão");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1: // boleto
                    Boleto boleto = new Boleto();
                    boleto.Registrar(); // gerando código de barras
                    System.Console.WriteLine($"Código de Barras - {boleto.CodigoDeBarras}");
                    boleto.Valor = valorDaCompra; // armazenando o valor da compra
                    boleto.Data = DateTime.Now; // definir a data e hora atual

                    boleto.GerarBoleto(); // exibindo
                    break;
                case 2: // cartão
                    Console.WriteLine("Selecione um tipo de cartão:"); // escolhendo o tipo de cartão
                    Console.WriteLine("1 - Crédito");
                    Console.WriteLine("2 - Débito");
                    int tipo = int.Parse(Console.ReadLine());

                    switch (tipo)
                    {
                        case 1: // Crédito

                        Credito credito = new Credito();
                        
                        Console.WriteLine("Insira a Bandeira do cartão: "); // bandeira do cartão crédito
                        credito.bandeira = Console.ReadLine();
                        Console.WriteLine("Insira o número do cartão: "); // número do cartão crédito
                        credito.numero = Console.ReadLine();
                        Console.WriteLine("Titular do cartão: "); // titular do cartão crédito
                        credito.titular = Console.ReadLine();
                        Console.WriteLine("CVV do Cartão: "); // cvv do cartão crédito
                        credito.cvv = Console.ReadLine();
                        Console.WriteLine("Cadastro sucedido"); // Dados inseridos e cadastro feito
                        
                        
                            break;
                        case 2: // Débito
                        Debito debito = new Debito();
                        
                        Console.WriteLine("Insira a Bandeira do cartão: "); // bandeira do cartão débito
                        debito.bandeira = Console.ReadLine();
                        Console.WriteLine("Insira o número do cartão: "); // número do cartão débito
                        debito.numero = Console.ReadLine();
                        Console.WriteLine("Titular do cartão: ");
                        debito.titular = Console.ReadLine();
                        Console.WriteLine("CVV do Cartão: ");
                        debito.cvv = Console.ReadLine();
                        Console.WriteLine("Cadastro sucedido");

                            break;
                    }
                    
                
                    break;
                default:
                    break;
            }
            
        }
    }
}
