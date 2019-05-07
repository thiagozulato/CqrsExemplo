using System;
using System.Collections.Generic;
using System.Linq;
using FluentValidation.Results;

namespace DDDExemplo
{
  public class CommandResult : ICommandResult
  {
    public int Code { get; private set; }

    public string Message { get; private set; }

    public object Data { get; private set; }

    public bool Success { get; private set; }

    public IList<CommandErrorModel> Errors { get; private set; }

    public CommandResult(int code, 
                         bool success,
                         string message,
                         object data,
                         IList<ValidationFailure> errors = null)
    {
      Code = code;
      Success = success;
      Message = message;
      Data = data;
      Errors = FormatErrors(errors);
    }

    private IList<CommandErrorModel> FormatErrors(IList<ValidationFailure> errors)
    {
      if (errors == null) return Array.Empty<CommandErrorModel>();
      
      return errors.Select(e => new CommandErrorModel {
        Key = e.PropertyName,
        Message = e.ErrorMessage
      }).ToList();
    }
  }
}