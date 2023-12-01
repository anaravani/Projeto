using Projeto.Models;

namespace Projeto.ViewModel
{
    public class PedidoItensViewModel
    {
        public Pedido Pedidos { get; set; }
        public IEnumerable<PedidoItem> PedidoItens { get; set; }
    }
}