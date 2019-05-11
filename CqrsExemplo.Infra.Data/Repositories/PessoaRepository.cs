using System;
using System.Collections.Generic;
using System.Linq;
using CqrsExemplo.Domain;

namespace CqrsExemplo.Infra.Data
{
    public class PessoaRepository : IPessoaRepository
    {
        private readonly IPessoaFakeData _fakeData;
        public PessoaRepository(IPessoaFakeData fakeData)
        {
            _fakeData = fakeData;
        }

        public void Incluir(Pessoa pessoa)
        {
            _fakeData.Dados.Add(pessoa);
        }
    }
}