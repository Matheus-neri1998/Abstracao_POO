namespace Abstracao_POO.Classes
{
    public class Boleto : Pagamento
    {
        private string codigoDeBarras;
        public string CodigoDeBarras{
            get {return codigoDeBarras;}
            } // acessar o código de barras
        public void Registar(string valor){
            this.codigoDeBarras = valor; // definir o código de barras
        }
        public override string Desconto(int valor)
        {
            return "";
        }

        public override string Juros(int parcelas)
        {
            return "";
        }
    }
}