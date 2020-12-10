using System;
namespace Abstracao_POO.Classes
{
    public class Credito : Cartao
    {
       
        private float limite = 3000;
        public float Limite{
            get {return limite;}
        }
        public void Pagar(bool valor){
            if (valor == true)
            {
                Console.WriteLine("Compra feita");
            } else {
                System.Console.WriteLine("Encerrando");
            }
            
        }

        public override void Pagar()
        {
            throw new NotImplementedException();
        }
       
    }
}