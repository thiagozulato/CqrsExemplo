using FluentValidation.Results;
using Newtonsoft.Json;
using MediatR;

namespace DDDExemplo
{
  public abstract class Command : IRequest<ICommandResult>
  {
    [JsonIgnore]
    public ValidationResult ValidationResult { get; set; }
    public abstract bool IsValid();
  }
}