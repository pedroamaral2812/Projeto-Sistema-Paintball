using ProjetoPaintball.Modelo;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Fecha o janela
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Verifica se não foi preenchidos o campo login
            if ((tboxLogin.Text == "") && (tboxSenha.Text != ""))
            {
                //Messagem informando o usuario que o login não foi preenchido
                MessageBox.Show("Login não preenchido!!! Por favor preencha", "Faltando preencher o campo Login ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //Verifica se não foi preenchidos o campo senha 
            else if ((tboxLogin.Text != "") && (tboxSenha.Text == ""))
            {
                //Messagem informando o usuario que o login não foi preenchido
                MessageBox.Show("Senha não preenchida!!! Por favor preencha", "Faltando preencher o campo senha ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            //Verifica se não foi preenchidos os campos login e senha 
            else if ((tboxLogin.Text == "") && (tboxSenha.Text == ""))
            {
                //Messagem informando o usuario que o login não foi preenchido
                MessageBox.Show("Login e Senha não preenchidos!!! Por favor preencha os campos login e senha", "Faltando preencher os campos login e senha ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            //Quando foi preenchido os dois campos
            else
            {
                //Cria o objeto do modelo de controleLogin
                ControleLogin controleLogin = new ControleLogin();

                //Passa o campos de login e senha para a função fazerLogin
                controleLogin.fazerLogin(tboxLogin.Text, tboxSenha.Text);

                //Verifica se o login retornou true
                if (controleLogin.varpub_bool_LoginCorreto)
                {
                    // Informa ao usuario que o login feito corretamente
                    MessageBox.Show("Logado com sucesso", "ENTRANDO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Fecha a tela de login
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Login ou senha invalido!!! Verifique login e senha", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
