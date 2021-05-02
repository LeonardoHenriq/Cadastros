namespace Cadastrar_WebAPI.Models
{
    public class Pf
    {
        public Pf()
        {

        }
        public Pf(int id, string nome, string cpf, int idade, string telefone, string endereco)
        {
            this.id = id;
            this.nome = nome;
            this.cpf = cpf;
            this.idade = idade;
            this.telefone = telefone;
            this.endereco = endereco;
        }
        public int id { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public int idade { get; set; }
        public string telefone { get; set; }
        public string endereco { get; set; }
    }
}