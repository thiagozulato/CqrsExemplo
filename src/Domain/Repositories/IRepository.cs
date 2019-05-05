using System.Collections.Generic;

namespace DDDExemplo
{
  public interface IRepository<T> where T : Entity
  {
    List<T> ListarTodos();
    T ListarPorId(string id);
    void Incluir(T item);
  }
}