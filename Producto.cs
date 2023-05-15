using System;
using System.Collections.Generic;

namespace ProyectoReact.Models;

public partial class Producto
{
    public int? Id { get; set; }

    public double? Precio { get; set; }

    public DateTime? FechaCarga { get; set; }

    public string? Categoria { get; set; }
}
