using Microsoft.AspNetCore.Mvc;

namespace CqrsExemplo
{

  [ApiController]
  public class ApiBaseController : ControllerBase
  {
    [NonAction]
    public IActionResult ApiResponse(ICommandResult command)
    {
      if (command.Success)
      {
        return Ok(new
        {
          Success = true,
          Message = command.Message,
          Data = command.Data
        });
      }

      return BadRequest(new
      {
        Success = false,
        Message = command.Message,
        Errors = command.Errors
      });
    }
  }
}