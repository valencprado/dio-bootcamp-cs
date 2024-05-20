using api_desafio.Context;
using api_desafio.Models;
using Microsoft.AspNetCore.Mvc;

namespace api_desafio.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TarefaController : ControllerBase
    {
          private readonly OrganizadorContext _context;

        public TarefaController(OrganizadorContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public IActionResult ObterPorId(int id)
        {
           var tarefa = _context.Tarefas.Find(id);
           if(tarefa == null)
           return NotFound();
            return Ok(tarefa);
        }

        [HttpGet("ObterTodos")]
        public IActionResult ObterTodos()
        {
            var tarefas = _context.Tarefas;
            if(tarefas == null) {
                return NotFound();
            }
            return Ok(tarefas);
        }

        [HttpGet("ObterPorTitulo")]
        public IActionResult ObterPorTitulo(string titulo)
        {
            var tarefas = _context.Tarefas.Where(t => t.Titulo.Contains(titulo));
            if(tarefas.Any()) {
            return Ok(tarefas);
            }
            return NotFound();
        }

        [HttpGet("ObterPorData")]
        public IActionResult ObterPorData(DateTime data)
        {
            var tarefa = _context.Tarefas.Where(x => x.Data.Date == data.Date);
              if(tarefa == null) {
                return NotFound();
            }
            return Ok(tarefa);
        }

        [HttpGet("ObterPorStatus")]
        public IActionResult ObterPorStatus(EnumStatusTarefa status)
        {
            // TODO: Buscar  as tarefas no banco utilizando o EF, que contenha o status recebido por parâmetro
            var tarefa = _context.Tarefas.Where(x => x.Status == status);
              if(tarefa == null || tarefa.Any() == false) {
                return NotFound();
            }
            return Ok(tarefa);
        }

        [HttpPost]
        public IActionResult Criar(Tarefa tarefa)
        {
            if (tarefa.Data == DateTime.MinValue)
                return BadRequest(new { Erro = "A data da tarefa não pode ser vazia" });

           _context.Add(tarefa);
           _context.SaveChanges();
            return CreatedAtAction(nameof(ObterPorId), new { id = tarefa.Id }, tarefa);
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, Tarefa tarefa)
        {
            var tarefaBanco = _context.Tarefas.Find(id);

            if (tarefaBanco == null)
                return NotFound();
            if (tarefa.Data == DateTime.MinValue)
                return BadRequest(new { Erro = "A data da tarefa não pode ser vazia" });
                tarefaBanco.Titulo = tarefa.Titulo;
                tarefaBanco.Data = tarefa.Data;
                tarefaBanco.Status = tarefa.Status;
                tarefaBanco.Descricao = tarefa.Descricao;
                
            _context.Update(tarefaBanco);
            _context.SaveChanges();

            return Ok(tarefaBanco);
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            var tarefaBanco = _context.Tarefas.Find(id);

            if (tarefaBanco == null)
                return NotFound();

          _context.Remove(tarefaBanco);
          _context.SaveChanges();
            return NoContent();
        }
    }
}