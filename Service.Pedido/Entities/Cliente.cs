using System.Collections.Generic;

namespace Service.Pedido.Entities
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Senha { get; set; }
        public Endereco Endereco { get; set; }
        public List<Pedido> Pedidos { get; set; }
    }
}
