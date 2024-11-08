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



        public void ContarYAgruparProductos()
        {
            int menores100 = 0, entre100y500 = 0, mayores500 = 0;

            foreach (var producto in productos)
            {
                if (producto.Precio < 100)
                    menores100++;
                else if (producto.Precio >= 100 && producto.Precio <= 500)
                    entre100y500++;
                else
                    mayores500++;
            }

            Console.WriteLine($"Menores a 100: {menores100}");
            Console.WriteLine($"Entre 100 y 500: {entre100y500}");
            Console.WriteLine($"Mayores a 500: {mayores500}");
        }

        public void GenerarReporte()
        {
            if (productos.Count > 0)
            {
                decimal totalPrecio = 0;
                Producto productoMasCaro = productos[0];
                Producto productoMasBarato = productos[0];

                foreach (var producto in productos)
                {
                    totalPrecio += producto.Precio;

                    if (producto.Precio > productoMasCaro.Precio)
                        productoMasCaro = producto;
                    if (producto.Precio < productoMasBarato.Precio)
                        productoMasBarato = producto;
                }

                decimal precioPromedio = totalPrecio / productos.Count;
                Console.WriteLine($"Número total de productos: {productos.Count}");
                Console.WriteLine($"Precio promedio: {precioPromedio:C}");
                Console.WriteLine($"Producto más caro: {productoMasCaro.Nombre} - {productoMasCaro.Precio:C}");
                Console.WriteLine($"Producto más barato: {productoMasBarato.Nombre} - {productoMasBarato.Precio:C}");
            }
            else
            {
                Console.WriteLine("No hay productos en el inventario.");
            }
        }
    }

}

