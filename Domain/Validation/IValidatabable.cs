using System.Collections.Generic;

namespace Domain.Validation
{
    public interface IValidatabable<T> where T:class
    {
        bool Validate(IValidator<T> validator, out IEnumerable<string> brokenRules);
    }
}
