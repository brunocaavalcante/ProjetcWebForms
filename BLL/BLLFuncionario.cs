using Model;
using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO.Base;

namespace BLL
{
    public class BLLFuncionario
    {
        public List<Funcionario> ListarFuncionarios()
        {
            return new DALFuncionario().listarFuncionarios();
        }
        public Funcionario GetFuncionarioById(int id)
        {
            return new DALFuncionario().GetFuncionarioById(id);
        }
        public void InserirFuncionario(Funcionario funcionario)
        {
            new DALFuncionario().InserirFuncionario(funcionario);
        }
        public void UpdateFuncionario(Funcionario funcionario)
        {
            new DALFuncionario().UpdateFuncionario(funcionario);
        }
        public void DeleteFuncionario(Funcionario funcionario)
        {
            new DALFuncionario().deleteFuncionario(funcionario);
        }
        public bool validaDados(Funcionario funcionario)
        {
            if (funcionario != null)
            {
                if (funcionario.dataNascimento == Convert.ToDateTime("01/01/0001 00:00:00"))
                {
                    // funcionario.dataNascimento = null;
                }
            }
            return true;
        }
    }
}
