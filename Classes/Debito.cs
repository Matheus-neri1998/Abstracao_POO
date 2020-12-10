namespace Abstracao_POO.Classes
{
    public class Debito : Cartao
    {
        private float saldo = 600;
        public void Pagar(float valor){
            
        }

        public override void Pagar()
        {
            throw new System.NotImplementedException();
        }
    }
}