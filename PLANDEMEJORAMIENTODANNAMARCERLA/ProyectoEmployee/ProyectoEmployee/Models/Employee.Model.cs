using Swashbuckle.AspNetCore.Annotations;
using System.ComponentModel.DataAnnotations;

namespace Empleados.Models
{
    public class Employee
    {

        [Key]
        public int Id { get; set; }

        public string Nam_Employe { get; set; }

        public string Las_Employe { get; set; }

        public string Pos_Employe { get; set; }

        public DateTime DatEmploye { get; set; } = DateTime.Now;

    }
}
