using FluentValidation.Results;

namespace DDDExemplo {
  public class CommandErrorResult : ICommandResult
  {
    public int Code { get; private set; }

    public string Message { get; private set; }

    public object Data { get; private set; }

    public CommandErrorResult(Command command)
    {
        Code = 1;
        Message = "Validation Error";
        SetDataError(command);
    }

    private void SetDataError(Command command)
    {
      Data = command.ValidationResult.Errors;
    }
  }
}