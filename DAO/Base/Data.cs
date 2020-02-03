using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAO.Base
{
    public class Data
    {

        protected SqlConnection con;
        protected SqlCommand cmd;
        protected SqlDataReader dr;

        //Abrir conexao
        protected void AbrirConexao()
        {
            try
            {
                var conString = "Data Source=GW001014;Initial Catalog=SYSMY;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                con = new SqlConnection(conString);
                con.Open();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        protected void FecharConexao()
        {
            try
            {
                con.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
