using System;
using System.Collections.Generic;

#nullable disable

namespace BackendPruebaTecnica.Models
{
    public partial class Producto
    {
        public int IdProducto { get; set; }
        public string NombreProducto { get; set; }
        public string EstadoProducto { get; set; }
        public DateTime? FechaSalida { get; set; }
    }
}
