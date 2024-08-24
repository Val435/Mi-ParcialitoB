namespace MiParcialitoB.Models
{
    public class Estudiantes
    {
        public int EstudianteID { get; set; }  
        public required string Nombre { get; set; }

       
        public ICollection<Inscripciones> Inscripciones { get; set; }
    }

}
