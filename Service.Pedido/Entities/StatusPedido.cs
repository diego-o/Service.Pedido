﻿
using System.Collections.Generic;

namespace Service.Pedido.Entities
{
    public class StatusPedido
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        public List<Pedido> Pedidos { get; set; }
    }
}
