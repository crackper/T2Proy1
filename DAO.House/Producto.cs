using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAO.House
{
    public class Producto
    {
        public Int32 Id { get; set; }
        public Int32  CategoriaId { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public decimal Stock { get; set; }
        public byte[] Foto { get; set; }
        public bool Descontinuado { get; set; }
    }
}
