using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace ti92class
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public DateTime DataCad { get; set; }
        public bool Ativo { get; set; }

        //Métodos Construtores
        public Cliente() { }

        public Cliente(int id, string nome, string cpf, string email, DateTime dataCad, bool ativo)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Email = email;
            DataCad = dataCad;
            Ativo = ativo;
        }

        public Cliente(string nome, string cpf, string email, DateTime dataCad, bool ativo)
        {
            Nome = nome;
            Cpf = cpf;
            Email = email;
            DataCad = dataCad;
            Ativo = ativo;
        }

        //Métodos da Classe
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert clientes (nome, cpf, email, datacad, ativo)" +
                "values('" + Nome + "', '" + Cpf + "', '" + Email + "', " + DataCad + ", " + Ativo + ")";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select @@identity";
            Id = Convert.ToInt32(cmd.ExecuteScalar());
        }
        public static List<Cliente> Listar()
        {
            List<Cliente> lista = new List<Cliente>();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from cliente order by nome asc";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Cliente(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetDateTime(4),
                    dr.GetBoolean(5)
                    ));
            }
            return lista;
        }
        public static Cliente ObterPorId(int id)
        {
            Cliente cliente = new Cliente();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from clientes where id =" + id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cliente.Id = dr.GetInt32(0);
                cliente.Nome = dr.GetString(1);
                cliente.Cpf = dr.GetString(2);
                cliente.Email = dr.GetString(3);
                cliente.DataCad = dr.GetDateTime(4);
                cliente.Ativo = dr.GetBoolean(5);
            }
            return cliente;
        }

        //ATUALIZAR
        public void Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "update clientes set nome = '" + Nome + "', " +
                "cpf = '" + Cpf + "', email = '" + Email + "', datacad = " + DataCad + ", ativo = " + Ativo + ", " +
                "where id = " + Id;
            cmd.ExecuteReader();
        }

        //RESTAURAR
        public static bool Restaurar(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update clientes set nome = 0 where id =" + id;
            return cmd.ExecuteNonQuery() == 1 ? true : false;
        }

        //ARQUIVAR
        public static bool Arquivar(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update clientes set nome = 1 where id =" + id;
            return cmd.ExecuteNonQuery() == 1 ? true : false;
        }

        //BUSCAR
        public static List<Cliente> BuscarPorNome(string _parte)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from clientes where nome like '%" + _parte + "%' order by nome;";
            var dr = cmd.ExecuteReader();
            List<Cliente> lista = new List<Cliente>();
            while (dr.Read())
            {
                lista.Add(new Cliente(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetDateTime(4),
                    dr.GetBoolean(5)
                    )
                );
            }
            return lista;
        }
    }
}
