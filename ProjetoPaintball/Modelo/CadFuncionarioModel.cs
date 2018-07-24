using ProjetoPaintball.DAO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPaintball.Modelo
{
    class CadFuncionarioModel
    {
        //Cria a classe sqlcommand para poder fazer comandos sql.
        SqlCommand cmd = new SqlCommand();

        //Cria o objeto para conexao
        Conexao con = new Conexao();

        //Cria metodo para inserir o funcionário
        public bool InserirFuncionario(String CodFuncionario, String nomeFunc, String FuncCargoCode,
                                       String CPF, String RG, String CNH, String fone, String fone2,
                                       String endereco, String dtCad, String dtDesl)
        {
            cmd.CommandText = "INSERT INTO [dbo].[SGJP_FUNCIONARIO] " +

                                              //Campos
                                              " ([SGJP_FUNCCOD], " +
                                               " [SGJP_FUNCPAINTBALL], " +
                                               " [SGJP_FUNCNOME], " +
                                               " [SGJP_FUNCCARGOCOD], " +
                                               " [SGJP_FUNCCPF], " +
                                               " [SGJP_FUNCRG], " +
                                               " [SGJP_FUNCCNH], " +
                                               " [SGJP_FUNCFONE], " +
                                               " [SGJP_FUNCFONE2], " +
                                               " [SGJP_FUNCENDERECO], " +
                                               " [SGJP_FUNCDTCAD], " +
                                               " [SGJP_FUNCDTDESL]) " +

                                               " VALUES " +

                                               //Valores
                                               "(@CodFuncionario," +
                                               " 0," +
                                               " @nomeFunc, " +
                                               " @FuncCargoCode, " +
                                               " @CPF, " +
                                               " @RG, " +
                                               " @CNH, " +
                                               " @fone, " +
                                               " @fone2, " +
                                               " @endereco, " +
                                               " @dtCad, " +
                                               " @dtDesl) ";
            //Passa os parametros
            cmd.Parameters.AddWithValue("@CodFuncionario", CodFuncionario);
            cmd.Parameters.AddWithValue("@nomeFunc", nomeFunc);
            cmd.Parameters.AddWithValue("@FuncCargoCode", FuncCargoCode);
            cmd.Parameters.AddWithValue("@CPF", CPF);
            cmd.Parameters.AddWithValue("@RG", RG);
            cmd.Parameters.AddWithValue("@CNH", CNH);
            cmd.Parameters.AddWithValue("@fone", fone);
            cmd.Parameters.AddWithValue("@fone2", fone2);
            cmd.Parameters.AddWithValue("@endereco", endereco);
            cmd.Parameters.AddWithValue("@dtCad", dtCad);
            cmd.Parameters.AddWithValue("@dtDesl", dtDesl);

            try
            {
                //Conecta e executa a query
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException)
            {
                return false;
            }
            
         }

        //Cria metodo para alterar o funcionario
        public bool AlterarFuncionario(String CodFuncionario, String nomeFunc, String FuncCargoCode,
                                       String CPF, String RG, String CNH, String fone, String fone2,
                                       String endereco, String dtCad, String dtDesl)
        {
            //Cria comando SQL para deletar o usuario
            cmd.CommandText = "UPDATE [dbo].[SGJP_FUNCIONARIO] "            +

                                   //CAMPOS            = VALORES
                             " SET[SGJP_FUNCPAINTBALL] = 0, "               +
                                " [SGJP_FUNCNOME]      = @nomeFunc, "       +
                                " [SGJP_FUNCCARGOCOD]  = @FuncCargoCode, "  +
                                " [SGJP_FUNCCPF]       = @CPF, "            +
                                " [SGJP_FUNCRG]        = @RG, "             +
                                " [SGJP_FUNCCNH]       = @CNH, "            +
                                " [SGJP_FUNCFONE]      = @fone, "           +
                                " [SGJP_FUNCFONE2]     = @fone2,"           +
                                " [SGJP_FUNCENDERECO]  = @endereco, "       +
                                " [SGJP_FUNCDTCAD]     = @dtCad, "          +
                                " [SGJP_FUNCDTDESL]    = @dtDesl "          +

                                //WHERE CONDIÇÃO          =  VALORES
                                " WHERE SGJP_FUNCCOD      =  @CodFuncionario ";

            //Passa os parametros
            cmd.Parameters.AddWithValue("@CodFuncionario", CodFuncionario);
            cmd.Parameters.AddWithValue("@nomeFunc", nomeFunc);
            cmd.Parameters.AddWithValue("@FuncCargoCode", FuncCargoCode);
            cmd.Parameters.AddWithValue("@CPF", CPF);
            cmd.Parameters.AddWithValue("@RG", RG);
            cmd.Parameters.AddWithValue("@CNH", CNH);
            cmd.Parameters.AddWithValue("@fone", fone);
            cmd.Parameters.AddWithValue("@fone2", fone2);
            cmd.Parameters.AddWithValue("@endereco", endereco);
            cmd.Parameters.AddWithValue("@dtCad", dtCad);
            cmd.Parameters.AddWithValue("@dtDesl", dtDesl);

            try
            {
                cmd.Connection = con.conectar();
                //Executa o comando
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException)
            {
                return false;
            }
        }

        //Cria metodo para excluir o funcionario
        public bool ExcluirFuncionario(String CodFuncionario)
        {
            //Cria comando SQL para deletar o usuario
            cmd.CommandText = "DELETE FROM SGJP_FUNCIONARIO " +
                             " WHERE SGJP_FUNCCOD = @CodFuncionario";

            //Passa os parametros
            cmd.Parameters.AddWithValue("@CodFuncionario", CodFuncionario);

            try
            {
                cmd.Connection = con.conectar();
                //Executa o comando
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (SqlException)
            {
                return false;
            }
        }
    }
}
