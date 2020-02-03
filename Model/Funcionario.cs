using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Funcionario:Pessoa
    {
        public decimal Salario { get; set; }
        public string Cargo { get; set; }
        public bool Administrado { get; set; }
    }
}
