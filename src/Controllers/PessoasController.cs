using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DDDExemplo.Controllers
{
    [Route("api/v1/pessoas")]
    [ApiController]
    public class PessoasController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IPessoaQuery _pessoaQueries;

        public PessoasController(IMediator mediator,
                                 IPessoaQuery pessoaQueries)
        {
            _mediator = mediator;
            _pessoaQueries = pessoaQueries;
        }

        [HttpGet()]
        public IActionResult SelecionarTodos()
        {
            return Ok(_pessoaQueries.ListarTodos());
        }
        
        [HttpGet("{idPessoa}")]
        public IActionResult SelecionarPorId(string idPessoa)
        {
            return Ok(_pessoaQueries.ListaPorId(idPessoa));
        }
        
        [HttpPost]
        public async Task<IActionResult> AdicionarPessoa([FromBody]AdicionarPessoaCommand pessoa)
        {
            return Ok(await _mediator.Send(pessoa));
        }
    }
}
