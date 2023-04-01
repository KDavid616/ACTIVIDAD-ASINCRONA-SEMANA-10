using Almacen.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacen.DAO
{
    public class CrudAlmacen
    {
        public void añadir()
        {
            using (AlmacenContext db = new AlmacenContext())
            {
                Producto producto = new Producto();

                Console.WriteLine("Inserte el id del producto:\n");
                producto.IdProducto = Console.ReadLine();

                Console.WriteLine("\nInserte el Nombre del producto:");
                producto.Nombre = Console.ReadLine();

                Console.WriteLine("\nInserte la descripcion del producto:");
                producto.Descripcion = Console.ReadLine();

                Console.WriteLine("\nInserte el Precio del producto:");
                producto.Precio = Int32.Parse(Console.ReadLine());

                Console.WriteLine("\nIngresa el stock del producto:");
                producto.Stock = Int32.Parse(Console.ReadLine());

                db.Add(producto);
                db.SaveChanges();
                Console.WriteLine("Los datos se añadieron exitosamente\n");
            }
        }
        
        public void Actualizar(string idprod)
        {
            using (AlmacenContext db = new AlmacenContext())
            {
                var buscar = db.Productos.FirstOrDefault(x=> x.IdProducto == idprod);


                buscar.Nombre = "Manzanas";

                buscar.Descripcion = "deliciosas manzanas";

                buscar.Precio = 12;

                buscar.Stock = 33;

                db.Update(buscar);
                db.SaveChanges();
                Console.WriteLine("Los datos se actualizaron exitosamente\n");
            }
        }

        public void Eliminar(string idprod)
        {
            using (AlmacenContext db = new AlmacenContext())
            {
                var buscar = db.Productos.FirstOrDefault(x => x.IdProducto == idprod);
                db.Remove(buscar);
                db.SaveChanges();
                Console.WriteLine("Los datos se eliminaron exitosamente\n");
            }
        }

        public void Ver()
        {
            using (var db = new AlmacenContext())
            {
                
                foreach (var item in db.Productos) {

                    Console.WriteLine($"{item}\n");
                }
                
                
            }
        }

        public List<Producto> ListarProducto()
        {
            using (AlmacenContext db =
                   new AlmacenContext())
            {
                return db.Productos.ToList();
            }

        }

    }
}
