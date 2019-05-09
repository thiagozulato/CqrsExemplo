using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace CqrsExemplo
{
  public class PessoaQueryHandler:
    IRequestHandler<PessoaEmBrancoQuery, List<PessoaModel>>,
    IRequestHandler<PessoaIdQuery, PessoaModel>
  {
    private readonly IPessoaQueryRepository _pessoaRepository;
    public PessoaQueryHandler(IPessoaQueryRepository pessoaRepository)
    {
        _pessoaRepository = pessoaRepository;
    }

    public Task<PessoaModel> Handle(PessoaIdQuery request, CancellationToken cancellationToken)
    {
        return Task.FromResult(_pessoaRepository.ListarPorId(request.Id));
    }

    public Task<List<PessoaModel>> Handle(PessoaEmBrancoQuery request, CancellationToken cancellationToken)
    {
        return Task.FromResult(_pessoaRepository.ListarTodos());
    }
  }
}