namespace Domain.ValueObject
{
    public class Endereco
    {
        public Endereco(string bairro, string rua, string numero)
        {
            Bairro = bairro;
            Rua = rua;
            Numero = numero;
        }

        public string Bairro { get; private set; }
        public string Rua { get; private set; }
        public string Numero { get; private set; }
    }
}
