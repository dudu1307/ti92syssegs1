using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ti92class;

namespace ti92app
{
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {

            comboNivelUsuario.DataSource = Nivel.Listar();
            comboNivelUsuario.DisplayMember = "Nome";
            comboNivelUsuario.ValueMember = "Id";
        }


        private void btnInsereUsuario_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario(
                txtNomeUsuario.Text,
                txtEmailUsuario.Text,
                Nivel.ObterPorId((int)comboNivelUsuario.SelectedValue),
                txtSenhaUsuario.Text,
                checkBoxAtivo.Checked);
            usuario.Inserir();
            txtIdUsuario.Text = usuario.Id.ToString();
            AtualizaListBoxUsuario();
            MessageBox.Show("Nível inserido com sucesso \n ID: " + usuario.Id.ToString());

        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            if (btnEditarUsuario.Text == "Editar")
            {
                txtIdUsuario.ReadOnly = false;
                txtIdUsuario.Focus();
                btnEditarUsuario.Text = "Gravar";
                btnInsereUsuario.Enabled = false;
            }
            else
            {
                Usuario usuario = new Usuario();
                usuario.Id = int.Parse(txtIdUsuario.Text);
                usuario.Nome = txtNomeUsuario.Text;
                usuario.Email = txtEmailUsuario.Text;
                usuario.Senha = txtSenhaUsuario.Text;
                Nivel.ObterPorId(Convert.ToInt32(comboNivelUsuario));
                usuario.Ativo = checkBoxAtivo.Checked;
                Usuario.Atualizar(usuario);
                txtIdUsuario.ReadOnly = true;
                txtNomeUsuario.Focus();
                btnEditarUsuario.Text = "Editar";
                AtualizaListBoxUsuario();
            }

        }
        private void txtIdUsuario_TextChanged(object sender, EventArgs e)
        {
            if (txtIdUsuario.Text != string.Empty)
            {
                int id = int.Parse(txtIdUsuario.Text);
                var usuario = Usuario.ObterPorId(id);
                txtNomeUsuario.Text = usuario.Nome;
                txtEmailUsuario.Text = usuario.Email;
                txtSenhaUsuario.Text = usuario.Senha;
                Nivel.ObterPorId(Convert.ToInt32(comboNivelUsuario));
                checkBoxAtivo.Checked = usuario.Ativo;

            }
        }
        private void AtualizaListBoxUsuario()
        {
            List<Usuario> list = Usuario.Listar();
            listBox2.Items.Clear();
            foreach (var item in list)
            {
                listBox2.Items.Add("ID: " + item.Id + " - NOME: " + item.Nome + " - EMAIL: " + item.Email + " - SENHA: " + item.Senha + " - NIVEL: " + item.Nivel + " - ATIVO: " + item.Ativo);
            }
            txtIdUsuario.Clear();
            txtNomeUsuario.Clear();
            txtEmailUsuario.Clear();
            txtNomeUsuario.Focus();

        }

        private void btnInsereUsuario_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtNomeUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
