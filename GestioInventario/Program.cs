using GestioInventario;
using System;

public class Program
{
    public static void Main(string[] args)
    {
        Inventario inventario = new Inventario();

        // Ejemplo de agregar productos
        inventario.AgregarProducto(new Producto("Producto1", 150.00m));
        inventario.AgregarProducto(new Producto("Producto2", 250.00m));
        inventario.AgregarProducto(new Producto("Producto3", 50.00m));

        Console.WriteLine("Ingrese el precio mínimo para filtrar los productos:");
        decimal precioMinimo = Convert.ToDecimal(Console.ReadLine());

        var productosFiltrados = inventario.FiltrarProductos(precioMinimo);

        Console.WriteLine("Productos filtrados:");
        foreach (var producto in productosFiltrados)
        {
            producto.MostrarInformacion();
        }
    }


   
}
