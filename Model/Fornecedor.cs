using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class Fornecedor: Pessoa
    {
        public string CNPJ {get;set;}
        public string RazaoSocial { get;set; }
        public string TelefoneEmpresa { get; set; }
    }
}
