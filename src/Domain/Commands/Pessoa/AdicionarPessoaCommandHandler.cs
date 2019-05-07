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
        return Task.FromResult<ICommandResult>(new CommandResult(
          1,
          false,
          "Erro de Validação",
          null,
          command.ValidationResult.Errors
        ));
      }

      var pessoa = new Pessoa(command.Nome, command.Documento);
      pessoa.AlterarNome(""); // força um erro

      if (pessoa.HasErrors())
      {
        return Task.FromResult<ICommandResult>(new CommandResult(
          2, 
          false,
          "Erro de Entidade",
          null,
          pessoa.GetErrors()
        ));
      }
      
      _pessoaRepository.Incluir(pessoa);

      // Comunica evento
      _mediator.Publish(new NovaPessoaAdicionadaEvent(
          pessoa.Id,
          pessoa.Nome,
          pessoa.Documento), cancellationToken);

      return Task.FromResult<ICommandResult>(new CommandResult(0, true, string.Empty, new { Id = pessoa.Id }));
    }
  }
}