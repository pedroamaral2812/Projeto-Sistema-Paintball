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
            tboxRGFunc.Text = "";
            tboxCNHFunc.Text = "";
            mkdDtCad.Text = "";
            mkdDtDesl.Text = "";
            tboxEnderecoFunc.Text = "";

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
                      " FROM SGJP_FUNCIONARIO" +  //JOIN SGJP_CARGOFUNC ON SGJP_USUPAINTBALL = SGJP_FUNCPAINTBALL " +
                      " WHERE SGJP_FUNCCOD  = @ID";
                            //" AND SGJP_USUPAINTBALL = @paintball ";

            //Passa as informações pelo parametro
            cmd.Parameters.AddWithValue("@ID", tboxCodFunc.Text);
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
                            tboxNomeFunc.Text     = dr["SGJP_FUNCNOME"].ToString();
                            tboxTelFunc.Text      = dr["SGJP_FUNCFONE"].ToString();
                            tboxTel2Func.Text     = dr["SGJP_FUNCFONE2"].ToString();
                            tboxCPFFunc.Text      = dr["SGJP_FUNCCPF"].ToString();
                            tboxRGFunc.Text       = dr["SGJP_FUNCRG"].ToString();
                            tboxCNHFunc.Text      = dr["SGJP_FUNCCNH"].ToString();
                            mkdDtCad.Text         = dr["SGJP_FUNCDTCAD"].ToString();
                            mkdDtDesl.Text        = dr["SGJP_FUNCDTDESL"].ToString();
                            tboxEnderecoFunc.Text = dr["SGJP_FUNCENDERECO"].ToString();


                            //Libera os botões
                            btnAlterar.Enabled = true;
                            btnExcluir.Enabled = true;
                            btnLimpar.Enabled = true;

                            //Desativao botão de incluir
                            btnCadastrar.Enabled = false;

                            //Mudar a cor do text box
                            tboxCodFunc.BackColor = Color.White;

                            //Preenche o codigo do cargo e faz o leave do codigo de função
                            tboxCodCargos.Text = dr["SGJP_FUNCCARGOCOD"].ToString();
                            tboxCodCargos_Leave(sender,e);
                        }

                    }
                }
                else
                {
                    //Verifica se está preenchido o codigo
                    if (tboxCodFunc.Text != "")
                    {
                        //Limpa os texts box
                        tboxNomeFunc.Text     = "";
                        tboxCodCargos.Text    = "";
                        tboxNomeCargos.Text   = "";
                        tboxTelFunc.Text      = "";
                        tboxTel2Func.Text     = "";
                        tboxCPFFunc.Text      = "";
                        tboxRGFunc.Text       = "";
                        tboxCNHFunc.Text      = "";
                        mkdDtCad.Text         = "";
                        mkdDtDesl.Text        = "";
                        tboxEnderecoFunc.Text = "";

                        //Libera os botões
                        btnCadastrar.Enabled = true;
                        btnLimpar.Enabled    = true;

                        //Desativa os botões
                        btnAlterar.Enabled = false;
                        btnExcluir.Enabled = false;

                        //Mudar a cor do text box
                        tboxCodFunc.BackColor = Color.White;
                    }
                    //Se não tiver preenchido o codigo do usuario
                    else
                    {
                        //Limpa os texts box
                        tboxNomeFunc.Text     = "";
                        tboxCodCargos.Text    = "";
                        tboxNomeCargos.Text   = "";
                        tboxTelFunc.Text      = "";
                        tboxTel2Func.Text     = "";
                        tboxCPFFunc.Text      = "";
                        tboxRGFunc.Text       = "";
                        tboxCNHFunc.Text      = "";
                        mkdDtCad.Text         = "";
                        mkdDtDesl.Text        = "";
                        tboxEnderecoFunc.Text = "";

                        //Desativa os botões
                        btnCadastrar.Enabled = false;
                        btnLimpar.Enabled    = false;
                        btnAlterar.Enabled   = false;
                        btnExcluir.Enabled   = false;

                        //Mudar a cor do text box
                        tboxCodFunc.BackColor = Color.White;
                    }
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Erro!!!", "Erro na procura do funcionario ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void tboxCodFunc_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Impede de teclar letras e espaços
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }

        private void tboxCodCargos_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Impede de teclar letras e espaços
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }

        private void tboxTelFunc_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Impede de teclar letras e espaços
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }

        private void tboxTel2Func_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Impede de teclar letras e espaços
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }

        private void tboxCPFFunc_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Impede de teclar letras e espaços
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }

        private void tboxRGFunc_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Impede de teclar letras e espaços
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }

        private void mkdDtCad_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Impede de teclar letras e espaços
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }

        private void mkdDtDesl_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Impede de teclar letras e espaços
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }

        private void tboxCodCargos_Leave(object sender, EventArgs e)
        {
            //Cria a classe sqlcommand para poder fazer comandos sql.
            SqlCommand cmd = new SqlCommand();

            //Cria o objeto para conexao
            Conexao con = new Conexao();

            //Cria o objeto para receber o dataReader
            SqlDataReader dr;

            //Monta a query para verificar se existe o usuario
            cmd.CommandText = " SELECT * " +
                              " FROM SGJP_CARGOFUNC " +
                              " WHERE SGJP_CARGOFUNCCOD = @CodCargo";
            //" AND SGJP_CARGOFUNCPAINTBALL = @paintball";


            //Passa as informações pelo parametro
            cmd.Parameters.AddWithValue("@CodCargo", tboxCodCargos.Text);
            //cmd.Parameters.AddWithValue("@paintball", variavel_global_paintball);

            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    //Faz um while para gravar as informações em uma variavel 
                    while (dr.Read())
                    {
                        // Insere as informações no text box
                        tboxNomeCargos.Text = dr["SGJP_CARGOFUNCNOME"].ToString();

                        //Mudar a cor do text box
                        tboxCodCargos.BackColor = Color.White;

                    }
                }
                else
                {
                    MessageBox.Show("Função/Cargo não existente, por favor digite um código válido","Função/Cargo não existente", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    tboxCodCargos.Focus();
                   
                   
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Erro!!!", "Erro na procura do cargo/função ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadFuncionarioModel cadFuncionarioModel = new CadFuncionarioModel();

            //Verifica se preencheu os campos obrigatorios
            if ((tboxNomeFunc.TextLength < 1) || (tboxCodCargos.TextLength< 1) ||
                (tboxTelFunc.TextLength < 1)  || (tboxCPFFunc.TextLength < 1)  ||
                (mkdDtCad.TextLength < 1 )    || (tboxEnderecoFunc.TextLength<1)) 
            {
                MessageBox.Show("Atenção preencha os campos obrigátorios!!", "Campos obrigatorios não preenchidos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            //Se preencheu todos os campos obrigatórios
            else
            {
                //Verifica se adicionou com sucesso o funcionario
                if(cadFuncionarioModel.InserirFuncionario(tboxCodFunc.Text, tboxNomeFunc.Text, tboxCodCargos.Text,
                                                          tboxCPFFunc.Text, tboxRGFunc.Text, tboxCNHFunc.Text, tboxTelFunc.Text, tboxTel2Func.Text,
                                                          tboxEnderecoFunc.Text, mkdDtCad.Text, mkdDtDesl.Text))
                {
                    MessageBox.Show("Funcionario adicionado com sucesso!!", "Exito ao adicionar o Funcionario", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Chama o função de clicar no botão limpar
                    btnLimpar_Click(sender, e);
                }
                //Se não adicionou corretamente o Funcionario
                else
                {
                    MessageBox.Show("Problemas ao adicionar o Funcionario, favor verificar!!", "Problemas ao adicionar o Funcionario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            CadFuncionarioModel cadFuncionarioModel = new CadFuncionarioModel();

            //Verifica se preencheu os campos obrigatorios
            if ((tboxNomeFunc.TextLength < 1) || (tboxCodCargos.TextLength < 1) ||
                (tboxTelFunc.TextLength < 1) || (tboxCPFFunc.TextLength < 1) ||
                (mkdDtCad.TextLength < 1) || (tboxEnderecoFunc.TextLength < 1))
            {
                MessageBox.Show("Atenção preencha os campos obrigátorios!!", "Campos obrigatorios não preenchidos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            //Se preencheu todos os campos obrigatórios
            else
            {
                //Verifica se alterou com sucesso o funcionario
                if (cadFuncionarioModel.AlterarFuncionario(tboxCodFunc.Text, tboxNomeFunc.Text, tboxCodCargos.Text,
                                                          tboxCPFFunc.Text, tboxRGFunc.Text, tboxCNHFunc.Text, tboxTelFunc.Text, tboxTel2Func.Text,
                                                          tboxEnderecoFunc.Text, mkdDtCad.Text, mkdDtDesl.Text))
                {
                    MessageBox.Show("Funcionario alterado com sucesso!!", "Exito ao alterar o Funcionario", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Chama o função de clicar no botão limpar
                    btnLimpar_Click(sender, e);
                }
                //Se não alterou corretamente o Funcionario
                else
                {
                    MessageBox.Show("Problemas ao alterar o Funcionario, favor verificar!!", "Problemas ao alterar o Funcionario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            CadFuncionarioModel cadFuncionarioModel = new CadFuncionarioModel();

            //Verifica se preencheu os campos obrigatorios
            if (tboxCodFunc.TextLength < 1)
            {
                MessageBox.Show("Atenção preencha os campos obrigátorios!!", "Campos obrigatorios não preenchidos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            //Se preencheu todos os campos obrigatórios
            else
            {
                //Verifica se excluiu com sucesso o funcionario
                if (cadFuncionarioModel.ExcluirFuncionario(tboxCodFunc.Text))
                {
                    MessageBox.Show("Funcionario excluido com sucesso!!", "Exito ao excluir o Funcionario", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Chama o função de clicar no botão limpar
                    btnLimpar_Click(sender, e);
                }
                //Se não excluiu corretamente o Funcionario
                else
                {
                    MessageBox.Show("Problemas ao excluir o Funcionario, favor verificar!!", "Problemas ao excluir o Funcionario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}

