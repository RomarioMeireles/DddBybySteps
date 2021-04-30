using Domain.Models;
using Domain.Validation.Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace DomainTests
{
    [TestClass]
    public class ClienteValidatorTests
    {
        [TestMethod]
        public void NomeObrigatorio()
        {
            var cliente = new Cliente(string.Empty, "Masculino", new Domain.ValueObject.Email("romario-etical@hotmail.com"),
                new Domain.ValueObject.Endereco("Cabolombo", "Rua do Patriota", "117"));
            var validator = new ClienteLogicValidator();
            IEnumerable<string> BrokenRules;
            bool isValid = cliente.Validate(validator, out BrokenRules);
            string ErrorMessage = string.Empty;
            if (!isValid)
            {
                foreach (var item in BrokenRules)
                {
                    ErrorMessage = item;
                    break;
                }
            }
            Assert.AreEqual("O nome é obrigatório.",ErrorMessage);
        }
        [TestMethod]
        public void NomeDeveConterPeloMenos10Letras()
        {
            var cliente = new Cliente("Romário", "Masculino", new Domain.ValueObject.Email("romario-etical@hotmail.com"),
                new Domain.ValueObject.Endereco("Cabolombo", "Rua do Patriota", "117"));
            var validator = new ClienteLogicValidator();
            IEnumerable<string> BrokenRules;
            bool isValid = cliente.Validate(validator, out BrokenRules);
            string ErrorMessage = string.Empty;
            if (!isValid)
            {
                foreach (var item in BrokenRules)
                {
                    ErrorMessage = item;
                    break;
                }
            }
            Assert.AreEqual("O nome deve conter pelo menos 10 letras.", ErrorMessage);
        }
        public void NomeDeveConterNoMaximo50Letras()
        {
            var cliente = new Cliente("Romário mvuireghriognrobheroihnroihnerohneroihneriohenthnothmetinnifwnroeng", "Masculino", new Domain.ValueObject.Email("romario-etical@hotmail.com"),
                new Domain.ValueObject.Endereco("Cabolombo", "Rua do Patriota", "117"));
            var validator = new ClienteLogicValidator();
            IEnumerable<string> BrokenRules;
            bool isValid = cliente.Validate(validator, out BrokenRules);
            string ErrorMessage = string.Empty;
            if (!isValid)
            {
                foreach (var item in BrokenRules)
                {
                    ErrorMessage = item;
                    break;
                }
            }
            Assert.AreEqual("O nome deve conter no máximo 50 letras.", ErrorMessage);
        }
        public void SexoEObrigatorio()
        {
            var cliente = new Cliente("Romário  Meireles",string.Empty, new Domain.ValueObject.Email("romario-etical@hotmail.com"),
                new Domain.ValueObject.Endereco("Cabolombo", "Rua do Patriota", "117"));
            var validator = new ClienteLogicValidator();
            IEnumerable<string> BrokenRules;
            bool isValid = cliente.Validate(validator, out BrokenRules);
            string ErrorMessage = string.Empty;
            if (!isValid)
            {
                foreach (var item in BrokenRules)
                {
                    ErrorMessage = item;
                    break;
                }
            }
            Assert.AreEqual("O nome deve conter no máximo 50 letras.", ErrorMessage);
        }
    }
}
