using AutoMapper;
using DBEibyModaModel;
using RequestResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilAutomapper
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            //CreateMAP<AlmacenRequest , Almacen>();
       

            //AREA
            CreateMap<Area, AreaRequest>().ReverseMap();
            CreateMap<Area, AreaResponse>().ReverseMap();
            CreateMap<AreaRequest, AreaResponse>().ReverseMap();
            CreateMap<GenericFilterResponse<AreaResponse>, GenericFilterResponse<Area>>().ReverseMap();

            //ALMACEN
            CreateMap<Almacen, AlmacenRequest>().ReverseMap();
            CreateMap<Almacen, AlmacenResponse>().ReverseMap();
            CreateMap<AlmacenRequest, AlmacenResponse>().ReverseMap();
            CreateMap<GenericFilterResponse<AlmacenResponse>, GenericFilterResponse<Almacen>>().ReverseMap();

            //ALQUILER
            CreateMap<Alquiler, AlquilerRequest>().ReverseMap();
            CreateMap<Alquiler, AlquilerResponse>().ReverseMap();
            CreateMap<AlquilerRequest, AlquilerResponse>().ReverseMap();
            CreateMap<GenericFilterResponse<AlquilerResponse>, GenericFilterResponse<Alquiler>>().ReverseMap();

            //CARRITO COMPRAS
            CreateMap<CarritoCompras, CarritoComprasRequest>().ReverseMap();
            CreateMap<CarritoCompras, CarritoComprasResponse>().ReverseMap();
            CreateMap<CarritoComprasRequest, CarritoComprasResponse>().ReverseMap();
            CreateMap<GenericFilterResponse<CarritoComprasResponse>, GenericFilterResponse<CarritoCompras>>().ReverseMap();

            //CATEGORIA
            CreateMap<Categoria, CategoriaRequest>().ReverseMap();
            CreateMap<Categoria, CategoriaResponse>().ReverseMap();
            CreateMap<CategoriaRequest, CategoriaResponse>().ReverseMap();
            CreateMap<GenericFilterResponse<CategoriaResponse>, GenericFilterResponse<Categoria>>().ReverseMap();

            //Cliente
            CreateMap<Cliente, ClienteRequest>().ReverseMap();
            CreateMap<Cliente, ClienteResponse>().ReverseMap();
            CreateMap<ClienteRequest, ClienteResponse>().ReverseMap();
            CreateMap<GenericFilterResponse<ClienteResponse>, GenericFilterResponse<Cliente>>().ReverseMap();

            //CARGO
            CreateMap<Cargo, CargoRequest>().ReverseMap();
            CreateMap<Cargo, CargoResponse>().ReverseMap();
            CreateMap<CargoRequest, CargoResponse>().ReverseMap();
            CreateMap<GenericFilterResponse<CargoResponse>, GenericFilterResponse<Cargo>>().ReverseMap();

            //DocumentoDerivaciones
            CreateMap<DocumentoDerivaciones, DocumentoDerivacionesRequest>().ReverseMap();
            CreateMap<DocumentoDerivaciones, DocumentoDerivacionesResponse>().ReverseMap();
            CreateMap<DocumentoDerivacionesRequest, DocumentoDerivacionesResponse>().ReverseMap();
            CreateMap<GenericFilterResponse<DocumentoDerivacionesResponse>, GenericFilterResponse<DocumentoDerivaciones>>().ReverseMap();

            //DOCUMENTO
            CreateMap<Documento, DocumentoRequest>().ReverseMap();
            CreateMap<Documento, DocumentoResponse>().ReverseMap();
            CreateMap<DocumentoRequest, DocumentoResponse>().ReverseMap();
            CreateMap<GenericFilterResponse<DocumentoResponse>, GenericFilterResponse<Documento>>().ReverseMap();

            //DetalleDocEntrada
            CreateMap<DetalleDocEntrada, DetalleDocEntradaRequest>().ReverseMap();
            CreateMap<DetalleDocEntrada, DetalleDocEntradaResponse>().ReverseMap();
            CreateMap<DetalleDocEntradaRequest, DetalleDocEntradaResponse>().ReverseMap();
            CreateMap<GenericFilterResponse<DetalleDocEntradaResponse>, GenericFilterResponse<DetalleDocEntrada>>().ReverseMap();

            //DetalleDocSalida
            CreateMap<DetalleDocSalida, DetalleDocSalidaRequest>().ReverseMap();
            CreateMap<DetalleDocSalida, DetalleDocSalidaResponse>().ReverseMap();
            CreateMap<DetalleDocSalidaRequest, DetalleDocSalidaResponse>().ReverseMap();
            CreateMap<GenericFilterResponse<DetalleDocSalidaResponse>, GenericFilterResponse<DetalleDocSalida>>().ReverseMap();

            //DetallePedido
            CreateMap<DetallePedido, DetallePedidoRequest>().ReverseMap();
            CreateMap<DetallePedido, DetallePedidoResponse>().ReverseMap();
            CreateMap<DetallePedidoRequest, DetallePedidoResponse>().ReverseMap();
            CreateMap<GenericFilterResponse<DetallePedidoResponse>, GenericFilterResponse<DetallePedido>>().ReverseMap();

            //DetalleVenta
            CreateMap<DetalleVenta, DetalleVentaRequest>().ReverseMap();
            CreateMap<DetalleVenta, DetalleVentaResponse>().ReverseMap();
            CreateMap<DetalleVentaRequest, DetalleVentaResponse>().ReverseMap();
            CreateMap<GenericFilterResponse<DetalleVentaResponse>, GenericFilterResponse<DetalleVenta>>().ReverseMap();

            // DocEntrada
            CreateMap<DocEntrada, DocEntradaRequest>().ReverseMap();
            CreateMap<DocEntrada, DocEntradaResponse>().ReverseMap();
            CreateMap<DocEntradaRequest, DocEntradaResponse>().ReverseMap();
            CreateMap<GenericFilterResponse<DocEntradaResponse>, GenericFilterResponse<DocEntrada>>().ReverseMap();

            //DocSalida
            CreateMap<DocSalida, DocSalidaRequest>().ReverseMap();
            CreateMap<DocSalida, DocSalidaResponse>().ReverseMap();
            CreateMap<DocSalidaRequest, DocSalidaResponse>().ReverseMap();
            CreateMap<GenericFilterResponse<DocSalidaResponse>, GenericFilterResponse<DocSalida>>().ReverseMap();

            // EMPLEADO
            CreateMap<EstadoDocumento, EstadoDocumentoRequest>().ReverseMap();
            CreateMap<EstadoDocumento, EstadoDocumentoResponse>().ReverseMap();
            CreateMap<EstadoDocumentoRequest, EstadoDocumentoResponse>().ReverseMap();
            CreateMap<GenericFilterResponse<EstadoDocumentoResponse>, GenericFilterResponse<EstadoDocumento>>().ReverseMap();

            //FORMA ASIGNAR
            CreateMap<FormaAsignacion, FormaAsignacionRequest>().ReverseMap();
            CreateMap<FormaAsignacion, FormaAsignacionResponse>().ReverseMap();
            CreateMap<FormaAsignacionRequest, FormaAsignacionResponse>().ReverseMap();
            CreateMap<GenericFilterResponse<FormaAsignacionResponse>, GenericFilterResponse<FormaAsignacion>>().ReverseMap();

            //FORMA DE RECEPCION
            CreateMap<FormaRecepcion, FormaRecepcionRequest>().ReverseMap();
            CreateMap<FormaRecepcion, FormaRecepcionResponse>().ReverseMap();
            CreateMap<FormaRecepcionRequest, FormaRecepcionResponse>().ReverseMap();
            CreateMap<GenericFilterResponse<FormaRecepcionResponse>, GenericFilterResponse<FormaRecepcion>>().ReverseMap();

            //Empleado
            CreateMap<Empleado, EmpleadoRequest>().ReverseMap();
            CreateMap<Empleado, EmpleadoResponse>().ReverseMap();
            CreateMap<EmpleadoRequest, EmpleadoResponse>().ReverseMap();
            CreateMap<GenericFilterResponse<EmpleadoResponse>, GenericFilterResponse<Empleado>>().ReverseMap();

            //Kardex
            CreateMap<Kardex, KardexRequest>().ReverseMap();
            CreateMap<Kardex, KardexResponse>().ReverseMap();
            CreateMap<KardexRequest, KardexResponse>().ReverseMap();
            CreateMap<GenericFilterResponse<KardexResponse>, GenericFilterResponse<Kardex>>().ReverseMap();

            //ORIGEN
            CreateMap<Origen, OrigenRequest>().ReverseMap();
            CreateMap<Origen, OrigenResponse>().ReverseMap();
            CreateMap<OrigenRequest, OrigenResponse>().ReverseMap();
            CreateMap<GenericFilterResponse<OrigenResponse>, GenericFilterResponse<Origen>>().ReverseMap();

            //Pedido
            CreateMap<Pedido, PedidoRequest>().ReverseMap();
            CreateMap<Pedido, PedidoResponse>().ReverseMap();
            CreateMap<PedidoRequest, PedidoResponse>().ReverseMap();
            CreateMap<GenericFilterResponse<PedidoResponse>, GenericFilterResponse<Pedido>>().ReverseMap();

            //PERSONA
            CreateMap<Persona, PersonaRequest>().ReverseMap();
            CreateMap<Persona, PersonaResponse>().ReverseMap();
            CreateMap<PersonaRequest, PersonaResponse>().ReverseMap();
            CreateMap<GenericFilterResponse<PersonaResponse>, GenericFilterResponse<Persona>>().ReverseMap();

            //PRIORIDAD
            CreateMap<Prioridad, PrioridadRequest>().ReverseMap();
            CreateMap<Prioridad, PrioridadResponse>().ReverseMap();
            CreateMap<PrioridadRequest, PrioridadResponse>().ReverseMap();
            CreateMap<GenericFilterResponse<PrioridadResponse>, GenericFilterResponse<Prioridad>>().ReverseMap();

            //Producto
            CreateMap<Producto, ProductoRequest>().ReverseMap();
            CreateMap<Producto, ProductoResponse>().ReverseMap();
            CreateMap<ProductoRequest, ProductoResponse>().ReverseMap();
            CreateMap<GenericFilterResponse<ProductoResponse>, GenericFilterResponse<Producto>>().ReverseMap();

            //Proveedor
            CreateMap<Proveedor, ProveedorRequest>().ReverseMap();
            CreateMap<Proveedor, ProveedorResponse>().ReverseMap();
            CreateMap<ProveedorRequest, ProveedorResponse>().ReverseMap();
            CreateMap<GenericFilterResponse<AreaResponse>, GenericFilterResponse<Proveedor>>().ReverseMap();

            //TipoDoc
            CreateMap<TipoDoc, TipoDocRequest>().ReverseMap();
            CreateMap<TipoDoc, TipoDocResponse>().ReverseMap();
            CreateMap<TipoDocRequest, TipoDocResponse>().ReverseMap();
            CreateMap<GenericFilterResponse<TipoDocResponse>, GenericFilterResponse<TipoDoc>>().ReverseMap();

            //Usuario
            CreateMap<Usuario, UsuarioRequest>().ReverseMap();
            CreateMap<Usuario, UsuarioResponse>().ReverseMap();
            CreateMap<UsuarioRequest, UsuarioResponse>().ReverseMap();
            CreateMap<GenericFilterResponse<UsuarioResponse>, GenericFilterResponse<Usuario>>().ReverseMap();

            //Venta
            CreateMap<Venta, VentaRequest>().ReverseMap();
            CreateMap<Venta, VentaResponse>().ReverseMap();
            CreateMap<VentaRequest, VentaResponse>().ReverseMap();
            CreateMap<GenericFilterResponse<VentaResponse>, GenericFilterResponse<Venta>>().ReverseMap();
        }
    }
}
