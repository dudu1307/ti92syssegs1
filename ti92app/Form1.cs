﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboNivelUsuario.DataSource = Nivel.Listar();
            comboNivelUsuario.DisplayMember = "Nome";
            comboNivelUsuario.ValueMember = "Id";
            AtualizaListBox();
            
        }
        private void btnInsereNivel_Click(object sender, EventArgs e)
        {
            Nivel nivel = new Nivel(txtNomeNivel.Text, txtSiglaNivel.Text);
            nivel.Inserir();
            txtIdNivel.Text = nivel.Id.ToString();
            AtualizaListBox();
            MessageBox.Show("Nível inserido com sucesso \n ID: " + nivel.Id.ToString());
          
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (btnEditar.Text=="Editar")
            {
                txtIdNivel.ReadOnly = false;
                txtIdNivel.Focus();
                btnEditar.Text = "Gravar";
                btnInsereNivel.Enabled= false;
            }
            else
            {
                Nivel nivel = new Nivel();
                nivel.Id = int.Parse(txtIdNivel.Text);
                nivel.Nome = txtNomeNivel.Text;
                nivel.Sigla= txtSiglaNivel.Text;
                Nivel.Atualizar(nivel);
                txtIdNivel.ReadOnly = true;
                txtNomeNivel.Focus();
                btnEditar.Text = "Editar";
                AtualizaListBox();
            }
           
        }

        private void txtIdNivel_TextChanged(object sender, EventArgs e)
        {
            if (txtIdNivel.Text!=string.Empty)
            {
                int id = int.Parse(txtIdNivel.Text);
                var nivel = Nivel.ObterPorId(id);
                txtNomeNivel.Text = nivel.Nome;
                txtSiglaNivel.Text = nivel.Sigla;
            }
          
        }
        private void  AtualizaListBox()
        {
            List<Nivel> list = Nivel.Listar();
            listBox1.Items.Clear();
            foreach (var item in list)
            {
                listBox1.Items.Add("ID: "+item.Id+ " - NOME: " +item.Nome+ " - SIGLA: " +item.Sigla);
            }
            txtIdNivel.Clear();
            txtNomeNivel.Clear();
            txtSiglaNivel.Clear();
            txtNomeNivel.Focus();

        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            //Se txtBusca.Text for diferente de vazio
            //e (&&) txtBsuca.Text.Length for maior ou igual a 2
            if(txtBusca.Text!=string.Empty && txtBusca.Text.Length>=2)
            {
                listBox1.Items.Clear();
                var niveis = Nivel.BuscarPorNome(txtBusca.Text);
                if (niveis.Count > 0)
                {
                    foreach(var nivel in niveis)
                    {
                        listBox1.Items.Add(nivel.Id + " - " +nivel.Nome + " - "+nivel.Sigla);
                    }
                }
                else
                {    
                    listBox1.Items.Add("Não há registros para essa busca");
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if(txtIdNivel.Text!=string.Empty)
            {
                Nivel nivel = Nivel.ObterPorId(int.Parse(txtIdNivel.Text));
                if(nivel.Excluir(nivel.Id))
                {
                    MessageBox.Show("Nível "+ nivel.Nome+" excluído com sucesso", "Exclusão de nível");
                    AtualizaListBox();
                }
            }
        }

        //USUÁRIOS

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
            AtualizaListBox();
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
                    AtualizaListBox();
                }
            
        }

        private void txtIdUsuario_TextChanged(object sender, EventArgs e)
        {
            if (txtIdUsuario.Text!=string.Empty)
            {
                int id = int.Parse(txtIdUsuario.Text);
                var usuario = Usuario.ObterPorId(id);
                txtNomeUsuario.Text = usuario.Nome;
                txtEmailUsuario.Text = usuario.Email;
                txtSenhaUsuario.Text= usuario.Senha;
                Nivel.ObterPorId(Convert.ToInt32(comboNivelUsuario));
                checkBoxAtivo.Checked= usuario.Ativo;

            }
        }
        private void AtualizaListBoxUsuario()
        {
            List<Usuario> list = Usuario.Listar();
            listBox2.Items.Clear();
            foreach (var item in list)
            {
                listBox2.Items.Add("ID: " + item.Id + " - NOME: " + item.Nome + " - EMAIL: " + item.Email + " - SENHA: " + item.Senha + " - NIVEL: " +item.Nivel + " - ATIVO: " +item.Ativo);
            }
            txtIdUsuario.Clear();
            txtNomeUsuario.Clear();
            txtEmailUsuario.Clear();
            txtNomeUsuario.Focus();

        }
    }
}
