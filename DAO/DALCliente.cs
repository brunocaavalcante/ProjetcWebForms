using System;
using System.Collections.Generic;
using Model;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class DALCliente : Base.Data
    {

        public DataTable listarClientes()
        {
            DataTable table = new DataTable();

            try
            {
                AbrirConexao();
                var query = @"SELECT * FROM Cliente";
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

        public void InserirCliente(Cliente Cliente)
        {
            try
            {
                AbrirConexao();

                var sql = @"insert into Cliente(
                            nome,RG,CPF,dataNascimento,pontuacaoCliente) values(@v1,@v2,@v3,@v4,@v5)";

                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@v1", Cliente.Nome);
                cmd.Parameters.AddWithValue("@v2", Cliente.RG);
                cmd.Parameters.AddWithValue("@v3", Cliente.CPF);
                cmd.Parameters.AddWithValue("@v4", Cliente.dataNascimento);
                cmd.Parameters.AddWithValue("@v5", Cliente.PontuacaoCliente);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao grava Cliente, " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }

        }

        public void UpdateCliente(Cliente Cliente)
        {
            try
            {
                AbrirConexao();

                var sql = @"update Cliente set nome = @v1,RG = @v2 ,CPF = @v3,dataNascimento = @v4,pontuacaoCliente = @v5
                            where id = @v0";

                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@v0", Cliente.Id);
                cmd.Parameters.AddWithValue("@v1", Cliente.Nome);
                cmd.Parameters.AddWithValue("@v2", Cliente.RG);
                cmd.Parameters.AddWithValue("@v3", Cliente.CPF);
                cmd.Parameters.AddWithValue("@v4", Cliente.dataNascimento);
                cmd.Parameters.AddWithValue("@v5", Cliente.PontuacaoCliente);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao atualizar Cliente, " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public void deleteCliente(Cliente Cliente)
        {
            try
            {
                AbrirConexao();

                var query = @"delete from Cliente where id = " + Cliente.Id;

                cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao excluir Cliente, " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public Cliente GetClienteById(int id)
        {
            try
            {
                AbrirConexao();

                var query = @"select * from Cliente where id = " + id;

                cmd = new SqlCommand(query, con);
                dr = cmd.ExecuteReader();
                Cliente Cliente = new Cliente();

                if (dr.Read())
                {
                    Cliente.Id = Convert.ToInt32(dr["id"]);
                    Cliente.Nome = dr["nome"].ToString().Trim();
                    Cliente.RG = dr["RG"].ToString().Trim();
                    Cliente.CPF = dr["CPF"].ToString().Trim();
                    Cliente.dataNascimento = Convert.ToDateTime(dr["data_nasc"]);
                    Cliente.PontuacaoCliente = Convert.ToDecimal(dr["pontuacao_cliente"]);
                }
                return Cliente;
            }
            catch (Exception ex)
            {
                throw new Exception("Cliente não encontrado " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }
    }
}
