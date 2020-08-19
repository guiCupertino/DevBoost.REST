using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevBoost.REST.Domain.Services;
using DevBoost.REST.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DevBoost.REST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        private readonly IServiceAluno _serviceAluno;

        public AlunoController(IServiceAluno serviceAluno)
        {
            _serviceAluno = serviceAluno;
        }

        [HttpGet]
        [Route("get")]
        public async Task<IActionResult> Get()
        {            
            return Ok(await _serviceAluno.Get());
        }

        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> Create(AlunoModel alunoModel)
        {
            var result = await _serviceAluno.Create(new Domain.Entidade.Aluno { Name = alunoModel.Name, Email = alunoModel.Email });

            if (result)
                return Ok();

            return BadRequest(new { Succes = false });
        }

        [HttpPut]
        [Route("update")]
        public async Task<IActionResult> Update(AlunoModel alunoModel)
        {
            var result = await _serviceAluno.Update(new Domain.Entidade.Aluno { Name = alunoModel.Name, Email = alunoModel.Email });

            if (result)
                return Ok();

            return BadRequest(new { Succes = false });
        }

        [HttpDelete]
        [Route("delete")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _serviceAluno.Delete(id);

            if (result)
                return Ok();

            return BadRequest(new { Succes = false });
        }

    }
}