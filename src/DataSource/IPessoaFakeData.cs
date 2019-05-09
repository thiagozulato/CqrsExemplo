using System.Collections.Generic;

namespace CqrsExemplo
{
    public interface IPessoaFakeData
    {
        List<Pessoa> Dados { get; }
    }
}