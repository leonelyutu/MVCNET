namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("Producto")]
    public partial class Producto
    {
       

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id_Producto { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(50)]
        public string Descripcion { get; set; }

        public int Id_TipoProducto { get; set; }

        public int? Id_Proveeedor { get; set; }

        public int? Id_Marca { get; set; }

        public double Precio_Unitario_Costo { get; set; }

        public double Precio_Unitario_Venta { get; set; }

        public int Cantidad_por_UDM { get; set; }

        public int? Id_UnidadDeMedida { get; set; }

        [Required]
        [StringLength(50)]
        public string Ubicacion { get; set; }

        public int Unidades_en_Bodega { get; set; }

        public virtual Marca Marca { get; set; }

        public virtual Proveedor Proveedor { get; set; }

        public virtual TipoProducto TipoProducto { get; set; }

        public virtual UnidadDeMedida UnidadDeMedida { get; set; }

        public List<Producto> Listar() {

            var productos = new List<Producto>();


            try
            {
                using (var context = new InventarioContext()) {

                    productos = context.Producto.ToList();
                } 

            }
            catch (Exception)
            {

                throw;
            }

            return productos;
        }

    }



}
