namespace DDDExemplo {
  public interface ICommandResult
  {
      int Code { get; }
      string Message { get; }
      object Data { get; }
  }
}