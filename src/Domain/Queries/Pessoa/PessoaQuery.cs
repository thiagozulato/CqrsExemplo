using System.Collections.Generic;
using System.Linq;

namespace CqrsExemplo
{
  public class PessoaQuery : IPessoaQuery
  {
    private readonly IPessoaRepository _pessoaRepository;
    public PessoaQuery(IPessoaRepository pessoaRepository)
    {
        _pessoaRepository = pessoaRepository;
    }
    public PessoaQueryResult ListaPorId(string id)
    {
      Pessoa pessoa = _pessoaRepository.ListarPorId(id);
      
      return new PessoaQueryResult {
        Id = pessoa.Id,
        Nome = pessoa.Nome,
        Documento = pessoa.Documento
      };
    }

    public List<PessoaQueryResult> ListarTodos()
    {
      return _pessoaRepository.ListarTodos()
                              .Select(pessoa => new PessoaQueryResult {
                                Id = pessoa.Id,
                                Nome = pessoa.Nome,
                                Documento = pessoa.Documento
                              }).ToList();
    }
  }
}