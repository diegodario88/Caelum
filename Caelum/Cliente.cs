namespace Caelum
{
    public class Cliente
    {

        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Cpf { get; set; }
        public string Documentos { get; set; }

        //Método Construtor de Clientes
        public Cliente (string nome)
        {
            this.Nome = nome;
        }
        public Cliente(string nome, int idade, string cpf, string documentos)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Cpf = cpf;
            this.Documentos = documentos;
        }

        //Método que verifica se o cliente pode abrir conta
        public bool PodeAbrirContaSozinho
        {
            get
            {
                bool maiorDeIdade = this.Idade >= 18;
                bool emancipado = this.Documentos.Contains("emancipado");
                bool possuiCPF = !string.IsNullOrEmpty(this.Cpf);
                return (maiorDeIdade || emancipado) && possuiCPF;

            }
        }

    }
}