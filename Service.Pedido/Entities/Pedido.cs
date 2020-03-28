using System.Collections.Generic;

namespace Service.Pedido.Entities
{
    public class Pedido
    {
        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public List<PedidoItem> Itens { get; set; }
        public double Total { get; set; }
        public StatusPedido Status { get; set; }
    }
}
