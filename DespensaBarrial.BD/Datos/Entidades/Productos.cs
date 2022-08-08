using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;




namespace DespensaBarrial.BD.Datos.Entidades
{

    [Index(nameof(NombreProducto), Name = "Producto: Dragon Ball Z", IsUnique = true)]


    public class Productos:EntityBase
    {


        [Required]

        [MaxLength(9, ErrorMessage = "La clave debe ser una combinacion alfanumerica")]
        public string ClaveProducto { get; set; }

        [Required]
        public string NombreProducto { get; set; }

        [Required]

        public string DescripcionProducto { get; set; }


        public DateTime? FechaVencimientoProducto { get; set; }

        //deberia crear una llave foranea o compuesta que relacione la tabla esta con la de proveedores


        [Required]

        [Precision(14, 2)]
        public decimal PrecioProducto { get; set; }

        public bool VencimimentoProducto(DateTime FechaCaducidad, int id)
        {
            Productos productos = new Productos();

            bool CambiarProducto = false;

            if (FechaVencimientoProducto.Equals(FechaCaducidad))
            {
                Console.WriteLine("El producto esta vencido");

                if (productos.Id.Equals(id))
                {
                    CambiarProducto = true;

                    Console.WriteLine("Tenemos que cambiar el producto");

                }
            }
            else if (FechaVencimientoProducto != FechaCaducidad) return true;



            return CambiarProducto;
        }



        public HashSet<Categorias> categorias { get; set; }


    }
}
