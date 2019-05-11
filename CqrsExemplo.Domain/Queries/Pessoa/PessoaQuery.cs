using System.Collections.Generic;
using MediatR;

namespace CqrsExemplo.Domain
{
    public class PessoaIdQuery : IRequest<PessoaModel>
    {
        public string Id { get; set; }
    }

    public class PessoaEmBrancoQuery : IRequest<List<PessoaModel>> { }
}