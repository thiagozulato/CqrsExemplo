using System.Collections.Generic;
using System.Linq;
using FluentValidation.Results;

namespace CqrsExemplo.Domain.Core
{
  public class DomainNotification
  {
    private readonly IList<ValidationFailure> _errors = new List<ValidationFailure>();

    public void AddNotification(string key, string message)
    {
      _errors.Add(new ValidationFailure(key, message));
    }

    public IList<ValidationFailure> GetErrors()
    {
      return _errors.ToList();
    }

    public bool HasErrors()
    {
      return _errors.Any();
    }
  }
}