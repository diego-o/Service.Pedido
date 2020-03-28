
namespace Service.Pedido.Entities
{
    public class PedidoItem
    {
        public int IdPedido { get; set; }
        public int IdProduto { get; set; }

        public Pedido Pedido { get; set; }
        public Produto Produto { get; set; }
    }
}
