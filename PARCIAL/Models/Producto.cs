using System;
using System.Collections.Generic;

namespace PARCIAL.Models;

public partial class Producto
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public decimal? Precio { get; set; }

    public int? Cantidad { get; set; }

    public string? Categoría { get; set; }

    public DateOnly? FechaAlta { get; set; }
}
