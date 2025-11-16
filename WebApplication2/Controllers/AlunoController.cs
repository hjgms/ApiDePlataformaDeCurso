using System.Collections.Generic;
using WebApplication2.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Data;
using System.Threading.Tasks;

namespace WebApplication2.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AlunoController: ControllerBase
{
    private readonly DataContext _context;

    public AlunoController(DataContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Aluno>>> GetAlunos()
    {
        return await _context.Alunos.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Aluno?>> GetAluno(int id)
    {
        return await _context.Alunos.FindAsync(id);
    }
}