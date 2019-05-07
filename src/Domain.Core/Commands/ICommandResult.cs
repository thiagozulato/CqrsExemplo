using System.Collections.Generic;
using FluentValidation.Results;

namespace DDDExemplo
{
  public interface ICommandResult
  {
    int Code { get; }
    string Message { get; }
    object Data { get; }
    bool Success { get; }
    IList<CommandErrorModel> Errors { get; }
  }
}