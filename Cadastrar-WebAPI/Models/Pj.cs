namespace Cadastrar_WebAPI.Models
{
    public class Pj
    {
        public Pj()
        {

        }
        public Pj(int id, string razsoc, string cnpj, string endereco, string telefone)
        {
            this.id = id;
            this.razsoc = razsoc;
            this.cnpj = cnpj;
            this.endereco = endereco;
            this.telefone = telefone;
        }
        public int id { get; set; }
        public string razsoc { get; set; }
        public string cnpj { get; set; }
        public string endereco { get; set; }
        public string telefone { get; set; }
    }
}