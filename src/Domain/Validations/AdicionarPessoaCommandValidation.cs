using FluentValidation;

namespace DDDExemplo
{
  public class AdicionarPessoaCommandValidator : AbstractValidator<AdicionarPessoaCommand>
  {
    public AdicionarPessoaCommandValidator()
    {
        RuleFor(c => c.Nome).NotEmpty().WithName("É necessário informar o nome");
        RuleFor(c => c.Documento).NotEmpty().WithMessage("Informe o documento");
    }
  }
}