namespace Domain.Models
{
    public class Vendedor:Entity<int>
    {
        public Vendedor()
        {

        }
        public Vendedor(string nome, string endereco)
        {
            Nome = nome;
            Endereco = endereco;
        }

        public string Nome { get; private set; }
        public string Endereco { get; private set; }
       
    }
}
