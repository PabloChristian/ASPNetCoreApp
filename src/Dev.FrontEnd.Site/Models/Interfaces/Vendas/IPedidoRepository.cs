using Dev.FrontEnd.Site.Models.Entities.Vendas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dev.FrontEnd.Site.Models.Interfaces.Vendas
{
    public interface IPedidoRepository
    {
        Pedido ObterPedido();
    }
}
