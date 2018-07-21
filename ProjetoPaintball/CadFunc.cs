using ProjetoPaintball.DAO;
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
    public partial class CadFunc : Form
    {
        public CadFunc()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //Fecha a aplicação
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //Limpa os campos
            tboxCodFunc.Text = "";
            tboxNomeFunc.Text = "";
            tboxCodCargos.Text = "";
            tboxNomeCargos.Text = "";
            tboxTelFunc.Text = "";
            tboxTel2Func.Text = "";
            tboxCPFFunc.Text = "";
            cklistBoxSexo.Text = "";
            mkdDtCad.Text = "";
            mkdDtDesl.Text = "";

            //Desativa os botões
            btnCadastrar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = false;

            //Poem  o focu no codigo do funcionario
            tboxCodFunc.Focus();
        }

        private void tboxCodFunc_Leave(object sender, EventArgs e)
        {
            //Cria a classe sqlcommand para poder fazer comandos sql.
            SqlCommand cmd = new SqlCommand();

            //Cria o objeto para conexao
            Conexao con = new Conexao();

            //Cria o objeto para receber o dataReader
            SqlDataReader dr;

            //Monta a query para verificar se existe o funcionario
            cmd.CommandText = " SELECT * " +
                      " FROM SGJP_FUNCIONARIO JOIN SGJP_CARGOFUNC ON SGJP_USUPAINTBALL = PAINTBALL_CODIGO " +
                      " WHERE SGJP_USUID  = @ID AND " +
                            " SGJP_USUPAINTBALL = @paintball ";


            //Passa as informações pelo parametro
            //cmd.Parameters.AddWithValue("@ID", tboxCodUsu.Text);
            //cmd.Parameters.AddWithValue("@paintball", loginDAOComando.varpub_string_CodPaintball);

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
                        DialogResult confirmaMensagem = MessageBox.Show("Atenção funcionario já existente!! Deseja alterar ou excluir o usuário?", "Usuário já existente",
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
                }
                else
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
    }
}

