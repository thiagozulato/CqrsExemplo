using System.Collections.Generic;

namespace CqrsExemplo
{
  public interface IPessoaQueryRepository
  {
    PessoaModel ListarPorId(string id);
    List<PessoaModel> ListarTodos();
  }
}