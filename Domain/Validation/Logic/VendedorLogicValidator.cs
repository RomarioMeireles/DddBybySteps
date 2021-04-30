using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Validation.Logic
{
    public class VendedorLogicValidator : IValidator<Vendedor>
    {
        public IEnumerable<string> BrokenRules(Vendedor entity)
        {
            if (string.IsNullOrEmpty(entity.Nome))
            {
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
        }

        public bool IsValid(Vendedor entity)
        {
            return !BrokenRules(entity).Any();
        }
    }
}
