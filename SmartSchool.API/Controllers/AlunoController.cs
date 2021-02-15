using Microsoft.AspNetCore.Mvc;
using SmartSchool.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SmartSchool.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        public List<Aluno> Alunos = new List<Aluno>()
        {
            new Aluno(){
                Id = 1,
                Nome = "Marcos",
                Sobrenome = "Almeida",
                Telefone = "12345987"
            },
            new Aluno(){
                Id = 2,
                Nome = "João",
                Sobrenome = "Flavio",
                Telefone = "18469498"
            },
            new Aluno(){
                Id = 3,
                Nome = "Alfredo",
                Sobrenome = "Augusto",
                Telefone = "987216554"
            }
        };

        // GET: api/aluno
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Alunos);
        }


        // api/aluno/byId
        [HttpGet("byId/{id}")]
        public IActionResult GetbyId(int id)
        {
            var aluno = Alunos.FirstOrDefault(a => a.Id == id);
            if (aluno == null) return BadRequest("Aluno não encontrado!");

            return Ok(aluno);
        }

        // api/aluno/byName?nome=<nome>&sobrenome=<sobrenome>
        [HttpGet("ByName")]
        public IActionResult GetbyName(string nome, string sobrenome)
        {
            var aluno = Alunos.FirstOrDefault(a => 
                a.Nome.Contains(nome) && a.Sobrenome.Contains(sobrenome)
                );
            if (aluno == null) return BadRequest("Aluno não encontrado!");

            return Ok(aluno);
        }


        // api/aluno
        [HttpPost]
        public IActionResult Post(Aluno aluno)
        {
            return Ok(aluno);
        }

        // api/aluno
        [HttpPut("{id}")]
        public IActionResult Put(int Id, Aluno aluno)
        {
            return Ok(aluno);
        }

        // api/aluno
        [HttpPatch("{id}")]
        public IActionResult Patch(int Id, Aluno aluno)
        {
            return Ok(aluno);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int Id)
        {
            return Ok();
        }

        //// GET api/<AlunoController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<AlunoController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<AlunoController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<AlunoController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
