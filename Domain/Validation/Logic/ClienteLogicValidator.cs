using System.Collections.Generic;
using System.Linq;
using Domain.Models;

namespace Domain.Validation.Logic
{
    public class ClienteLogicValidator : IValidator<Cliente>
    {
        public IEnumerable<string> BrokenRules(Cliente entity)
        {
            if (string.IsNullOrEmpty(entity.Nome)){
                yield return "O nome é obrigatório.";
            }
            if (entity.Nome.Length < 10)
            {
                yield return "O nome deve conter pelo menos 10 letras.";
            }
            if (entity.Nome.Length > 50)
            {
                yield return "O nome deve conter no máximo 50 letras.";
            }
            if (string.IsNullOrEmpty(entity.Sexo))
            {
                yield return "O nome é obrigatório.";
            }
        }

        public bool IsValid(Cliente entity)
        {
            return !BrokenRules(entity).Any();
        }
    }
}
