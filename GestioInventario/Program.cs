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

        while (true)
        {
           
            Console.Clear();
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1. Filtrar productos por precio");
            Console.WriteLine("2. Actualizar precio de un producto");
            Console.WriteLine("3. Eliminar producto");
            Console.WriteLine("4. Contar y agrupar productos por precio");
            Console.WriteLine("5. Generar reporte");
            Console.WriteLine("6. Salir");
            Console.Write("Ingrese una opción: ");
            string opcion = Console.ReadLine();

        }



    }
}
