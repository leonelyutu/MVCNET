namespace Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class InventarioContext : DbContext
    {
        public InventarioContext()
            : base("name=InventarioContext")
        {
        }

        public virtual DbSet<Marca> Marca { get; set; }
        public virtual DbSet<Producto> Producto { get; set; }
        public virtual DbSet<Proveedor> Proveedor { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TipoProducto> TipoProducto { get; set; }
        public virtual DbSet<UnidadDeMedida> UnidadDeMedida { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Marca>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.Ubicacion)
                .IsUnicode(false);

            modelBuilder.Entity<Proveedor>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Proveedor>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Proveedor>()
                .Property(e => e.Direccion)
                .IsUnicode(false);

            modelBuilder.Entity<Proveedor>()
                .Property(e => e.Contacto)
                .IsUnicode(false);

            modelBuilder.Entity<Proveedor>()
                .HasMany(e => e.Producto)
                .WithOptional(e => e.Proveedor)
                .HasForeignKey(e => e.Id_Proveeedor);

            modelBuilder.Entity<TipoProducto>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<TipoProducto>()
                .HasMany(e => e.Producto)
                .WithRequired(e => e.TipoProducto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UnidadDeMedida>()
                .Property(e => e.Nombre)
                .IsUnicode(false);
        }
    }
}
