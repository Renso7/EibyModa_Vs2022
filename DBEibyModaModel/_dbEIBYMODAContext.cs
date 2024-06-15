using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DBEibyModaModel;

public partial class _dbEIBYMODAContext : DbContext
{
    public _dbEIBYMODAContext()
    {
    }

    public _dbEIBYMODAContext(DbContextOptions<_dbEIBYMODAContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Almacen> Almacen { get; set; }

    public virtual DbSet<Alquiler> Alquiler { get; set; }

    public virtual DbSet<Area> Area { get; set; }

    public virtual DbSet<CalificacionTupa> CalificacionTupa { get; set; }

    public virtual DbSet<Cargo> Cargo { get; set; }

    public virtual DbSet<CarritoCompras> CarritoCompras { get; set; }

    public virtual DbSet<Categoria> Categoria { get; set; }

    public virtual DbSet<Cliente> Cliente { get; set; }

    public virtual DbSet<Colaborador> Colaborador { get; set; }

    public virtual DbSet<DetalleDocEntrada> DetalleDocEntrada { get; set; }

    public virtual DbSet<DetalleDocSalida> DetalleDocSalida { get; set; }

    public virtual DbSet<DetallePedido> DetallePedido { get; set; }

    public virtual DbSet<DetalleVenta> DetalleVenta { get; set; }

    public virtual DbSet<DocEntrada> DocEntrada { get; set; }

    public virtual DbSet<DocSalida> DocSalida { get; set; }

    public virtual DbSet<Documento> Documento { get; set; }

    public virtual DbSet<DocumentoDerivaciones> DocumentoDerivaciones { get; set; }

    public virtual DbSet<Empleado> Empleado { get; set; }

    public virtual DbSet<Error> Error { get; set; }

    public virtual DbSet<EstadoDocumento> EstadoDocumento { get; set; }

    public virtual DbSet<FormaAsignacion> FormaAsignacion { get; set; }

    public virtual DbSet<FormaRecepcion> FormaRecepcion { get; set; }

    public virtual DbSet<Kardex> Kardex { get; set; }

    public virtual DbSet<Menu> Menu { get; set; }

    public virtual DbSet<MenuRol> MenuRol { get; set; }

    public virtual DbSet<Organizacion> Organizacion { get; set; }

    public virtual DbSet<Origen> Origen { get; set; }

    public virtual DbSet<Pedido> Pedido { get; set; }

    public virtual DbSet<PersonTipo> PersonTipo { get; set; }

    public virtual DbSet<Persona> Persona { get; set; }

    public virtual DbSet<PersonaGenero> PersonaGenero { get; set; }

    public virtual DbSet<PersonaTipoDocumento> PersonaTipoDocumento { get; set; }

    public virtual DbSet<Prioridad> Prioridad { get; set; }

    public virtual DbSet<Producto> Producto { get; set; }

    public virtual DbSet<Proveedor> Proveedor { get; set; }

    public virtual DbSet<Rol> Rol { get; set; }

    public virtual DbSet<TipoDoc> TipoDoc { get; set; }

    public virtual DbSet<TipoDocumento> TipoDocumento { get; set; }

    public virtual DbSet<Ubigeo> Ubigeo { get; set; }

    public virtual DbSet<UserSesion> UserSesion { get; set; }

    public virtual DbSet<Usuario> Usuario { get; set; }

    public virtual DbSet<VPersona> VPersona { get; set; }

    public virtual DbSet<VUsuario> VUsuario { get; set; }

    public virtual DbSet<Venta> Venta { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=ASUS-TUF-GAMING\\MSSQLSERVER01 ;Initial Catalog=EIBYMODA;Integrated Security=True;Trusted_Connection=true;Trust Server Certificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Almacen>(entity =>
        {
            entity.HasKey(e => e.IdAlmacen).HasName("PK__Almacen__7339837B329B8EF1");

            entity.Property(e => e.IdAlmacen).ValueGeneratedNever();

            entity.HasOne(d => d.IdDocEntradaNavigation).WithMany(p => p.Almacen).HasConstraintName("FK__Almacen__IdDocEn__4E88ABD4");

            entity.HasOne(d => d.IdProveedorNavigation).WithMany(p => p.Almacen).HasConstraintName("FK__Almacen__IdProve__4F7CD00D");
        });

        modelBuilder.Entity<Alquiler>(entity =>
        {
            entity.HasKey(e => e.IdAlquiler).HasName("PK__Alquiler__CB9A46B795F5AB72");

            entity.Property(e => e.IdAlquiler).ValueGeneratedNever();

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.Alquiler).HasConstraintName("FK__Alquiler__IdClie__6B24EA82");
        });

        modelBuilder.Entity<Area>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__area__3213E83FD989E370");

            entity.Property(e => e.IdEstado).HasDefaultValue(true);
        });

        modelBuilder.Entity<CalificacionTupa>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__califica__3213E83F84F0AAB4");

            entity.Property(e => e.IdEstado).HasDefaultValue(true);
        });

        modelBuilder.Entity<Cargo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__cargo__3213E83F701F425D");

            entity.Property(e => e.IdEstado).HasDefaultValue(true);
        });

        modelBuilder.Entity<CarritoCompras>(entity =>
        {
            entity.HasKey(e => e.IdCarritoCompras).HasName("PK__CarritoC__EAD196323A0AFCBA");

            entity.Property(e => e.IdCarritoCompras).ValueGeneratedNever();

            entity.HasOne(d => d.IdCategoriaNavigation).WithMany(p => p.CarritoCompras).HasConstraintName("FK__CarritoCo__IdCat__628FA481");

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.CarritoCompras).HasConstraintName("FK__CarritoCo__IdCli__60A75C0F");

            entity.HasOne(d => d.IdDetalleVentaNavigation).WithMany(p => p.CarritoCompras).HasConstraintName("FK__CarritoCo__IdDet__6383C8BA");

            entity.HasOne(d => d.IdProductoNavigation).WithMany(p => p.CarritoCompras).HasConstraintName("FK__CarritoCo__IdPro__619B8048");
        });

        modelBuilder.Entity<Categoria>(entity =>
        {
            entity.HasKey(e => e.IdCategoria).HasName("PK__Categori__A3C02A10CCA33B4D");

            entity.Property(e => e.IdCategoria).ValueGeneratedNever();
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.IdCliente).HasName("PK__Cliente__D5946642D3839294");

            entity.Property(e => e.IdCliente).ValueGeneratedNever();
        });

        modelBuilder.Entity<Colaborador>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__colabora__3213E83FE5BDBA3F");

            entity.Property(e => e.FechaActualiza).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.FechaCrea).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.IdEstado).HasDefaultValue(true);

            entity.HasOne(d => d.IdAreaNavigation).WithMany(p => p.Colaborador)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__colaborad__id_ar__0A688BB1");

            entity.HasOne(d => d.IdCargoNavigation).WithMany(p => p.Colaborador)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__colaborad__id_ca__0B5CAFEA");

            entity.HasOne(d => d.IdPersonaNavigation).WithOne(p => p.Colaborador)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__colaborad__id_pe__0C50D423");
        });

        modelBuilder.Entity<DetalleDocEntrada>(entity =>
        {
            entity.HasKey(e => e.IdDetalleDocEntrada).HasName("PK__DetalleD__8B1294F4CA30CF7F");

            entity.Property(e => e.IdDetalleDocEntrada).ValueGeneratedNever();

            entity.HasOne(d => d.IdCategoriaNavigation).WithMany(p => p.DetalleDocEntrada).HasConstraintName("FK__DetalleDo__IdCat__4AB81AF0");

            entity.HasOne(d => d.IdDocEntradaNavigation).WithMany(p => p.DetalleDocEntrada).HasConstraintName("FK__DetalleDo__IdDoc__48CFD27E");

            entity.HasOne(d => d.IdProductoNavigation).WithMany(p => p.DetalleDocEntrada).HasConstraintName("FK__DetalleDo__IdPro__49C3F6B7");

            entity.HasOne(d => d.IdProveedorNavigation).WithMany(p => p.DetalleDocEntrada).HasConstraintName("FK__DetalleDo__IdPro__4BAC3F29");
        });

        modelBuilder.Entity<DetalleDocSalida>(entity =>
        {
            entity.HasKey(e => e.IdDetalleDocSalida).HasName("PK__DetalleD__42849B66AA044DF5");

            entity.Property(e => e.IdDetalleDocSalida).ValueGeneratedNever();

            entity.HasOne(d => d.IdAlmacenNavigation).WithMany(p => p.DetalleDocSalida).HasConstraintName("FK__DetalleDo__IdAlm__5BE2A6F2");

            entity.HasOne(d => d.IdCategoriaNavigation).WithMany(p => p.DetalleDocSalida).HasConstraintName("FK__DetalleDo__IdCat__59FA5E80");

            entity.HasOne(d => d.IdDetalleVentaNavigation).WithMany(p => p.DetalleDocSalida).HasConstraintName("FK__DetalleDo__IdDet__5AEE82B9");

            entity.HasOne(d => d.IdDocEntradaNavigation).WithMany(p => p.DetalleDocSalida).HasConstraintName("FK__DetalleDo__IdDoc__5CD6CB2B");

            entity.HasOne(d => d.IdDocSalidaNavigation).WithMany(p => p.DetalleDocSalida).HasConstraintName("FK__DetalleDo__IdDoc__5812160E");

            entity.HasOne(d => d.IdProductoNavigation).WithMany(p => p.DetalleDocSalida).HasConstraintName("FK__DetalleDo__IdPro__59063A47");

            entity.HasOne(d => d.IdProveedorNavigation).WithMany(p => p.DetalleDocSalida).HasConstraintName("FK__DetalleDo__IdPro__5DCAEF64");
        });

        modelBuilder.Entity<DetallePedido>(entity =>
        {
            entity.HasKey(e => e.IdDetallePedido).HasName("PK__DetalleP__48AFFD95139C9E39");

            entity.Property(e => e.IdDetallePedido).ValueGeneratedNever();

            entity.HasOne(d => d.IdCategoriaNavigation).WithMany(p => p.DetallePedido).HasConstraintName("FK__DetallePe__IdCat__76969D2E");

            entity.HasOne(d => d.IdDetalleVentaNavigation).WithMany(p => p.DetallePedido).HasConstraintName("FK__DetallePe__IdDet__778AC167");

            entity.HasOne(d => d.IdPedidoNavigation).WithMany(p => p.DetallePedido).HasConstraintName("FK__DetallePe__IdPed__787EE5A0");

            entity.HasOne(d => d.IdProductoNavigation).WithMany(p => p.DetallePedido).HasConstraintName("FK__DetallePe__IdPro__75A278F5");
        });

        modelBuilder.Entity<DetalleVenta>(entity =>
        {
            entity.HasKey(e => e.IdDetalleVenta).HasName("PK__DetalleV__AAA5CEC2F9EC7A0F");

            entity.Property(e => e.IdDetalleVenta).ValueGeneratedNever();
        });

        modelBuilder.Entity<DocEntrada>(entity =>
        {
            entity.HasKey(e => e.IdDocEntrada).HasName("PK__DocEntra__97A219E5F10A9EBB");

            entity.Property(e => e.IdDocEntrada).ValueGeneratedNever();

            entity.HasOne(d => d.IdProveedorNavigation).WithMany(p => p.DocEntrada).HasConstraintName("FK__DocEntrad__IdPro__44FF419A");

            entity.HasOne(d => d.IdTipoDocumentoNavigation).WithMany(p => p.DocEntrada).HasConstraintName("FK__DocEntrad__IdTip__45F365D3");
        });

        modelBuilder.Entity<DocSalida>(entity =>
        {
            entity.HasKey(e => e.IdDocSalida).HasName("PK__DocSalid__A8C34201121ACDF4");

            entity.Property(e => e.IdDocSalida).ValueGeneratedNever();

            entity.HasOne(d => d.IdAlmacenNavigation).WithMany(p => p.DocSalida).HasConstraintName("FK__DocSalida__IdAlm__52593CB8");

            entity.HasOne(d => d.IdDocEntradaNavigation).WithMany(p => p.DocSalida).HasConstraintName("FK__DocSalida__IdDoc__534D60F1");

            entity.HasOne(d => d.IdProveedorNavigation).WithMany(p => p.DocSalida).HasConstraintName("FK__DocSalida__IdPro__5441852A");

            entity.HasOne(d => d.IdTipoDocNavigation).WithMany(p => p.DocSalida).HasConstraintName("FK__DocSalida__IdTip__5535A963");
        });

        modelBuilder.Entity<Documento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__document__3213E83FBAA85332");

            entity.Property(e => e.Estado).HasDefaultValue((short)1);
            entity.Property(e => e.FechaDocumento).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.FechaHoraActualizacion).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.FechaRegistro).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.HoraRegistro).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.EstadoNavigation).WithMany(p => p.Documento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__documento__estad__7849DB76");

            entity.HasOne(d => d.IdAreaAsigandoNavigation).WithMany(p => p.DocumentoIdAreaAsigandoNavigation).HasConstraintName("FK__documento__id_ar__7A3223E8");

            entity.HasOne(d => d.IdAreaOrigenNavigation).WithMany(p => p.DocumentoIdAreaOrigenNavigation).HasConstraintName("FK__documento__id_ar__793DFFAF");

            entity.HasOne(d => d.IdFormaRecepcionNavigation).WithMany(p => p.Documento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__documento__id_fo__7B264821");

            entity.HasOne(d => d.IdPersonaAsignadaNavigation).WithMany(p => p.DocumentoIdPersonaAsignadaNavigation).HasConstraintName("FK__documento__id_pe__7D0E9093");

            entity.HasOne(d => d.IdPersonaOrigenNavigation).WithMany(p => p.DocumentoIdPersonaOrigenNavigation).HasConstraintName("FK__documento__id_pe__7C1A6C5A");

            entity.HasOne(d => d.IdPrioridadNavigation).WithMany(p => p.Documento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__documento__id_pr__7E02B4CC");

            entity.HasOne(d => d.IdTipoDocumentoNavigation).WithMany(p => p.Documento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__documento__id_ti__7EF6D905");

            entity.HasOne(d => d.IdUsuarioActualizaNavigation).WithMany(p => p.DocumentoIdUsuarioActualizaNavigation).HasConstraintName("FK__documento__id_us__00DF2177");

            entity.HasOne(d => d.IdUsuarioRegistroNavigation).WithMany(p => p.DocumentoIdUsuarioRegistroNavigation).HasConstraintName("FK__documento__id_us__7FEAFD3E");

            entity.HasOne(d => d.OrigenNavigation).WithMany(p => p.Documento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__documento__orige__01D345B0");
        });

        modelBuilder.Entity<DocumentoDerivaciones>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__document__3213E83FAE7FB1FF");

            entity.Property(e => e.IdEstado).HasDefaultValue(true);

            entity.HasOne(d => d.IdAreaNavigation).WithMany(p => p.DocumentoDerivaciones).HasConstraintName("FK__documento__id_ar__756D6ECB");

            entity.HasOne(d => d.IdDocumentoNavigation).WithMany(p => p.DocumentoDerivaciones).HasConstraintName("FK__documento__id_do__76619304");

            entity.HasOne(d => d.IdDocumentoFormaAsignacionNavigation).WithMany(p => p.DocumentoDerivaciones).HasConstraintName("FK__documento__id_do__7755B73D");
        });

        modelBuilder.Entity<Empleado>(entity =>
        {
            entity.HasKey(e => e.IdEmpleado).HasName("PK__Empleado__CE6D8B9E62E1D5D1");

            entity.Property(e => e.IdEmpleado).ValueGeneratedNever();
        });

        modelBuilder.Entity<Error>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__error__3213E83F21A07C74");

            entity.Property(e => e.FechaActualiza).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.FechaCrea).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.IdPersonaNavigation).WithMany(p => p.Error).HasConstraintName("FK__error__id_person__02C769E9");

            entity.HasOne(d => d.UsuarioActualizaNavigation).WithMany(p => p.ErrorUsuarioActualizaNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__error__usuario_a__03BB8E22");

            entity.HasOne(d => d.UsuarioCreaNavigation).WithMany(p => p.ErrorUsuarioCreaNavigation).HasConstraintName("FK__error__usuario_c__04AFB25B");
        });

        modelBuilder.Entity<EstadoDocumento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__estado_d__3213E83F836CF679");

            entity.Property(e => e.IdEstado).HasDefaultValue(true);
        });

        modelBuilder.Entity<FormaAsignacion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__forma_as__3213E83F363DCA6A");

            entity.Property(e => e.IdEstado).HasDefaultValue(true);
        });

        modelBuilder.Entity<FormaRecepcion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__forma_re__3213E83F355E7CAD");

            entity.Property(e => e.IdEstado).HasDefaultValue(true);
        });

        modelBuilder.Entity<Kardex>(entity =>
        {
            entity.HasKey(e => e.IdKardex).HasName("PK__Kardex__BC1BA400B1DB5374");

            entity.Property(e => e.IdKardex).ValueGeneratedNever();

            entity.HasOne(d => d.IdCategoriaNavigation).WithMany(p => p.Kardex).HasConstraintName("FK__Kardex__IdCatego__6754599E");

            entity.HasOne(d => d.IdDetalleVentaNavigation).WithMany(p => p.Kardex).HasConstraintName("FK__Kardex__IdDetall__68487DD7");

            entity.HasOne(d => d.IdProductoNavigation).WithMany(p => p.Kardex).HasConstraintName("FK__Kardex__IdProduc__66603565");
        });

        modelBuilder.Entity<Menu>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__menu__3213E83F21DC4090");

            entity.Property(e => e.FechaActualiza).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.FechaCrea).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.IdEstado).HasDefaultValue(true);
        });

        modelBuilder.Entity<MenuRol>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__menu_rol__3213E83F01AF8549");

            entity.Property(e => e.FechaActualiza).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.FechaCrea).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.IdMenuNavigation).WithMany(p => p.MenuRol)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__menu_rol__id_men__719CDDE7");

            entity.HasOne(d => d.IdRolNavigation).WithMany(p => p.MenuRol)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__menu_rol__id_rol__72910220");
        });

        modelBuilder.Entity<Organizacion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__organiza__3213E83FAE1085BC");
        });

        modelBuilder.Entity<Origen>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__origen__3213E83FE6BA1AE6");

            entity.Property(e => e.IdEstado).HasDefaultValue(true);
        });

        modelBuilder.Entity<Pedido>(entity =>
        {
            entity.HasKey(e => e.IdPedido).HasName("PK__Pedido__9D335DC3E45C490D");

            entity.Property(e => e.IdPedido).ValueGeneratedNever();

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.Pedido).HasConstraintName("FK__Pedido__IdClient__72C60C4A");
        });

        modelBuilder.Entity<PersonTipo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__person_t__3213E83FF15ECF5C");
        });

        modelBuilder.Entity<Persona>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__persona__3213E83F0D948609");

            entity.Property(e => e.FechaActualiza).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.FechaCrea).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.IdEstado).HasDefaultValue(true);

            entity.HasOne(d => d.IdGeneroNavigation).WithMany(p => p.Persona)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__persona__id_gene__0697FACD");

            entity.HasOne(d => d.IdPersonaTipoNavigation).WithMany(p => p.Persona)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__persona__id_pers__0880433F");

            entity.HasOne(d => d.IdPersonaTipoDocumentoNavigation).WithMany(p => p.Persona).HasConstraintName("FK__persona__id_pers__078C1F06");

            entity.HasOne(d => d.IdUbigeoNavigation).WithMany(p => p.Persona).HasConstraintName("FK__persona__id_ubig__09746778");
        });

        modelBuilder.Entity<PersonaGenero>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__persona___3213E83FF4A9EB79");
        });

        modelBuilder.Entity<PersonaTipoDocumento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__persona___3213E83FD3221F99");
        });

        modelBuilder.Entity<Prioridad>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__priorida__3213E83F71AE5C8C");

            entity.Property(e => e.IdEstado).HasDefaultValue(true);
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.IdProducto).HasName("PK__Producto__0988921058F1863E");

            entity.Property(e => e.IdProducto).ValueGeneratedNever();

            entity.HasOne(d => d.IdCategoriaNavigation).WithMany(p => p.Producto).HasConstraintName("FK__Producto__IdCate__3F466844");

            entity.HasOne(d => d.IdDetalleVentaNavigation).WithMany(p => p.Producto).HasConstraintName("FK__Producto__IdDeta__403A8C7D");
        });

        modelBuilder.Entity<Proveedor>(entity =>
        {
            entity.HasKey(e => e.IdProveedor).HasName("PK__Proveedo__E8B631AF6A1D8FED");

            entity.Property(e => e.IdProveedor).ValueGeneratedNever();
        });

        modelBuilder.Entity<Rol>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__rol__3213E83F786A269F");

            entity.Property(e => e.IdEstado).HasDefaultValue(true);
        });

        modelBuilder.Entity<TipoDoc>(entity =>
        {
            entity.HasKey(e => e.IdTipoDoc).HasName("PK__TipoDoc__08119E686FC0CA85");

            entity.Property(e => e.IdTipoDoc).ValueGeneratedNever();
        });

        modelBuilder.Entity<TipoDocumento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tipo_doc__3213E83FD0A7AC51");

            entity.Property(e => e.IdEstado).HasDefaultValue(true);
        });

        modelBuilder.Entity<Ubigeo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ubigeo__3213E83F27001DCC");
        });

        modelBuilder.Entity<UserSesion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__user_ses__3213E83F4B4AD76B");

            entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.UserSesion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__user_sesi__id_us__05A3D694");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__usuario__3213E83FE3B67B58");

            entity.Property(e => e.ChangePassword).HasDefaultValue(false);
            entity.Property(e => e.FechaActualiza).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.FechaCrea).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.IdPersonaNavigation).WithMany(p => p.Usuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__usuario__id_pers__73852659");

            entity.HasOne(d => d.IdRolNavigation).WithMany(p => p.Usuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__usuario__id_rol__74794A92");
        });

        modelBuilder.Entity<VPersona>(entity =>
        {
            entity.ToView("V_Persona");
        });

        modelBuilder.Entity<VUsuario>(entity =>
        {
            entity.ToView("V_Usuario");
        });

        modelBuilder.Entity<Venta>(entity =>
        {
            entity.HasKey(e => e.IdVenta).HasName("PK__Venta__BC1240BDD232DF52");

            entity.Property(e => e.IdVenta).ValueGeneratedNever();

            entity.HasOne(d => d.IdAlquilerNavigation).WithMany(p => p.Venta).HasConstraintName("FK__Venta__IdAlquile__6FE99F9F");

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.Venta).HasConstraintName("FK__Venta__IdCliente__6E01572D");

            entity.HasOne(d => d.IdDetalleVentaNavigation).WithMany(p => p.Venta).HasConstraintName("FK__Venta__IdDetalle__6EF57B66");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
