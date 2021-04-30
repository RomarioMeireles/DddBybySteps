using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Validation.Logic
{
    public class UsuarioLogicValidator : IValidator<Usuario>
    {
        public IEnumerable<string> BrokenRules(Usuario entity)
        {
            if (string.IsNullOrEmpty(entity.UserName))
            {
                yield return "O nome é obrigatório.";
            }
            if (entity.UserName.Length < 10)
            {
                yield return "O nome deve conter pelo menos 10 letras.";
            }
            if (entity.UserName.Length > 80)
            {
                yield return "O nome deve conter no máximo 80 letras.";
            }
            if (string.IsNullOrEmpty(entity.Password))
            {
                yield return "A password é obrigatória.";
            }
            if (entity.Password.Length<8)
            {
                yield return "A password tem de ter pelo menos 8 caracteres.";
            }
        }

        public bool IsValid(Usuario entity)
        {
            return !BrokenRules(entity).Any();
        }
    }
}
