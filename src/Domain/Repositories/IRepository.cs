using System.Collections.Generic;

namespace CqrsExemplo
{
  public interface IRepository<T> where T : Entity
  {
    void Incluir(T item);
  }
}