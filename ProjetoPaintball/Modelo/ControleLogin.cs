using ProjetoPaintball.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPaintball.Modelo
{
    public class ControleLogin
    {
        //Cria uma variavel para verificar se o login funcionou corretamente
        public bool varpub_bool_LoginCorreto;

        //Cria uma varaivel para receber mensagem de erro no login, já inicializa ela vazia
        public String varpub_string_mensagemErro = "";

        //Função para fazer o login
        public bool fazerLogin (String login, String senha)
        {
            //Cria o objeto do loginDAO 
            LoginDAOComando loginDao = new LoginDAOComando();

            //Chama a função para verificar o login e grava seu retorno na variavel
            varpub_bool_LoginCorreto = loginDao.verificarLogin(login, senha);

            //Caso a mensagem de erro não esteja vazia.Ou seja, há erro
            if(!loginDao.varpub_string_mensagemErro.Equals(""))
            {
                //A mensagem de erro desta classe recebe o resultado da mensagem de erro da outra classe
                this.varpub_string_mensagemErro = loginDao.varpub_string_mensagemErro;
            }

            //O retorno da função
            return varpub_bool_LoginCorreto;
        }
    }
}
