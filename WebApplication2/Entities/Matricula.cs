using System;
using System.Collections.Generic;

namespace EduPay.Entities;

public class Matricula
{
    public int Id { get; set; }
    public int AlunoId { get; set; }
    public Aluno Aluno { get; set; }

    public int CursoId { get; set; }
    public Curso Curso { get; set; }

    public DateTime DataMatricula { get; set; } = DateTime.UtcNow;
    public List<Pagamento> Pagamentos { get; set; } = new();
}