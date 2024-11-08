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

        public void ActualizarPrecio(string nombre, decimal nuevoPrecio)
        {
            foreach (var producto in productos)
            {
                if (producto.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase))
                {
                    if (nuevoPrecio > 0)
                    {
                        producto.Precio = nuevoPrecio;
                        Console.WriteLine("Precio actualizado.");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("El precio debe ser positivo.");
                        return;
                    }
                }
            }
            Console.WriteLine("Producto no encontrado.");
        }

        public void EliminarProducto(string nombre)
        {
            Producto productoAEliminar = null;
            foreach (var producto in productos)
            {
                if (producto.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase))
                {
                    productoAEliminar = producto;
                    break;
                }
            }

            if (productoAEliminar != null)
            {
                productos.Remove(productoAEliminar);
                Console.WriteLine("Producto eliminado.");
            }
            else
            {
                Console.WriteLine("Producto no encontrado.");
            }
        }

    }
}

