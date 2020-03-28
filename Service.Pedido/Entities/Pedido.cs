using System.Collections.Generic;

namespace Service.Pedido.Entities
{
    public class Pedido
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public Cliente Cliente { get; set; }
        public int IdStatusPedido { get; set; }
        public StatusPedido StatusPedido { get; set; }
        public double Total { get; set; }
        
        public List<PedidoItem> Itens { get; set; }
    }
}
