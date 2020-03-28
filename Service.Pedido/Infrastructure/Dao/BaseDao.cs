using Service.Pedido.Infrastructure.Context.Interfaces;

namespace Service.Pedido.Infrastructure.Dao
{
    public class BaseDao
    {
        protected IPedidoDbContext Conext { get; }

        public BaseDao(IPedidoDbContext pedidoDbContext) =>
            this.Conext = pedidoDbContext;
    }
}
