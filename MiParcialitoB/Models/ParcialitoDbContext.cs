using Microsoft.EntityFrameworkCore;

namespace MiParcialitoB.Models
{
    public class ParcialitoDbContext : DbContext
    {
        public ParcialitoDbContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(@"Server=qa.negociostecnologicos.net;Database=PB100221;User Id=desarrolloWebUfg;Password=<BTj$jrrLV2~-4Yp1vT-;Port=3306;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Inscripciones>()
                .HasKey(i => new { i.EstudianteID, i.CursoID });

            modelBuilder.Entity<Inscripciones>()
                .HasOne(i => i.Estudiante)
                .WithMany(e => e.Inscripciones)
                .HasForeignKey(i => i.EstudianteID);

            modelBuilder.Entity<Inscripciones>()
                .HasOne(i => i.Curso)
                .WithMany(c => c.Inscripciones)
                .HasForeignKey(i => i.CursoID);

            modelBuilder.Entity<Cursos>()
                .HasKey(c => c.CursoID);

            modelBuilder.Entity<Estudiantes>()
                .HasKey(e => e.EstudianteID);
        }

        public DbSet<Estudiantes> Estudiantes { get; set; }
        public DbSet<Inscripciones> Inscripciones { get; set; }
        public DbSet<Cursos> Cursos { get; set; }
    }
}
