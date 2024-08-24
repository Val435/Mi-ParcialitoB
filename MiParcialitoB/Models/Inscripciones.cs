namespace MiParcialitoB.Models
{
    public class Inscripciones
    {
        public int EstudianteID { get; set; }  
        public int CursoID { get; set; }       

        public Estudiantes Estudiante { get; set; }  
        public Cursos Curso { get; set; }            
    }

}
