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
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void TelaPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Cria uma janela de opções
            Application.Exit();
        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void cadastroDeUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Chama a tela de cadastro de usuario
            CadUsuario cadUsuario = new CadUsuario();
            cadUsuario.ShowDialog();
        }

        private void TelaPrincipal_Enter(object sender, EventArgs e)
        {
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void cadastroDeFuncionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Chama a tela de cadastro de cargo de funcionario
            CadCargoFunc cadCargoFunc = new CadCargoFunc();
            cadCargoFunc.ShowDialog();
        }

        private void cadastroDeFuncionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Chama a tela de cadastro de funcionario
            CadFunc cadFunc = new CadFunc();
            cadFunc.ShowDialog();
        }

        private void cadastroDeArmasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Chama a tela de cadastro de tipo de arma
            CadTipoArma cadTipoArma = new CadTipoArma();
            cadTipoArma.ShowDialog();
        }
    }
}
