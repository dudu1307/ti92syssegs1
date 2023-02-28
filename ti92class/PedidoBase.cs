using System;

namespace ti92class
{
    public class PedidoBase
    {
        public Cliente Cliente { get; set; }
        public DateTime Data { get; set; }
        public double Desconto { get; set; }
        public string Status { get; set; }
        public Usuario Usuario { get; set; }
    }
}