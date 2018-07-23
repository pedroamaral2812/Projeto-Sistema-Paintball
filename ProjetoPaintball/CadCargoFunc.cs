using ProjetoPaintball.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using ProjetoPaintball.Modelo;

namespace ProjetoPaintball
{
    public partial class CadCargoFunc : Form
    {
        public CadCargoFunc()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CadCargoFunc_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sGJPDataSet.SGJP_CARGOFUNC'. Você pode movê-la ou removê-la conforme necessário.
            this.sGJP_CARGOFUNCTableAdapter.Fill(this.sGJPDataSet.SGJP_CARGOFUNC);

            
        }

        private void CadCargoFunc_Enter(object sender, EventArgs e)
        {

            
        }

        private void dtGridCargoFunc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //Ao sair do text box do codigo do cargo
        private void tboxCodCargo_Leave(object sender, EventArgs e)
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
            cmd.Parameters.AddWithValue("@CodCargo", tboxCodCargo.Text);
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
                        DialogResult confirmaMensagem = MessageBox.Show("Atenção cargo/função já existente!! Deseja alterar ou excluir o cargo/função?", "Cargo/função já existente",
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
                            tboxNomeCargo.Text = dr["SGJP_CARGOFUNCNOME"].ToString();
                            tboxDescCargo.Text = dr["SGJP_CARGOFUNCDESC"].ToString();
                            
                            //Libera os botões
                            btnAlterar.Enabled = true;
                            btnExcluir.Enabled = true;
                            btnLimpar.Enabled = true;

                            //Desativao botão de incluir
                            btnCadastrar.Enabled = false;

                            //Mudar a cor do text box
                            tboxCodCargo.BackColor = Color.White;
                        }

                    }
                }
                else
                {
                    //Verifica se está preenchido o codigo
                    if (tboxCodCargo.Text != "")
                    {

                        //Limpa os texts box
                        tboxNomeCargo.Text = "";
                        tboxDescCargo.Text = "";
                        
                        //Libera os botões
                        btnCadastrar.Enabled = true;
                        btnLimpar.Enabled = true;

                        //Desativa os botões
                        btnAlterar.Enabled = false;
                        btnExcluir.Enabled = false;

                        //Mudar a cor do text box
                        tboxCodCargo.BackColor = Color.White;

                    }
                    //Se não tiver preenchido o codigo do usuario
                    else
                    {
                        //Limpa os texts box
                        tboxNomeCargo.Text = "";
                        tboxDescCargo.Text = "";
                        
                        //Desativa os botões
                        btnCadastrar.Enabled = false;
                        btnLimpar.Enabled    = false;
                        btnAlterar.Enabled   = false;
                        btnExcluir.Enabled   = false;

                        //Mudar a cor do text box
                        tboxCodCargo.BackColor = Color.White;
                    }

                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Erro!!!", "Erro na procura do cargo/função ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //Limpa os campos
            tboxCodCargo.Text  = "";
            tboxNomeCargo.Text = "";
            tboxDescCargo.Text = "";

            //Desabilita os botões
            btnCadastrar.Enabled = false;
            btnAlterar.Enabled   = false;
            btnExcluir.Enabled   = false;
            btnLimpar.Enabled    = false;

            //Dá o foco
            tboxCodCargo.Focus();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //Cria os objetos necessários
            CadCargoFuncModel cadCargoFuncModel = new CadCargoFuncModel();

            //Verifica se o codigo do usuario está preenchido
            if (tboxCodCargo.TextLength < 1)
            {
                MessageBox.Show("Codigo do cargo/funcionário não preenchido!!", "Codigo não preenchido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //Verifica se a função retornou verdadeiro
                if (cadCargoFuncModel.ExcluirCargoFuncionario(tboxCodCargo.Text))
                {
                    MessageBox.Show("Cargo/Função excluido com sucesso!!", "Exito ao excluir um Cargo/Função", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Chama o função de clicar no botão limpar
                    btnLimpar_Click(sender, e);

                    //Dá um refresh na tabela
                    this.sGJP_CARGOFUNCTableAdapter.Fill(this.sGJPDataSet.SGJP_CARGOFUNC);

                }
                //Se não excluiu corretamente o usuario
                else
                {
                    MessageBox.Show("Problemas ao Cargo/Função o usuario, favor verificar!!", "Problemas ao excluir o usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //Fecha o form
            this.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //Cria os objetos necessários
            CadCargoFuncModel cadCargoFuncModel = new CadCargoFuncModel();

            //Verifica se preencheu os campos obrigátorios
            if ((tboxNomeCargo.TextLength < 1) || (tboxDescCargo.TextLength < 1))

            {
                MessageBox.Show("Atenção preencha os campos obrigátorios!!", "Campos obrigatorios não preenchidos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            //Se preencheu todos os campos obrigatórios
            else
            {
                //Verifica se adicionou com sucesso o usuario
                if (cadCargoFuncModel.IncluirCargoFuncionario(tboxCodCargo.Text, 
                                                              tboxNomeCargo.Text, 
                                                              tboxDescCargo.Text))
                {
                    MessageBox.Show("Cargo/Função adicionado com sucesso!!", "Exito ao adicionar o Cargo/Função", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Chama o função de clicar no botão limpar
                    btnLimpar_Click(sender, e);

                    this.sGJP_CARGOFUNCTableAdapter.Fill(this.sGJPDataSet.SGJP_CARGOFUNC);
                }
                //Se não adicionou corretamente o usuario
                else
                {
                    MessageBox.Show("Problemas ao adicionar o Cargo/Função, favor verificar!!", "Problemas ao adicionar o Cargo/Função", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            //Cria os objetos necessários
            CadCargoFuncModel cadCargoFuncModel = new CadCargoFuncModel();

            //Verifica se preencheu os campos obrigátorios
            if ((tboxNomeCargo.TextLength < 1) || (tboxDescCargo.TextLength < 1))

            {
                MessageBox.Show("Atenção preencha os campos obrigátorios!!", "Campos obrigatorios não preenchidos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                //Verifica se alterou com sucesso o usuario
                if (cadCargoFuncModel.AlterarCargoFuncionario(tboxCodCargo.Text,
                                                              tboxNomeCargo.Text,
                                                              tboxDescCargo.Text))
                {
                    //Avisa ao usuario que deu certo a alteração
                    MessageBox.Show("Cargo/Função alterado com sucesso!!", "Exito ao alterar o Cargo/Função", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Chama o função de clicar no botão limpar
                    btnLimpar_Click(sender, e);

                    //Dá um refresh na tabela
                    this.sGJP_CARGOFUNCTableAdapter.Fill(this.sGJPDataSet.SGJP_CARGOFUNC);
                }
                //Se não alterou corretamente o usuario
                else
                {
                    //Avisa ao usuario que não deu certo a alteração
                    MessageBox.Show("Problemas ao alterar o Cargo/Função, favor verificar!!", "Problemas ao alterar o Cargo/Função", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tboxCodCargo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Impede de teclar letras e espaços
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }

        private void tboxCodCargo_Enter(object sender, EventArgs e)
        {
            //Muda para a cor de foco
            tboxCodCargo.BackColor = Color.Aqua;
        }

        private void tboxNomeCargo_Enter(object sender, EventArgs e)
        {
            //Muda para a cor de foco
            tboxNomeCargo.BackColor = Color.Aqua;
        }

        private void tboxNomeCargo_Leave(object sender, EventArgs e)
        {
            //Mudar a cor do text box
            tboxNomeCargo.BackColor = Color.White;
        }

        private void tboxDescCargo_Enter(object sender, EventArgs e)
        {
            //Muda para a cor de foco
            tboxDescCargo.BackColor = Color.Aqua;
        }

        private void tboxDescCargo_Leave(object sender, EventArgs e)
        {
            //Mudar a cor do text box
            tboxDescCargo.BackColor = Color.White;
        }
    }
}
