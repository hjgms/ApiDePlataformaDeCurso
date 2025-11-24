using System.Collections;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using EduPay.Data;
using EduPay.Entities;

namespace EduPay.Controllers;
    
[Route("api/[controller]")]
[ApiController]
public class CursoController : ControllerBase
{
    private readonly DataContext _context;
    public CursoController(DataContext context) { _context = context; }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Curso>>> GetCursos() =>
        await _context.Cursos.ToListAsync();

    [HttpGet("{id}")]
    public async Task<ActionResult<Curso?>> GetCurso(int id)
    {
        var curso = await _context.Cursos.FindAsync(id);
        return curso == null ? NotFound() : curso;
    }

    [HttpPost]
    public async Task<ActionResult<Curso>> CriarCurso(Curso curso)
    {
        _context.Cursos.Add(curso);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetCurso), new { id = curso.Id }, curso);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> AtualizarCurso(int id, Curso curso)
    {
        if (id != curso.Id) return BadRequest();
        _context.Entry(curso).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeletarCurso(int id)
    {
        var curso = await _context.Cursos.FindAsync(id);
        if (curso == null) return NotFound();
        _context.Cursos.Remove(curso);
        await _context.SaveChangesAsync();
        return NoContent();
    }
}