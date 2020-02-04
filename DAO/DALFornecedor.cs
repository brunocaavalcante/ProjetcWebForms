using BLL.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DALFornecedor : Base.Data
    {
        public DataTable listarFornecedores()
        {
            DataTable table = new DataTable();

            try
            {
                AbrirConexao();
                var query = @"select f.id,f.id_pessoa,f.RazaoSocial,f.CNPJ,f.TelefoneEmpresa,p.nome from fornecedor as f 
                              left join pessoa as p on p.id = f.id_pessoa";

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, con);
                sqlDataAdapter.Fill(table);

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                FecharConexao();
            }

            return table;
        }

        public void InserirFornecedor(Fornecedor Fornecedor)
        {
            try
            {
                AbrirConexao();

                var sql = @"insert into fornecedor(
                            RazaoSocial,CNPJ,TelefoneEmpresa) values(@v1,@v2,@v3)";

                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@v1", Fornecedor.RazaoSocial);
                cmd.Parameters.AddWithValue("@v2", Fornecedor.CNPJ);
                cmd.Parameters.AddWithValue("@v3", Fornecedor.TelefoneEmpresa);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao grava Fornecedor, " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }

        }

        public void UpdateFornecedor(Fornecedor Fornecedor)
        {
            try
            {
                AbrirConexao();

                var sql = @"update Fornecedor set RazaoSocial = @v1,CNPJ = @v2 ,TelefoneEmpresa = @v3
                            where id = @v0";

                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@v0", Fornecedor.Id);
                cmd.Parameters.AddWithValue("@v1", Fornecedor.RazaoSocial);
                cmd.Parameters.AddWithValue("@v2", Fornecedor.CNPJ);
                cmd.Parameters.AddWithValue("@v3", Fornecedor.TelefoneEmpresa);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao atualizar Fornecedor, " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public void deleteFornecedor(Fornecedor Fornecedor)
        {
            try
            {
                AbrirConexao();

                var query = @"delete from Fornecedor where id = " + Fornecedor.Id;

                cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao excluir Fornecedor, " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public Fornecedor GetFornecedorById(int id)
        {
            try
            {
                AbrirConexao();

                var query = @"select * from Fornecedor where id = " + id;

                cmd = new SqlCommand(query, con);
                dr = cmd.ExecuteReader();
                Fornecedor Fornecedor = new Fornecedor();

                if (dr.Read())
                {
                    Fornecedor.Id = Convert.ToInt32(dr["id"]);
                    Fornecedor.Nome = dr["nome"].ToString().Trim();
                    Fornecedor.RG = dr["RG"].ToString().Trim();
                    Fornecedor.CPF = dr["CPF"].ToString().Trim();
                    Fornecedor.dataNascimento = Convert.ToDateTime(dr["data_nasc"]);
                }
                return Fornecedor;
            }
            catch (Exception ex)
            {
                throw new Exception("Fornecedor não encontrado " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

    }
}
