using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EstoqueManager.Models
{
    [Table("Produto")]
    public class Produto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]

        [StringLength (5, ErrorMessage = "A Quantidade não pode ser inferior a 0")]
        [Required(ErrorMessage = "Informe a Quantidade")]
        public int Quantidade {get; set; }


        [Required(ErrorMessage = "Informe O Id")]
        [StringLength(5, ErrorMessage = "O Produto Deve Ter No Maximo 5 Caracteres De Identificação")]
        public int ProdutoId { get; set; }


        [Required(ErrorMessage = "Informe A Descrição")]
        [StringLength(1000, ErrorMessage = "O Produto Pode Ter No Maximo 1000 Caracteres De Descrição")]
        public string Descricao  { get; set; }


        [Required(ErrorMessage = "Informe O Nome Do Produto")]
        [StringLength(50, ErrorMessage = "O Nome Do Produto Deve Possuir No Maximo 50 Caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe o Numero Do Produto")]
        public int Numero { get; set; }
    }
}