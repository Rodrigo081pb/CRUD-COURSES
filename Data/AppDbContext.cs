using Microsoft.EntityFrameworkCore;
using CRUD_ENDPOINT_CURSOS.Models;

namespace CRUD_ENDPOINT_CURSOS.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Aluno> Alunos { get; set; }
    }


}
