using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tarea.Models
{
    public class Formulario
    {
        [Key]
        [Required]
        public string Cedula { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }
        [Range(16, 100)]
        public int Edad { get; set; }
        public string Telefono { get; set; }
        [EmailAddress]
        public string Correo { get; set; }
        public bool Genero { get; set; }
        public string Puesto { get; set; }
        [Required]
        public string Foto { get; set; }
        [Required]
        public string Curriculum { get; set; }


        
    }
    public enum Puestos
    {
        Gerente,
        Contable,
        Asistente,
        Secretaria,
        Desarrollador
    }
}