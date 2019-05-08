using System.Collections.Generic;

namespace CqrsExemplo
{
  public interface IPessoaQuery
  {
    PessoaQueryResult ListaPorId(string id);
    List<PessoaQueryResult> ListarTodos();
  }
}