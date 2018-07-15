using ProjetoPaintball.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPaintball
{
    public partial class CadUsuario : Form
    {
        public string usuario = "";
        public CadUsuario()
        {
            InitializeComponent();
        }

        private void tboxCodUsu_Leave(object sender, EventArgs e)
        {
            //Cria os objetos
            LoginDAOComando loginDAOComando = new LoginDAOComando();
            AddUsuarioDAO addUsuarioDAO = new AddUsuarioDAO();
            
            //Chama a função para procurar o usuario
            usuario =  addUsuarioDAO.ProcuraUsuario(tboxCodUsu.Text,loginDAOComando.varpub_string_CodPaintball.ToString());
            
            //Verifica se não houve retorno
            if(usuario == "")
            {
                tboxNomeUsu.Text   = "";
                tboxEmail.Text     = "";
                maskedCPF.Text     = "";
                maskedRG.Text      = "";
                tboxTelefone.Text  = "";
                tboxTelefone2.Text = "";
                tboxLogin.Text     = "";
                tboxSenha.Text     = "";

                //Libera o botão de adicionar e limpar
                btnCadastrar.Enabled = true;
                btnLimpar.Enabled    = true;

                //Bloqueia o botão alterar e excluir
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;

                //Libera o checkbox de mostrar senha
                ckboxMostraSenha.Enabled = true;
            }
            else
            {
                //Bloqueia o botão cadastrar
                btnCadastrar.Enabled = false;

                //Libera o botão de alterar, excluir e limpar
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;
                btnLimpar.Enabled = true;


                //Libera o checkbox de mostrar senha
                ckboxMostraSenha.Enabled = true;

                // Preenche os campos com as informações retornadas
                //Faz um split
                string[] itemValores = usuario.Split('|');
                tboxNomeUsu.Text   = itemValores[1];
                tboxEmail.Text     = itemValores[2];
                maskedCPF.Text     = itemValores[3];
                maskedRG.Text      = itemValores[4];
                tboxTelefone.Text  = itemValores[5];
                tboxTelefone2.Text = itemValores[6];
                tboxLogin.Text     = itemValores[7];
                tboxSenha.Text     = itemValores[8];
                
            }

        }

        private void tboxCodUsu_TextChanged(object sender, EventArgs e)
        {

        }

        private void CadUsuario_Load(object sender, EventArgs e)
        {

        }

        private void ckboxMostraSenha_CheckedChanged(object sender, EventArgs e)
        {
            //Verifica se o checkbox Mostrar senha está preenchido
            if (ckboxMostraSenha.Checked)
            {
                //Mostra a senha 
                tboxSenha.PasswordChar = '\u0000';
            }
            else
            {
                //Mostra a senha criptografada
                tboxSenha.PasswordChar = '*';
            }             
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //Desativa os botões
            btnCadastrar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = false;

            //Limpa os texts box
            tboxCodUsu.Text    = "";
            tboxNomeUsu.Text   = "";
            tboxEmail.Text     = "";
            maskedCPF.Text     = "";
            maskedRG.Text      = "";
            tboxTelefone.Text  = "";
            tboxTelefone2.Text = "";
            tboxLogin.Text     = "";
            tboxSenha.Text     = "";

            //Dá o foco
            tboxCodUsu.Focus();
        }
    }
}
