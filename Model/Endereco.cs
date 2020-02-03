using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Endereco
    {
        protected int Id { get; set; }
        protected int IdUsuario { get; set; }
        protected string Cidade { get; set; }
        protected string Pais { get; set; }
        protected string Logradouro { get; set; }
        protected string CEP { get; set; }
        protected string Complemento { get; set; }
        protected int Numero { get; set; }
    }
}
