using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EduPay.Data;
using System.Threading.Tasks;
using EduPay.Entities;

namespace EduPay.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PagamentoController : ControllerBase
{
    private readonly DataContext _context;
    public PagamentoController(DataContext context) { _context = context; }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Pagamento>>> GetPagamentos() =>
        await _context.Pagamentos.Include(p => p.Matricula).ThenInclude(m => m!.Aluno).ToListAsync();

    [HttpPost]
    public async Task<ActionResult<Pagamento>> CriarPagamento(Pagamento pagamento)
    {
        _context.Pagamentos.Add(pagamento);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetPagamentos), new { id = pagamento.Id }, pagamento);
    }
}