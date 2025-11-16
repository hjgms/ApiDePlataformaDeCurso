using System;

namespace WebApplication2.Entities;

public class Matricula
{
    public int Id { get; set; }
    public DateTime Data { get; set; }
    public Curso Curso { get; set; }
    public Aluno Aluno { get; set; }
    public bool Ativo { get; set; }
}