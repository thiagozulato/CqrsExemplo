using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace DDDExemplo
{
  public class AdicionarPessoaCommandHandler : IRequestHandler<AdicionarPessoaCommand, ICommandResult>
  {
    private readonly IPessoaRepository _pessoaRepository;
    private readonly IMediator _mediator;

    public AdicionarPessoaCommandHandler(
      IPessoaRepository pessoaRepository,
      IMediator mediator
    )
    {
      _pessoaRepository = pessoaRepository;
      _mediator = mediator;
    }
    public Task<ICommandResult> Handle(AdicionarPessoaCommand command, CancellationToken cancellationToken)
    {
      if (!command.IsValid())
      {
        return Task.FromResult<ICommandResult>(new CommandErrorResult(command));
      }

      var pessoa = new Pessoa(command.Nome, command.Documento);
      _pessoaRepository.Incluir(pessoa);

      // Comunica evento
      _mediator.Publish(new NovaPessoaAdicionadaEvent(
          pessoa.Id,
          pessoa.Nome,
          pessoa.Documento), cancellationToken);

      return Task.FromResult<ICommandResult>(new CommandResult(0, string.Empty, new { Id = pessoa.Id }));
    }
  }
}