using ProjetoPaintball.DAO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPaintball.Modelo
{
    class CadTPArmaModel
    {
        //Cria a classe sqlcommand para poder fazer comandos sql.
        SqlCommand cmd = new SqlCommand();

        //Cria o objeto para conexao
        Conexao con = new Conexao();

        //Cria metodo para inserir o tipo de arma
        public bool InserirTPArma(String codTPArma, String nomeTPArma, String descTPArma)
        {
            //Monta a query para inserir um novo usuario
            cmd.CommandText = " INSERT INTO [SGJP_TPARMA] "           +
                                         " ([SGJP_TPARMACOD], "       +
                                          " [SGJP_TPARMANOME], "      +
                                          " [SGJP_TPARMADESC], "      +
                                          " [SGJP_TPARMAPAINTBALL]) " +

                                          " VALUES "       +
                                          "(@codTPArma, "  +
                                          " @nomeTPArma, " +
                                          " @descTPArma, " +
                                          " 0)";

            //Passa as informações pelo parametro           
            cmd.Parameters.AddWithValue("@codTPArma", codTPArma);
            cmd.Parameters.AddWithValue("@nomeTPArma", nomeTPArma);
            cmd.Parameters.AddWithValue("@descTPArma", descTPArma);

            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException)
            {
                return false;
            }
            
        }

        //Cria o metodo para alterar o tipo de arma
        public bool AlterarTPArma(String codTPArma, String nomeTPArma, String descTPArma)
        {
            //Monta a query para inserir um novo usuario
            cmd.CommandText = "UPDATE [SGJP_TPARMA] SET " +

                              //CAMPO             =  VALOR
                              " [SGJP_TPARMANOME] =  @nomeTPArma, " +
                              " [SGJP_TPARMADESC] =  @descTPArma  " +

                              //WHERE                  = VALOR
                              "WHERE [SGJP_TPARMACOD]  =  @codTPArma";

            //Passa as informações pelo parametro           
            cmd.Parameters.AddWithValue("@codTPArma", codTPArma);
            cmd.Parameters.AddWithValue("@nomeTPArma", nomeTPArma);
            cmd.Parameters.AddWithValue("@descTPArma", descTPArma);

            //Inicia a transação
            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException)
            {
                return false;
            }

        }
        
        //Cria o metodo para excluir o tipo da arma
        public bool ExcluirTPArma(String codTPArma)
        {
            //Cria comando SQL para deletar o usuario
            cmd.CommandText = "DELETE FROM SGJP_TPARMA " +
                              "WHERE SGJP_TPARMACOD = @codTPArma";

            //Passa os parametros
            cmd.Parameters.AddWithValue("@codTPArma", codTPArma);

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
