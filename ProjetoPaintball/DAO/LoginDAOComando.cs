using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPaintball.DAO
{
    class LoginDAOComando
    {
        //Variavel global para receber o codigo do usuario
        public string varpub_string_CodUsuario = "";

        //Variavel global para receber o codigo do paintball
        public  string varpub_string_CodPaintball = "";
        

        //Cria variavel para receber o status do login
        public bool varpub_bool_loginStatus;

        //Cria uma varaivel para receber mensagem de erro no login, já inicializa ela vazia
        public String varpub_string_mensagemErro = "";

        //Cria a classe sqlcommand para poder fazer comandos sql.
        SqlCommand cmd = new SqlCommand();

        //Cria o objeto para conexao
        Conexao con = new Conexao();
        
        //Cria o objeto para receber o dataReader
        SqlDataReader dr;

        //Cria o metedo para verificar se ocorreu o Login
        public bool verificarLogin(String login, string senha)
        {
            //Monta a query para verificar se existe o usuario
            cmd.CommandText = "SELECT * " +
                               " FROM SGJP_USUARIO " +
                               " WHERE SGJP_USULOGIN = @login AND" +
                                     " SGJP_USUSENHA = @senha";
 

            //Passa as informações pelo parametro
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);
            
            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();

                //Verifica se retornou alguma linha
                if(dr.HasRows)
                {
                    //A variavel adquire o status de verdadeira
                    varpub_bool_loginStatus = true;

                    //Faz um while para gravar o codigo do usuario e o codigo do estabelecimento 
                    while (dr.Read())
                    {
                        //Grava nas  variaveis os valores
                        varpub_string_CodUsuario = dr["SGJP_USUID"].ToString();
                        varpub_string_CodPaintball = dr["SGJP_USUPAINTBALL"].ToString();
                    }
                }
            }catch(SqlException)
            {
                this.varpub_string_mensagemErro = "Erro de login. Verificar se as informações estão corretas";
                //throw;
            }
            return varpub_bool_loginStatus;
        }
    }
}
