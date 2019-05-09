using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CqrsExemplo.Controllers
{
    [Route("api/v1/pessoas")]    
    public class PessoasController : ApiBaseController
    {
        private readonly IMediator _mediator;

        public PessoasController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet()]
        public async Task<IActionResult> SelecionarTodos()
        {
            return Ok(await _mediator.Send(new PessoaEmBrancoQuery()));
        }
        
        [HttpGet("{idPessoa}")]
        public async Task<IActionResult> SelecionarPorId(string idPessoa)
        {
            return Ok(await _mediator.Send(new PessoaIdQuery { Id = idPessoa }));
        }
        
        [HttpPost]
        public async Task<IActionResult> AdicionarPessoa([FromBody]AdicionarPessoaCommand pessoa)
        {
            return ApiResponse(await _mediator.Send(pessoa));
        }
    }
}
