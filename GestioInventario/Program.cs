using GestioInventario;
using System;

public class Program
{
    public static void Main(string[] args)
    {
        Inventario inventario = new Inventario();


        inventario.AgregarProducto(new Producto("Birkin bag", 120.000m));
        inventario.AgregarProducto(new Producto("Cartier Bracelet", 80.000m));
        inventario.AgregarProducto(new Producto("Vancleef necklace", 90.000m));

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


            switch (opcion)
            {
                case "1":
                    
                    Console.Write("Ingrese el precio mínimo para filtrar los productos: ");
                    decimal precioMinimo = Convert.ToDecimal(Console.ReadLine());
                    var productosFiltrados = inventario.FiltrarProductos(precioMinimo);
                    Console.WriteLine("Productos filtrados:");
                    foreach (var producto in productosFiltrados)
                    {
                        producto.MostrarInformacion();
                    }
                    break;

                case "2":
                   
                    Console.Write("Ingrese el nombre del producto para actualizar el precio: ");
                    string nombreProducto = Console.ReadLine();
                    Console.Write("Ingrese el nuevo precio: ");
                    decimal nuevoPrecio = Convert.ToDecimal(Console.ReadLine());
                    inventario.ActualizarPrecio(nombreProducto, nuevoPrecio);
                    break;

                case "3":
                   
                    Console.Write("Ingrese el nombre del producto que desea eliminar: ");
                    string nombreEliminar = Console.ReadLine();
                    inventario.EliminarProducto(nombreEliminar);
                    break;

                case "4":
                   
                    inventario.ContarYAgruparProductos();
                    break;

                case "5":
                   
                    inventario.GenerarReporte();
                    break;

                case "6":
                   
                    Console.WriteLine("¡Hasta luego!");
                    return;

                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;
            }


        }



    }
}
