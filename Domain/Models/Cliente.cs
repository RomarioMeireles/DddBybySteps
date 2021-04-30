using System.Collections.Generic;
using Domain.Validation;
using Domain.ValueObject;

namespace Domain.Models
{
    public class Cliente:Entity<int>, IValidatabable<Cliente>
    {
        public Cliente()
        {

        }
        public Cliente(string nome,string sexo, Email email, Endereco endereco)
        {
            Nome = nome;
            Sexo = sexo;
            Email = email;
            Endereco = endereco;
        }

        public string Nome { get; private set; }
        public string Sexo { get; private set; }
        public Email Email { get; private set; }
        public Endereco Endereco { get; private set; }

        public bool Validate(IValidator<Cliente> validator, out IEnumerable<string> brokenRules)
        {
            brokenRules = validator.BrokenRules(this);
            return validator.IsValid(this);
        }
    }
}
