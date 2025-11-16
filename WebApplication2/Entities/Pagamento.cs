namespace WebApplication2.Entities;
using System;

public class Pagamento
{
    public int Id { get; set; }
    public DateTime Data { get; set; }
    public Matricula Matricula { get; set; }
    public DateTime Vencimento { get; set; }
}