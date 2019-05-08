using System;
using System.Collections.Generic;
using System.Linq;

namespace CqrsExemplo
{
  public class PessoaRepository : IPessoaRepository
  {
    private readonly List<Pessoa> Dados = new List<Pessoa>();

    public List<Pessoa> ListarTodos()
    {
      return Dados;
    }

    public Pessoa ListarPorId(string id)
    {
      return Dados.Where(p => p.Id == id).FirstOrDefault();
    }

    public void Incluir(Pessoa pessoa)
    {
      Dados.Add(pessoa);
    }
  }
}