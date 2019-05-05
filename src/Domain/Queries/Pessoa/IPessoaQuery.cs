using System.Collections.Generic;

namespace DDDExemplo
{
  public interface IPessoaQuery
  {
    PessoaQueryResult ListaPorId(string id);
    List<PessoaQueryResult> ListarTodos();
  }
}