using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPaintball.DAO
{
    class AddUsuarioDAO
    {
        //String que retornará os valores encontrados
        public string varpub_string_retornoUsu = "";
        
        //Cria a classe sqlcommand para poder fazer comandos sql.
        SqlCommand cmd = new SqlCommand();

        //Cria o objeto para conexao
        Conexao con = new Conexao();

        //Cria o objeto para receber o dataReader
        SqlDataReader dr;

        public String ProcuraUsuario(String ID_Usuario, String Cod_Paintball)
        {

            //Monta a query para verificar se existe o usuario
            cmd.CommandText = " SELECT * " +
                              " FROM SGJP_USUARIO JOIN PAINTBALL ON SGJP_USUPAINTBALL = PAINTBALL_CODIGO " +
                              " WHERE SGJP_USUID  = @ID AND " +
                              " SGJP_USUPAINTBALL = @paintball ";



            //Passa as informações pelo parametro
            cmd.Parameters.AddWithValue("@ID", ID_Usuario);
            cmd.Parameters.AddWithValue("@paintball", Cod_Paintball);
                     
            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();

                //Verifica se retornou alguma linha
                if (dr.HasRows)
                {
                    //Faz um while para gravar as informações em uma variavel 
                    while (dr.Read())
                    {
                        varpub_string_retornoUsu  = dr["SGJP_USUID"].ToString() + "|";                        
                        varpub_string_retornoUsu += dr["SGJP_USUNOME"].ToString() + "|";
                        varpub_string_retornoUsu += dr["SGJP_USUEMAIL"].ToString() + "|";
                        varpub_string_retornoUsu += dr["SGJP_CPF"].ToString() + "|";
                        varpub_string_retornoUsu += dr["SGJP_RG"].ToString() + "|";
                        varpub_string_retornoUsu += dr["SGJP_USUFONE"].ToString() + "|";
                        varpub_string_retornoUsu += dr["SGJP_USUFONE2"].ToString() + "|";
                        varpub_string_retornoUsu += dr["SGJP_USULOGIN"].ToString() + "|";
                        varpub_string_retornoUsu += dr["SGJP_USUSENHA"].ToString() + "|";
                    }
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Erro!!!", "Erro na procura do usuario ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            return varpub_string_retornoUsu;
        }
    }

    public class Aluno
    {
        public String UsuId { get; set; }
        public String UsuLogin { get; set; }
        public String UsuSenha { get; set; }
        public String UsuNome { get; set; }
        public String UsuEmail { get; set; }
        public String UsuPaintball { get; set; }
        public String UsuFone { get; set; }
        public String UsuFone2 { get; set; }
    }
}
