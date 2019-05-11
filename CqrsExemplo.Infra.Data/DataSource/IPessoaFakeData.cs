using System.Collections.Generic;
using CqrsExemplo.Domain;

namespace CqrsExemplo.Infra.Data
{
    public interface IPessoaFakeData
    {
        List<Pessoa> Dados { get; }
    }
}