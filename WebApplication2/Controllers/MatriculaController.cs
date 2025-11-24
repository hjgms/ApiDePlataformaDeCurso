using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using EduPay.Data;
using EduPay.Entities;

namespace EduPay.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MatriculaController : ControllerBase
{
    private readonly DataContext _context;
    public MatriculaController(DataContext context) { _context = context; }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Matricula>>> GetMatriculas() =>
        await _context.Matriculas.Include(m => m.Aluno).Include(m => m.Curso).ToListAsync();

    [HttpPost]
    public async Task<ActionResult<Matricula>> CriarMatricula(Matricula matricula)
    {
        _context.Matriculas.Add(matricula);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetMatriculas), new { id = matricula.Id }, matricula);
    }
}