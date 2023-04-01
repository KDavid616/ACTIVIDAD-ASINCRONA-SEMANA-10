using System;
using System.Collections.Generic;

namespace Almacen.Models;

public partial class Producto
{
    public string IdProducto { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public int Precio { get; set; }

    public int Stock { get; set; }
}
