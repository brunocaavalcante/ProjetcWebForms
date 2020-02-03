using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Cliente : Pessoa
    {
        public decimal PontuacaoCliente { get; set; }
        public bool Ativo { get; set; }

    }
}
