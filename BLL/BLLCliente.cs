using DAO;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLCliente
    {
        public DataTable ListarClientes()
        {
            return new DALCliente().listarClientes();
        }
        public Cliente GetClienteById(int id)
        {
            return new DALCliente().GetClienteById(id);
        }
        public void InserirCliente(Cliente Cliente)
        {
            new DALCliente().InserirCliente(Cliente);
        }
        public void UpdateCliente(Cliente Cliente)
        {
            new DALCliente().UpdateCliente(Cliente);
        }
        public void DeleteCliente(Cliente Cliente)
        {
            new DALCliente().deleteCliente(Cliente);
        }
    }
}
