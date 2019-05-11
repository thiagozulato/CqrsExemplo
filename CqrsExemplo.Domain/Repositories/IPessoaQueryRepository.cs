using System.Collections.Generic;

namespace CqrsExemplo.Domain
{
  public interface IPessoaQueryRepository
  {
    PessoaModel ListarPorId(string id);
    List<PessoaModel> ListarTodos();
  }
}