using System.Collections.Generic;
using CqrsExemplo.Domain;

namespace CqrsExemplo.Infra.Data 
{
    public class PessoaFakeData : IPessoaFakeData
    {
        public List<Pessoa> Dados { get; } = new List<Pessoa>();
    }
}