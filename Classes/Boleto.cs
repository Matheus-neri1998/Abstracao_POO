using System;

namespace Abstracao_POO.Classes
{
    public class Boleto : Pagamento
    {
        
        private float codigoDeBarras;

        public float CodigoDeBarras{

            get {return codigoDeBarras;} // acessar o código de barras
        }

        public void Registrar(){
            Random random = new Random();
            this.codigoDeBarras = random.Next(); // gera um valor randomico, ou aleatório
        }
        public override string Desconto(int valor)
        {
            return "";
        }

        public override string Juros(int parcelas)
        {
            return "";
        }
        public void GerarBoleto(){ 

            float total = this.Valor -(this.Valor * 0.12f); 

            System.Console.WriteLine($"Valor do boleto - R${total}");
            System.Console.WriteLine($"Data - {this.Data}");
            System.Console.WriteLine($"Data de vencimento {this.Data.AddDays(10)}");
            System.Console.WriteLine($"Código de Barras - {this.CodigoDeBarras}");

            // this.Valor = total
        }

        // internal void Registar()
        // {
        //     throw new NotImplementedException();
        // }
    }
}