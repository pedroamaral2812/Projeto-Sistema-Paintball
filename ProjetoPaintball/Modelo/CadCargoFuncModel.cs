using ProjetoPaintball.DAO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPaintball.Modelo
{
    class CadCargoFuncModel
    {
        //Cria a classe sqlcommand para poder fazer comandos sql.
        SqlCommand cmd = new SqlCommand();

        //Cria o objeto para conexao
        Conexao con = new Conexao();

        

        //Cria metodo para inserir o cargo do funcionário
        public bool IncluirCargoFuncionario(String codCargoFunc, 
                                            String nomeCargo, 
                                            String DescCargo)
        {
            //Monta a query para inserir um novo usuario
            cmd.CommandText = "INSERT INTO [dbo].[SGJP_CARGOFUNC] " +
                              "([SGJP_CARGOFUNCCOD], " +
                              "[SGJP_CARGOFUNCNOME], " +
                              "[SGJP_CARGOFUNCDESC], " +
                              "[SGJP_CARGOFUNCPAINTBALL]) " +

                                " VALUES " +

                              "(@CodCargoFunc, " +
                              "@nomeCargoFunc, " +
                              "@descCargoFunc, " +
                              "0)";
                              
            //Passa as informações pelo parametro           
            cmd.Parameters.AddWithValue("@CodCargoFunc", codCargoFunc);
            cmd.Parameters.AddWithValue("@nomeCargoFunc", nomeCargo);
            cmd.Parameters.AddWithValue("@descCargoFunc", DescCargo);
            //cmd.Parameters.AddWithValue("@paintball", paintball);

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

        //Cria o metodo para alterar as informações da tabela de cadastro de função/cargo de funcionario
        public bool AlterarCargoFuncionario(String codCargoFunc, 
                                            String nomeCargo, 
                                            String DescCargo)
        {
            //Monta a query para atualizar um novo usuario
            cmd.CommandText = "UPDATE [SGJP_CARGOFUNC] SET " +

                              //CAMPOS              = VALORES
                              "[SGJP_CARGOFUNCNOME] = @nomeCargo, " +
                              "[SGJP_CARGOFUNCDESC] = @DescCargo  " +

                              //WHERE CONDIÇÃO          =  VALORES
                              " WHERE SGJP_CARGOFUNCCOD =  @codCargoFunc";

            //Passa as informações pelo parametro           
            cmd.Parameters.AddWithValue("@codCargoFunc", codCargoFunc);
            cmd.Parameters.AddWithValue("@nomeCargo", nomeCargo);
            cmd.Parameters.AddWithValue("@DescCargo", DescCargo);
            
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

        //Cria o metodo para excluir o usuario 
        public bool ExcluirCargoFuncionario(String codCargoFunc)
        {
            //Cria comando SQL para deletar o usuario
            cmd.CommandText = "DELETE FROM SGJP_CARGOFUNC " +
                              "WHERE SGJP_CARGOFUNCCOD = @codCargoFunc";

            //Passa os parametros
            cmd.Parameters.AddWithValue("@codCargoFunc", codCargoFunc);

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
