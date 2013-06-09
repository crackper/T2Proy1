using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace DAO.House
{
    public class Producto:BaseEntity
    {
        public Int32 Id { get; set; }
        public Int32  CategoriaId { get; set; }
       
        [Display(Name="Código")]
        [Required(ErrorMessage="El codigo es requerido")]
        public string Codigo { get; set; }

        [Required(ErrorMessage = "La Descripcion es requerida")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "El precio es requerido")]
        public decimal Precio { get; set; }

        [Required(ErrorMessage = "El Stock es requerido")]
        public decimal Stock { get; set; }
        public byte[] Foto { get; set; }
        public bool Descontinuado { get; set; }
    }
}
