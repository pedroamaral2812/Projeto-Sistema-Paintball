using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPaintball.DAO
{
    public class Conexao
    {
        //Utiliza a classe SQLConnection para criar uma conexao com o banco
        SqlConnection con = new SqlConnection();

        //Criando o metodo construtor
        public Conexao()
        {
            con.ConnectionString = @"Data Source=USUARIO-PC\SQLEXPRESS;Initial Catalog=SGJP;Integrated Security=True";
        }

        //Função para conectar ao banco
        public SqlConnection conectar()
        {
            //Verifica se já não há uma conexao
            if(con.State == System.Data.ConnectionState.Closed)
            {
                //Abre a conexao
                con.Open();
            }
            return con;
        }

        //Função para desconectar do banco
        public void desconectar()
        {
            //Verifica se há alguma conexao aberta
            if (con.State == System.Data.ConnectionState.Open)
            {
                //Fecha a conexao
                con.Close();
            }
        }
    }
}
