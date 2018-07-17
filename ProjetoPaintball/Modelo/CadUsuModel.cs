using ProjetoPaintball.DAO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPaintball.Modelo
{
    class CadUsuModel
    {
        //Cria a classe sqlcommand para poder fazer comandos sql.
        SqlCommand cmd = new SqlCommand();

        //Cria o objeto para conexao
        Conexao con = new Conexao();

        //Cria o objeto para receber o dataReader
        SqlDataReader dr;

        //Cria metodo para inserir o usuario
        public bool IncluirUsuario(String codUsu, String login, String senha, 
                                   String nome, String email, String paintball, 
                                   String fone, String fone2, String CPF, String RG)
        {
            //Monta a query para verificar se existe o usuario
            cmd.CommandText = "SET IDENTITY_INSERT SGJP_USUARIO on " +
                              "INSERT INTO[dbo].[SGJP_USUARIO] " +
                                "([SGJP_USUID], "        +
                                 "[SGJP_USULOGIN], "     +
                                 "[SGJP_USUSENHA], "     +
                                 "[SGJP_USUNOME], "      +
                                 "[SGJP_USUEMAIL], "     +
                                 "[SGJP_USUPAINTBALL], " +
                                 "[SGJP_USUFONE], "      +
                                 "[SGJP_USUFONE2], "     +
                                 "[SGJP_CPF], "          +
                                 "[SGJP_RG]) "           +
                                 
                                 " VALUES " +

                                 "(@CodUsu, " +
                                 " @login, " +
                                 " @senha, " +
                                 " @nome, " +
                                 " @email, " +
                                 " 0, " +
                                 " @fone, " +
                                 " @fone2, " +
                                 " @CPF, " +
                                 " @RG) " +
                                 "SET IDENTITY_INSERT SGJP_USUARIO OFF";
                                

             MessageBox.Show(paintball);

            //Passa as informações pelo parametro           
            cmd.Parameters.AddWithValue("@CodUsu", codUsu);
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@email", email);
            //cmd.Parameters.AddWithValue("@paintball", paintball);
            cmd.Parameters.AddWithValue("@fone", fone);
            cmd.Parameters.AddWithValue("@fone2", fone2);
            cmd.Parameters.AddWithValue("@CPF", CPF);
            cmd.Parameters.AddWithValue("@RG", RG);
            

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

        //Cria metodo para alterar o usuario
        public bool AlterarUsuario(String CodUsu, String Nome, String email, String CPF,
                                  String RG, String fone, String fone2, String login, String senha)
        {
            return false;
        }

        //Cria o metodo para excluir o usuario 
        public bool ExcluirUsuario(String CodUsu)
        {
            //Cria comando SQL para deletar o usuario
            cmd.CommandText = "DELETE FROM SGJP_USUARIO " +
                              "WHERE SGJP_USUID = @CodUsu";

            //Passa os parametros
            cmd.Parameters.AddWithValue("@CodUsu", CodUsu);

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
