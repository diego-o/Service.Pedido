
using System.Collections.Generic;

namespace Service.Pedido.Entities
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Valor { get; set; }

        public List<PedidoItem> Itens { get; set; }
    }
}
