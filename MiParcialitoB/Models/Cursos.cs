namespace MiParcialitoB.Models
{
    public class Cursos
    {
        public int CursoID { get; set; }  
        public required string NombreCurso { get; set; }

       
        public ICollection<Inscripciones> Inscripciones { get; set; }
    }

}
