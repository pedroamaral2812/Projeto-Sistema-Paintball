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
    public partial class CadTipoArma : Form
    {
        public CadTipoArma()
        {
            InitializeComponent();
        }

        private void CadTipoArma_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sGJPDataSet1.SGJP_TPARMA'. Você pode movê-la ou removê-la conforme necessário.
            this.sGJP_TPARMATableAdapter.Fill(this.sGJPDataSet1.SGJP_TPARMA);

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //Fecha o form
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //Limpa os campos
            tboxCodTPArmas.Text  = "";
            tboxNomeTPArmas.Text = "";
            tboxDescTPArmas.Text = "";

            //Bloqueia os botões
            btnCadastrar.Enabled = false;
            btnAlterar.Enabled   = false;
            btnExcluir.Enabled   = false;
            btnLimpar.Enabled    = false;

            //Poem o focu no codigo
            tboxCodTPArmas.Focus();
        }

        private void tboxCodTPArmas_Leave(object sender, EventArgs e)
        {
            //Cria a classe sqlcommand para poder fazer comandos sql.
            SqlCommand cmd = new SqlCommand();

            //Cria o objeto para conexao
            Conexao con = new Conexao();

            //Cria o objeto para receber o dataReader
            SqlDataReader dr;

            //Monta a query para verificar se existe o usuario
            cmd.CommandText = " SELECT * " +
                              " FROM SGJP_TPARMA " +
                              " WHERE SGJP_TPARMACOD = @CodTPArma";
            //" AND SGJP_CARGOFUNCPAINTBALL = @paintball";


            //Passa as informações pelo parametro
            cmd.Parameters.AddWithValue("@CodTPArma", tboxCodTPArmas.Text);
            //cmd.Parameters.AddWithValue("@paintball", variavel_global_paintball);

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
                        DialogResult confirmaMensagem = MessageBox.Show("Atenção Tipo de arma já existente!! Deseja alterar ou excluir o cargo/função?", "Tipo de arma já existente",
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
                            tboxNomeTPArmas.Text = dr["SGJP_TPARMANOME"].ToString();
                            tboxDescTPArmas.Text = dr["SGJP_TPARMADESC"].ToString();

                            //Libera os botões
                            btnAlterar.Enabled = true;
                            btnExcluir.Enabled = true;
                            btnLimpar.Enabled = true;

                            //Desativao botão de incluir
                            btnCadastrar.Enabled = false;

                            //Mudar a cor do text box
                            tboxCodTPArmas.BackColor = Color.White;
                        }

                    }
                }
                else
                {
                    //Verifica se está preenchido o codigo
                    if (tboxCodTPArmas.Text != "")
                    {

                        //Limpa os texts box
                        tboxNomeTPArmas.Text = "";
                        tboxDescTPArmas.Text = "";

                        //Libera os botões
                        btnCadastrar.Enabled = true;
                        btnLimpar.Enabled = true;

                        //Desativa os botões
                        btnAlterar.Enabled = false;
                        btnExcluir.Enabled = false;

                        //Mudar a cor do text box
                        tboxCodTPArmas.BackColor = Color.White;

                    }
                    //Se não tiver preenchido o codigo do usuario
                    else
                    {
                        //Limpa os texts box
                        tboxNomeTPArmas.Text = "";
                        tboxDescTPArmas.Text = "";

                        //Desativa os botões
                        btnCadastrar.Enabled = false;
                        btnLimpar.Enabled = false;
                        btnAlterar.Enabled = false;
                        btnExcluir.Enabled = false;

                        //Mudar a cor do text box
                        tboxCodTPArmas.BackColor = Color.White;
                    }

                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Erro!!!", "Erro na procura do Tipo de arma ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadTPArmaModel cadTPArmaModel = new CadTPArmaModel();

            //Verifica se preencheu os campos obrigatorios
            if((tboxCodTPArmas.TextLength < 1)|| (tboxNomeTPArmas.TextLength < 1) || (tboxDescTPArmas.TextLength < 1))
            {
                MessageBox.Show("Atenção preencha os campos obrigátorios!!", "Campos obrigatorios não preenchidos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            //Se preencheu todos os campos obrigatórios
            else
            {
                //Verifica se adicionou com sucesso o funcionario
                if(cadTPArmaModel.InserirTPArma(tboxCodTPArmas.Text, tboxNomeTPArmas.Text, tboxDescTPArmas.Text))
                {
                    //Mostra a mensagem avisando que a inclusão foi um sucesso
                    MessageBox.Show("Tipo de arma adicionado com sucesso!!", "Exito ao adicionar o Tipo de arma", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Chama o função de clicar no botão limpar
                    btnLimpar_Click(sender, e);

                    //Atualiza o grid
                    this.sGJP_TPARMATableAdapter.Fill(this.sGJPDataSet1.SGJP_TPARMA);
                }
                //Se não adicionou corretamente o tipo de funcionario
                else
                {
                    MessageBox.Show("Problemas ao adicionar o Tipo de arma, favor verificar!!", "Problemas ao adicionar o Tipo de arma", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            CadTPArmaModel cadTPArmaModel = new CadTPArmaModel();

            //Verifica se preencheu os campos obrigatorios
            if ((tboxCodTPArmas.TextLength < 1) || (tboxNomeTPArmas.TextLength < 1) || (tboxDescTPArmas.TextLength < 1))
            {
                MessageBox.Show("Atenção preencha os campos obrigátorios!!", "Campos obrigatorios não preenchidos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            //Se preencheu todos os campos obrigatórios
            else
            {
                //Verifica se adicionou com sucesso o funcionario
                if (cadTPArmaModel.AlterarTPArma(tboxCodTPArmas.Text, tboxNomeTPArmas.Text, tboxDescTPArmas.Text))
                {
                    //Mostra a mensagem avisando que a alteração foi um sucesso
                    MessageBox.Show("Tipo de arma alterado com sucesso!!", "Exito ao alterar o Tipo de arma", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Chama o função de clicar no botão limpar
                    btnLimpar_Click(sender, e);

                    //Atualiza o grid
                    this.sGJP_TPARMATableAdapter.Fill(this.sGJPDataSet1.SGJP_TPARMA);
                }
                //Se não adicionou corretamente o tipo de funcionario
                else
                {
                    MessageBox.Show("Problemas ao adicionar o Tipo de arma, favor verificar!!", "Problemas ao adicionar o Tipo de arma", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            CadTPArmaModel cadTPArmaModel = new CadTPArmaModel();

            if(cadTPArmaModel.ExcluirTPArma(tboxCodTPArmas.Text))
            {
                //Mostra a mensagem avisando que a alteração foi um sucesso
                MessageBox.Show("Tipo de arma excluida com sucesso!!", "Exito ao excluir o Tipo de arma", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Chama o função de clicar no botão limpar
                btnLimpar_Click(sender, e);

                //Atualiza o grid
                this.sGJP_TPARMATableAdapter.Fill(this.sGJPDataSet1.SGJP_TPARMA);
            }
            //Se não adicionou corretamente o tipo de funcionario
            else
            {
                MessageBox.Show("Problemas ao excluir o Tipo de arma, favor verificar!!", "Problemas ao excluir o Tipo de arma", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
