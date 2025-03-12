using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EstoqueManager.Models
{
    public class Cliente_Foto
    {
        [Key]
        public int FotoId { get; set; }

        [Required(ErrorMessage = "O Id Precisa Ser Informado")]
        public int Id { get; set; }

        [ForeignKey(nameof(Cliente))]
        public Cliente Cliente {get; set;}

    }
}