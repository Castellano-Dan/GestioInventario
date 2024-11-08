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

       

    }


   
}
