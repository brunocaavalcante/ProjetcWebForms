using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Models;
using DAO;

namespace BLL
{
    public class BLLFornecedor
    {
        public DataTable ListarFornecedores()
        {
            return new DALFornecedor().listarFornecedores();
        }
        public Fornecedor GetFornecedorById(int id)
        {
            return new DALFornecedor().GetFornecedorById(id);
        }
        public void InserirFornecedor(Fornecedor Fornecedor)
        {
            new DALFornecedor().InserirFornecedor(Fornecedor);
        }
        public void UpdateFornecedor(Fornecedor Fornecedor)
        {
            new DALFornecedor().UpdateFornecedor(Fornecedor);
        }
        public void DeleteFornecedor(Fornecedor Fornecedor)
        {
            new DALFornecedor().deleteFornecedor(Fornecedor);
        }

    }
}
