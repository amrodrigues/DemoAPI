using DemoAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AlunoController : ControllerBase
    {
       

        [HttpGet("alunos")]
        public Aluno GetAlunos()
        {

            return new Aluno
            {
                Nome = "Anna Maria",
                Ativo = true,
                DataCadastro = DateTime.Now,
                Email = "teste@gmail.com",
                Id = 1
            };
        }

    }
}
