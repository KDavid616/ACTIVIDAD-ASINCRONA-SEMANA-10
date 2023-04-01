using Almacen.DAO;
using Almacen.Models;
using Microsoft.Identity.Client;
using System.Collections.Generic;

CrudAlmacen crudAlmacen = new CrudAlmacen();

while(true)
{
    Console.WriteLine("Que quieres hacer? \n");
    Console.WriteLine("Coloca el numero de opcion:\n");
    Console.WriteLine("1. Agregar producto\n");
    Console.WriteLine("2. Actualizar producto\n");
    Console.WriteLine("3. Eliminar producto\n");
    Console.WriteLine("4. ver productos\n");
    string opcion = Console.ReadLine();
    Console.Clear();
    
    switch (opcion)
    {
        case "1":
            crudAlmacen.añadir();
            break;

        case "2":
            Console.WriteLine("Ingresa el id del producto:");
            crudAlmacen.Actualizar(Console.ReadLine());
            break;

        case "3":
            Console.WriteLine("Ingresa el id del producto:");
            crudAlmacen.Eliminar(Console.ReadLine());
            break;

        case "4":
            Console.WriteLine("productos de la tabla\n");
            var ver = crudAlmacen.ListarProducto();

            int numero_tabla = 1;
            foreach (var item in ver)
            {
                Console.WriteLine($"{numero_tabla}.. {item.IdProducto}, {item.Nombre}, {item.Descripcion}, {item.Precio}, {item.Stock} \n");
                numero_tabla++;
            }
            break;
    }

    Console.WriteLine("Preciona cualquier tecla para continuar...");
    Console.ReadLine();
    Console.Clear();

}


