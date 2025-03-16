using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Mysqlx;

namespace EstoqueManager.Models
{
    [Table("Cliente")]
    public class Cliente : IdentityUser
    {
        [Key]
        [Required(ErrorMessage = "O Cliente Precisa De Um Id")]
        [StringLength(6, ErrorMessage = "A Quantidade Maxima De Caracteres Deve Ser 6")]
        public int IdCliente { get; set; }

        [Required(ErrorMessage = "O Cliente Precisa Possuir Um Nome")]
        [StringLength(100, ErrorMessage = "O Nome Pode Possuir No Maximo 100 Caracteres")]
        public string Nome { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Data de Nascimento")]
        public DateTime DataNascimento { get; set; }

        [StringLength(300)]
        public string Foto { get; set; }
    }
}