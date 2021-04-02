using Dev.FrontEnd.Site.Models.Entities.Vendas;
using Dev.FrontEnd.Site.Models.Interfaces.Vendas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dev.FrontEnd.Site.Data.Vendas
{
    public class PedidoRepository : IPedidoRepository
    {
        public PedidoRepository()
        {
        }
        public Pedido ObterPedido()
        {
            return new Pedido();
        }
    }
}
