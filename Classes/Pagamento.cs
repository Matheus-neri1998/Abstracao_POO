using System;

namespace Abstracao_POO.Classes
{
    public abstract class Pagamento
    {
        private DateTime data;
        public DateTime Data{

        get;set;
        }
        protected float valor;
        public float Valor{
            get;set;
        }
        // private bool status;
        public string Cancelar(){ 
            return "";
        }

        // Obrigatório
        public abstract string Desconto(int valor);
        public abstract string Juros(int parcelas);  
    }
}