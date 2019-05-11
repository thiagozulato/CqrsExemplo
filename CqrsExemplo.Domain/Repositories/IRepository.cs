using System.Collections.Generic;
using CqrsExemplo.Domain.Core;

namespace CqrsExemplo.Domain
{
  public interface IRepository<T> where T : Entity
  {
    void Incluir(T item);
  }
}