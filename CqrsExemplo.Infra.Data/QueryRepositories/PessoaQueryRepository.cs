using System.Collections.Generic;
using System.Linq;
using CqrsExemplo.Domain;

namespace CqrsExemplo.Infra.Data
{
    public class PessoaQueryRepository : IPessoaQueryRepository
    {
        private readonly IPessoaFakeData _fakeData;

        public PessoaQueryRepository(IPessoaFakeData fakeData)
        {
            _fakeData = fakeData;
        }

        public PessoaModel ListarPorId(string id)
        {
            return _fakeData.Dados.Where(p => p.Id == id)
                                  .Select(p => new PessoaModel {
                                      Id = p.Id,
                                      Nome = p.Nome,
                                      Documento = p.Documento
                                  })
                                  .FirstOrDefault();
        }

        public List<PessoaModel> ListarTodos()
        {
            return _fakeData.Dados.Select(pessoa => new PessoaModel {
                                Id = pessoa.Id,
                                Nome = pessoa.Nome,
                                Documento = pessoa.Documento
                              }).ToList();
        }
    }
}