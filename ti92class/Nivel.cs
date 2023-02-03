using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ti92class
{
    public class Nivel
    {
        //Atributos - Campos
        //private int id;
        //private string nome;
        //private string sigla;

        //Propriedades - Método de Acesso
        //public int Id { get => id; set => id = value; }
        //public string Nome { get => nome; set => nome = value; }
        //public string Sigla { get => sigla; set => sigla = value; }
        private int id;
        public int Id { get; }
        public string Nome { get; set; }
        public string Sigla { get; set; }

        //Método Construtores
        public Nivel() { }
        public Nivel(string _nome, string _sigla) 
        {
            Nome= _nome;
            Sigla= _sigla;
        }
        public Nivel(int _id, string _nome, string _sigla)
        { 
        
            id = _id;
            Nome = _nome;
            Sigla = _sigla;
        }

        //Métodos da Classe
        public void Inserir()
        {
            //Gravar um novo nível na tabela níveis
        }
        public static List<Nivel> Listar()
        {
            //Entrega uma lista de todos os níveis
            List<Nivel> lista = new List<Nivel>();
            //Lógica que recupera todos os níveis da tabela
            return lista;
            
        }
        public Nivel ObterPorId(int _id)
        {
            Nivel nivel = new Nivel();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from niveis where id ="+_id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Id = dr.GetInt32(0);
                Nome = dr.GetString(1);
                Sigla = dr.GetString(2);
            }

            return nivel;
        }
        public static void Atualizar(Nivel nivel)
        {
            
        }
        public bool Excluir(int _id)
        {
            return true;
        
        }
    }
}
