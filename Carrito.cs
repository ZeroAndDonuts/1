using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem4
{
    internal class Carrito
    {
        private List<Items> items;
        public Carrito()
        {
            items = new List<Items>();
        }
        public int StockDisponible() => Disponible.Count;
        public int StockAgotado() => Agotado.Count;
        public List<Items> Disponible => items.FindAll(x => x.Stock() >= items.Count);
        public List<Items> Agotado => items.FindAll(x => x.Stock() >= items.Count);
        public float Stock()
        {
            float Carrito = 0;
            foreach (var item in items)
            {
                Carrito += item.Stock();
            }
            return Carrito / items.Count;
        }
    }
}
