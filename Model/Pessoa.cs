using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Pessoa
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatorio!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatorio!")]
        public string RG { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatorio!")]
        public string CPF { get; set; }

        [Display(Name = "Data de Nascimento")]
        [Required(ErrorMessage = "A data de nascimento é obrigatória!")]
        public DateTime dataNascimento { get; set; }
    }
}
