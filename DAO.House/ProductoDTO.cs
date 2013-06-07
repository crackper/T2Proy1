using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAO.House
{
    public class ProductoDTO
    {
        public Int32 Id { get; set; }
        public string Categoria { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public decimal Stock { get; set; }
        public byte[] Foto { get; set; }
        public bool Descontinuado { get; set; }
    }
}
