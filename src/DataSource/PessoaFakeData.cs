using System.Collections.Generic;

namespace CqrsExemplo 
{
    public class PessoaFakeData : IPessoaFakeData
    {
        public List<Pessoa> Dados { get; } = new List<Pessoa>();
    }
}