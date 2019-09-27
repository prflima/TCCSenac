using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Find.Models
{
    public class CursoProfessor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("idProfessor")]
        public int idProfessor { get; set; }
        public Professor Professor { get; set; }

        [ForeignKey("idCurso")]
        public int idCurso { get; set;}
        public Curso Curso { get; set; }
    }
}