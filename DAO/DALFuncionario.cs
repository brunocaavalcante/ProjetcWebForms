using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DALFuncionario : Base.Data
    {

        public List<Funcionario> listarFuncionarios()
        {
            IDataReader reader = null;
            List<Funcionario> listaFuncionarios = new List<Funcionario>();

            var query = @"SELECT * FROM FUNCIONARIO";

            try
            {
                AbrirConexao();
                cmd = new SqlCommand(query, con);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Funcionario funcionario = new Funcionario()
                    {
                        Id = Convert.ToInt32(reader["id"]),
                        Nome = reader["nome"].ToString().Trim(),
                        RG = reader["RG"].ToString().Trim(),
                        CPF = reader["CPF"].ToString().Trim(),
                        Cargo = reader["cargo"].ToString().Trim(),
                        dataNascimento = Convert.ToDateTime(reader["data_nasc"]),
                        Salario = Convert.ToDecimal(reader["salario"]),
                        Administrado = Convert.ToBoolean(reader["adm"])
                    };
                    listaFuncionarios.Add(funcionario);
                }

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                FecharConexao();
            }

            return listaFuncionarios;
        }

        public void InserirFuncionario(Funcionario funcionario)
        {
            try
            {
                AbrirConexao();

                var sql = @"insert into funcionario(
                            nome,RG,CPF,data_nasc,salario,cargo) values(@v1,@v2,@v3,@v4,@v5,@v6)";            

                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@v1", funcionario.Nome);
                cmd.Parameters.AddWithValue("@v2", funcionario.RG);
                cmd.Parameters.AddWithValue("@v3", funcionario.CPF);
                cmd.Parameters.AddWithValue("@v4", funcionario.dataNascimento);
                cmd.Parameters.AddWithValue("@v5", funcionario.Salario);
                cmd.Parameters.AddWithValue("@v6", funcionario.Cargo);                

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao grava funcionario, " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }

        }

        public void UpdateFuncionario(Funcionario funcionario)
        {
            try
            {
                AbrirConexao();

                var sql = @"update funcionario set nome = @v1,RG = @v2 ,CPF = @v3,data_nasc = @v4,salario = @v5,cargo = @v6,adm = @v7
                            where id = @v0";

                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@v0", funcionario.Id);
                cmd.Parameters.AddWithValue("@v1", funcionario.Nome);
                cmd.Parameters.AddWithValue("@v2", funcionario.RG);
                cmd.Parameters.AddWithValue("@v3", funcionario.CPF);
                cmd.Parameters.AddWithValue("@v4", funcionario.dataNascimento);
                cmd.Parameters.AddWithValue("@v5", funcionario.Salario);
                cmd.Parameters.AddWithValue("@v6", funcionario.Cargo);
                cmd.Parameters.AddWithValue("@v7", funcionario.Administrado);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao atualizar funcionario, " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public void deleteFuncionario(Funcionario funcionario)
        {
            try
            {
                AbrirConexao();

                var query = @"delete from funcionario where id = " + funcionario.Id;

                cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao excluir funcionario, " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public Funcionario GetFuncionarioById(int id)
        {
            try
            {
                AbrirConexao();

                var query = @"select * from funcionario where id = " + id;

                cmd = new SqlCommand(query, con);
                dr = cmd.ExecuteReader();
                Funcionario funcionario = new Funcionario();

                if (dr.Read())
                {
                    funcionario.Id = Convert.ToInt32(dr["id"]);
                    funcionario.Nome = dr["nome"].ToString().Trim();
                    funcionario.RG = dr["RG"].ToString().Trim();
                    funcionario.CPF = dr["CPF"].ToString().Trim();
                    funcionario.Cargo = dr["cargo"].ToString().Trim();
                    funcionario.dataNascimento = Convert.ToDateTime(dr["data_nasc"]);
                    funcionario.Salario = Convert.ToDecimal(dr["salario"]);
                    funcionario.Administrado = Convert.ToBoolean(dr["adm"]);
                }
                return funcionario;
            }
            catch (Exception ex)
            {
                throw new Exception("Funcionario não encontrado " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }
    }
}
