using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioInventario
{
    public class Inventario
    
    {
        private List<Producto> productos;

        public Inventario()
        {
            productos = new List<Producto>();
        }

        public void AgregarProducto(Producto producto)
        {
            productos.Add(producto);
        }

        public List<Producto> FiltrarProductos(decimal precioMinimo)
        {
            return productos.Where(p => p.Precio > precioMinimo)
                            .OrderBy(p => p.Precio)
                            .ToList();
        }

        public void MostrarProductos()
        {
            foreach (var producto in productos)
            {
                producto.MostrarInformacion();
            }
        }
    }
}

