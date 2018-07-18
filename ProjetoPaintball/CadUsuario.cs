using ProjetoPaintball.DAO;
using ProjetoPaintball.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        //Ao sair do Codigo do usuario
        private void tboxCodUsu_Leave(object sender, EventArgs e)
        {
            //Cria a classe sqlcommand para poder fazer comandos sql.
            SqlCommand cmd = new SqlCommand();

            //Cria o objeto para conexao
            Conexao con = new Conexao();

            //Cria o objeto para receber o dataReader
            SqlDataReader dr;

            //Cria os objetos
            LoginDAOComando loginDAOComando = new LoginDAOComando();

            //Monta a query para verificar se existe o usuario
            cmd.CommandText = " SELECT * " +
                      " FROM SGJP_USUARIO JOIN PAINTBALL ON SGJP_USUPAINTBALL = PAINTBALL_CODIGO " +
                      " WHERE SGJP_USUID  = @ID AND " +
                            " SGJP_USUPAINTBALL = @paintball ";
                      

            //Passa as informações pelo parametro
            cmd.Parameters.AddWithValue("@ID", tboxCodUsu.Text);
            cmd.Parameters.AddWithValue("@paintball", loginDAOComando.varpub_string_CodPaintball);

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
                        //Pergunta ao usuario se deseja alterar o u excluir um usuario
                        DialogResult confirmaMensagem = MessageBox.Show("Atenção usuário já existente!! Deseja alterar ou excluir o usuário?", "Usuário já existente",
                                                        MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation,
                                                        MessageBoxDefaultButton.Button2);
                        //Se não confirmar a mensagem.
                        if (confirmaMensagem.ToString().ToUpper() != "YES")
                        {
                            //Chama o função de clicar no botão limpar
                            btnLimpar_Click(sender, e);
                        }
                        //Se apertou yes
                        else
                        {
                            // Insere as informações no text box
                            tboxNomeUsu.Text = dr["SGJP_USUNOME"].ToString();
                            tboxEmail.Text = dr["SGJP_USUEMAIL"].ToString();
                            maskedCPF.Text = dr["SGJP_CPF"].ToString();
                            maskedRG.Text = dr["SGJP_RG"].ToString();
                            tboxTelefone.Text = dr["SGJP_USUFONE"].ToString();
                            tboxTelefone2.Text = dr["SGJP_USUFONE2"].ToString();
                            tboxLogin.Text = dr["SGJP_USULOGIN"].ToString();
                            tboxSenha.Text = dr["SGJP_USUSENHA"].ToString();

                            //Libera os botões
                            btnAlterar.Enabled = true;
                            btnExcluir.Enabled = true;
                            btnLimpar.Enabled = true;

                            //Desativao botão de incluir
                            btnCadastrar.Enabled = false;

                            //Libera o check box
                            ckboxMostraSenha.Enabled = true;

                            //Mudar a cor do text box
                            tboxCodUsu.BackColor = Color.White;
                        }

                    }
                } else
                {
                    //Verifica se está preenchido o codigo
                    if (tboxCodUsu.Text != "")
                    {
                                     
                        //Limpa os texts box
                        tboxNomeUsu.Text = "";
                        tboxEmail.Text = "";
                        maskedCPF.Text = "";
                        maskedRG.Text = "";
                        tboxTelefone.Text = "";
                        tboxTelefone2.Text = "";
                        tboxLogin.Text = "";
                        tboxSenha.Text = "";

                        //Libera os botões
                        btnCadastrar.Enabled = true;
                        btnLimpar.Enabled = true;

                        //Desativa os botões
                        btnAlterar.Enabled = false;
                        btnExcluir.Enabled = false;

                        //Libera o check box
                        ckboxMostraSenha.Enabled = true;

                        //Mudar a cor do text box
                        tboxCodUsu.BackColor = Color.White;

                    }
                    //Se não tiver preenchido o codigo do usuario
                    else
                    {
                        //Limpa os texts box
                        tboxNomeUsu.Text = "";
                        tboxEmail.Text = "";
                        maskedCPF.Text = "";
                        maskedRG.Text = "";
                        tboxTelefone.Text = "";
                        tboxTelefone2.Text = "";
                        tboxLogin.Text = "";
                        tboxSenha.Text = "";

                        //Desativa os botões
                        btnCadastrar.Enabled = false;
                        btnLimpar.Enabled = false;
                        btnAlterar.Enabled = false;
                        btnExcluir.Enabled = false;

                        //Deslibera o check box
                        ckboxMostraSenha.Enabled = false;

                        //Mudar a cor do text box
                        tboxCodUsu.BackColor = Color.White;
                    }

                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Erro!!!", "Erro na procura do usuario ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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

            //Deslibera o check box
            ckboxMostraSenha.Enabled = false;

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

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //Cria os objetos necessários
            CadUsuModel cadUsuModel = new CadUsuModel();
            LoginDAOComando loginDAOComando = new LoginDAOComando();

            //Verifica se preencheu os campos obrigátorios
            if ((tboxNomeUsu.TextLength < 1) || (tboxLogin.TextLength < 1) || (tboxSenha.TextLength < 1))

            {
                MessageBox.Show("Atenção preencha os campos obrigátorios!!", "Campos obrigatorios não preenchidos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            //Se preencheu todos os campos obrigatórios
            else
            {
                //Verifica se adicionou com sucesso o usuario
                if (cadUsuModel.IncluirUsuario(tboxCodUsu.Text, tboxLogin.Text, tboxSenha.Text,
                                               tboxNomeUsu.Text, tboxEmail.Text,
                                               loginDAOComando.varpub_string_CodPaintball,
                                               tboxTelefone.Text, tboxTelefone2.Text,
                                               maskedCPF.Text, maskedRG.Text))
                {
                    MessageBox.Show("Usuario adicionado com sucesso!!", "Exito ao adicionar o usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                    //Chama o função de clicar no botão limpar
                    btnLimpar_Click(sender, e);
                }
                //Se não adicionou corretamente o usuario
                else
                {
                    MessageBox.Show("Problemas ao adicionar o usuario, favor verificar!!", "Problemas ao adicionar o usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }         
        }

        private void tboxCodUsu_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Impede de teclar letras e espaços
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }

        private void tboxEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Impede de colocar espaços ao digitar o email
            if  (Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
                
        }

        private void maskedCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Impede de teclar letras e espaços
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }

        private void maskedRG_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Impede de teclar letras e espaços
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }

        private void tboxTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Impede de teclar letras e espaços
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }

        private void tboxTelefone2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Impede de teclar letras e espaços
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }

        private void tboxLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Impede de teclar espaços
            if  (Char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void tboxSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Impede de teclar espaços
            if (Char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //Cria os objetos necessários
            CadUsuModel cadUsuModel = new CadUsuModel();

            //Verifica se o codigo do usuario está preenchido
            if (tboxCodUsu.TextLength < 1 )
            {
                MessageBox.Show("Codigo do usuario não preenchido!!", "Codigo não preenchido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //Verifica se a função retornou verdadeiro
                if (cadUsuModel.ExcluirUsuario(tboxCodUsu.Text))
                {
                    MessageBox.Show("Usuario excluido com sucesso!!", "Exito ao excluir um usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Chama o função de clicar no botão limpar
                    btnLimpar_Click(sender, e);

                }
                //Se não excluiu corretamente o usuario
                else
                {
                    MessageBox.Show("Problemas ao excluir o usuario, favor verificar!!", "Problemas ao excluir o usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            //Cria os objetos necessários
            CadUsuModel cadUsuModel = new CadUsuModel();
            LoginDAOComando loginDAOComando = new LoginDAOComando();

            //Verifica se preencheu os campos obrigátorios
            if ((tboxNomeUsu.TextLength < 1) || (tboxLogin.TextLength < 1) || (tboxSenha.TextLength < 1))

            {
                MessageBox.Show("Atenção preencha os campos obrigátorios!!", "Campos obrigatorios não preenchidos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                //Verifica se alterou com sucesso o usuario
                if (cadUsuModel.AlterarUsuario(tboxCodUsu.Text, tboxLogin.Text, tboxSenha.Text,
                                               tboxNomeUsu.Text, tboxEmail.Text,
                                               tboxTelefone.Text, tboxTelefone2.Text,
                                               maskedCPF.Text, maskedRG.Text))
                {
                    //Avisa ao usuario que deu certo a alteração
                    MessageBox.Show("Usuario alterado com sucesso!!", "Exito ao alterar o usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Chama o função de clicar no botão limpar
                    btnLimpar_Click(sender, e);
                }
                //Se não alterou corretamente o usuario
                else
                {
                    //Avisa ao usuario que não deu certo a alteração
                    MessageBox.Show("Problemas ao alterar o usuario, favor verificar!!", "Problemas ao alterar o usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tboxCodUsu_Enter(object sender, EventArgs e)
        {
            //Muda para a cor de foco
            tboxCodUsu.BackColor = Color.Aqua;
        }

        private void tboxNomeUsu_Enter(object sender, EventArgs e)
        {
            //Muda para a cor de foco
            tboxNomeUsu.BackColor = Color.Aqua;
        }

        private void tboxEmail_Enter(object sender, EventArgs e)
        {
            //Muda para a cor de foco
            tboxEmail.BackColor = Color.Aqua;
        }

        private void maskedCPF_Enter(object sender, EventArgs e)
        {
            //Muda para a cor de foco
            maskedCPF.BackColor = Color.Aqua;
        }

        private void maskedRG_Enter(object sender, EventArgs e)
        {
            //Muda para a cor de foco
            maskedRG.BackColor = Color.Aqua;
        }

        private void tboxTelefone_Enter(object sender, EventArgs e)
        {
            //Muda para a cor de foco
            tboxTelefone.BackColor = Color.Aqua;
        }

        private void tboxTelefone2_Enter(object sender, EventArgs e)
        {
            //Muda para a cor de foco
            tboxTelefone2.BackColor = Color.Aqua;
        }

        private void tboxLogin_Enter(object sender, EventArgs e)
        {
            //Muda para a cor de foco
            tboxLogin.BackColor = Color.Aqua;
        }

        private void tboxSenha_Enter(object sender, EventArgs e)
        {
            //Muda para a cor de foco
            tboxSenha.BackColor = Color.Aqua;
        }

        private void tboxNomeUsu_Leave(object sender, EventArgs e)
        {
            //Mudar a cor do text box
            tboxNomeUsu.BackColor = Color.White;
        }

        private void tboxEmail_Leave(object sender, EventArgs e)
        {
            //Mudar a cor do text box
            tboxEmail.BackColor = Color.White;
        }

        private void maskedCPF_Leave(object sender, EventArgs e)
        {
            //Mudar a cor do text box
            maskedCPF.BackColor = Color.White;
        }

        private void maskedRG_Leave(object sender, EventArgs e)
        {
            //Mudar a cor do text box
            maskedRG.BackColor = Color.White;
        }

        private void tboxTelefone_Leave(object sender, EventArgs e)
        {
            //Mudar a cor do text box
            tboxTelefone.BackColor = Color.White;
        }

        private void tboxTelefone2_Leave(object sender, EventArgs e)
        {
            //Mudar a cor do text box
            tboxTelefone2.BackColor = Color.White;
        }

        private void tboxLogin_Leave(object sender, EventArgs e)
        {
            //Mudar a cor do text box
            tboxLogin.BackColor = Color.White;
        }

        private void tboxSenha_Leave(object sender, EventArgs e)
        {
            //Mudar a cor do text box
            tboxSenha.BackColor = Color.White;
        }
    }
}
