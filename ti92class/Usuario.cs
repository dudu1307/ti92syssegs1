using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ti92class
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public Nivel Nivel { get; set; }
        public string Senha { get; set; }
        public bool Ativo { get; set; }

        //Método Construtores
        public Usuario() { }
        public Usuario(string _nome, string _email, Nivel _nivel, string _senha, bool _ativo)
        {
            Nome = _nome;
            Email = _email;
            Nivel = _nivel;
            Senha = _senha;
            Ativo = _ativo;
        }
        public Usuario(int _id, string nome, string email, Nivel _nivel, string senha, bool ativo)
        {
            Id = _id;
            Nome = nome;
            Email = email;
            Nivel = _nivel;
            Senha = senha;
            Ativo = ativo;
        }

        //Métodos da Classe
        public void Inserir()
        {
            //Gravar um novo usuário na tabela usuarios
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert usuarios (nome,email,nivel_id,senha,ativo) values ('" + Nome + "','" + Email + "'," + Nivel.Id + ",'" + Senha + "','" + Ativo +"')";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select @@identity";
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Connection.Close();
        }
        public static List<Usuario> Listar()
        {
            //Entrega uma lista de todos os usuários
            List<Usuario> lista = new List<Usuario>();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from usuarios order by nome asc";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Usuario
                    (dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    Nivel.ObterPorId(dr.GetInt32(4)), 
                    dr.GetString(3),
                    dr.GetBoolean(5)));
            }

            return lista;
        }
        public static Usuario ObterPorId(int _id)
        {
            Usuario usuario = new Usuario();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from usuarios where id =" + _id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                usuario.Id = dr.GetInt32(0);
                usuario.Nome = dr.GetString(1); 
                usuario.Email= dr.GetString(2);
                usuario.Nivel = Nivel.ObterPorId(dr.GetInt32(4));
                usuario.Senha= dr.GetString(3);
                usuario.Ativo = dr.GetBoolean(5);
            }

            return usuario;
        }
        public static void Atualizar(Usuario usuario)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update usuarios set nome = '" + usuario.Nome + "', email = '" + usuario.Email + "', Nivel = '" + usuario.Nivel + "', Senha = '" + usuario.Senha + "', Ativo = '" + usuario.Ativo + "' where id =" + usuario.Id;
            cmd.ExecuteReader();
        }
        public bool Excluir(int _id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from usuarios where id = " + _id;
            bool result = cmd.ExecuteNonQuery()==1?true:false;
            return result;
        }

        public static List<Usuario>BuscarPorNome(string _parte)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType= CommandType.Text;
            cmd.CommandText = "select * from usuarios where nome likw '%" + _parte + "%' order by nome;";
            var dr = cmd.ExecuteReader();
            List<Usuario> lista = new List<Usuario>();
            while (dr.Read())
            {
                lista.Add(new Usuario(
                    dr.GetInt32(0), 
                    dr.GetString(1),
                    dr.GetString(2),
                    Nivel.ObterPorId(dr.GetInt32(3)), 
                    dr.GetString(4), 
                    dr.GetBoolean(5)
                    )
                  );
            }
            return lista;
        }
    }
}
