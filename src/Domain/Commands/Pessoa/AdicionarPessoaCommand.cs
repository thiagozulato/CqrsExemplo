namespace CqrsExemplo
{
  public class AdicionarPessoaCommand: Command
  {
      public string Nome { get; set; }
      public string Documento { get; set; }

      public override bool IsValid()
      {
        ValidationResult = new AdicionarPessoaCommandValidator().Validate(this);
        return ValidationResult.IsValid;
      }
  }
}