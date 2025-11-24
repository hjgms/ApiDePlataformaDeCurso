using Microsoft.EntityFrameworkCore;
using EduPay.Entities;

namespace EduPay.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Aluno> Alunos => Set<Aluno>();
        public DbSet<Curso> Cursos => Set<Curso>();
        public DbSet<CursoOnline> CursosOnline => Set<CursoOnline>();
        public DbSet<CursoPresencial> CursosPresencial => Set<CursoPresencial>();
        public DbSet<Matricula> Matriculas => Set<Matricula>();
        public DbSet<Pagamento> Pagamentos => Set<Pagamento>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Curso>()
                .HasDiscriminator<string>("CursoTipo")
                .HasValue<CursoPresencial>("Presencial")
                .HasValue<CursoOnline>("Online");
        }
    }
}