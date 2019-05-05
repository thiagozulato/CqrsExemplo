namespace DDDExemplo
{
  public class CommandResult : ICommandResult
  {
    public int Code { get; private set; }

    public string Message { get; private set; }

    public object Data { get; private set; }

    public CommandResult(int code, string message, object data)
    {
      Code = code;
      Message = message;
      Data = data;
    }
  }
}