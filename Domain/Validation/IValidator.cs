using System.Collections;
using System.Collections.Generic;

namespace Domain.Validation
{
    public interface IValidator<T> where T:class
    {
        bool IsValid(T entity);
        IEnumerable<string> BrokenRules(T entity);
    }
}
