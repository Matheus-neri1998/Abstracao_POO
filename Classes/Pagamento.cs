using System;

namespace Abstracao_POO.Classes
{
    public abstract class Pagamento
    {
        private DateTime data;
        protected float valor;
        public string Cancelar(){ 

            return "";
        }

        // Obrigatório
        public abstract string Desconto(int valor);
        public abstract string Juros(int parcelas); 
    }
}