using GestioInventario;
using System;

public class Program
{
    public static void Main(string[] args)
    {
        Inventario inventario = new Inventario();

       
        inventario.AgregarProducto(new Producto("Birkin bag", 120.00m));
        inventario.AgregarProducto(new Producto("Cartier Bracelet", 80.00m));
        inventario.AgregarProducto(new Producto("Vancleef necklace", 90.00m));

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
