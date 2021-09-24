using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace POS_Fiscal
{

    public partial class Printer
    {
        //Conexion
            // ConfigurarVelocidad()
            [System.Runtime.InteropServices.DllImport("EpsonFiscalInterface.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi,
                                                                                    CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
            public static extern int ConfigurarVelocidad(int velocidad);

            // ConfigurarPuerto()
            [System.Runtime.InteropServices.DllImport("EpsonFiscalInterface.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi,
                                                                                    CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
            public static extern int ConfigurarPuerto(string puerto);

            // Conectar()
            [System.Runtime.InteropServices.DllImport("EpsonFiscalInterface.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi,
                                                                                    CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
            public static extern int Conectar();

            // Desconectar()
            [System.Runtime.InteropServices.DllImport("EpsonFiscalInterface.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi,
                                                                                    CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
            public static extern int Desconectar();

            // ReConectar()
            [System.Runtime.InteropServices.DllImport("EpsonFiscalInterface.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi,
                                                                                    CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
            public static extern int ReConectar();
            // Calcelar()
            [System.Runtime.InteropServices.DllImport("EpsonFiscalInterface.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi,
                                                                                CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
            public static extern int Cancelar();
        //Log
            // ComenzarLog
            [System.Runtime.InteropServices.DllImport("EpsonFiscalInterface.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi,
                                                                           CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
            public static extern int ComenzarLog(bool incluir_tramas);


            // DetenerLog
            [System.Runtime.InteropServices.DllImport("EpsonFiscalInterface.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi,
                                                                           CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
            public static extern int DetenerLog();


            // PausarLog
            [System.Runtime.InteropServices.DllImport("EpsonFiscalInterface.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi,
                                                                           CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
            public static extern int PausarLog();


            // ReanudarLog
            [System.Runtime.InteropServices.DllImport("EpsonFiscalInterface.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi,
                                                                           CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
            public static extern int ReanudarLog();

        //Queries

            [System.Runtime.InteropServices.DllImport("EpsonFiscalInterface.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi,
                                                                           CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
            public static extern int ConsultarUltimoError();
            [System.Runtime.InteropServices.DllImport("EpsonFiscalInterface.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi,
                                                                              CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
            public static extern int ConsultarDescripcionDeError(int numero_de_error, StringBuilder respuesta_descripcion, int respuesta_descripcion_largo_maximo);
            [System.Runtime.InteropServices.DllImport("EpsonFiscalInterface.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi,
                                                                               CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
            public static extern int ConsultarEstadoDeConexion();
            [System.Runtime.InteropServices.DllImport("EpsonFiscalInterface.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi,
                                                                                        CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
            public static extern int ConsultarVersionDll(StringBuilder descripcion, int descripcion_largo_maximo, ref int mayor, ref int menor);
            [System.Runtime.InteropServices.DllImport("EpsonFiscalInterface.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi,
                                                                               CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
            public static extern int ConsultarVersionEquipo(StringBuilder descripcion, int descripcion_largo_maximo, ref int mayor, ref int menor);

            [System.Runtime.InteropServices.DllImport("EpsonFiscalInterface.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi,
                                                                               CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]

            public static extern int ConsultarNumeroPuntoDeVenta(StringBuilder respuesta, int respuesta_largo_maximo);
            [System.Runtime.InteropServices.DllImport("EpsonFiscalInterface.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi,
                                                                               CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
            public static extern int ConsultarTipoResponsabilidadAnteElIVA(StringBuilder respuesta, int respuesta_largo_maximo);
            [System.Runtime.InteropServices.DllImport("EpsonFiscalInterface.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi,
                                                                               CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
            public static extern int ConsultarTipoHabilitacion(StringBuilder respuesta, int respuesta_largo_maximo);
            [System.Runtime.InteropServices.DllImport("EpsonFiscalInterface.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi,
                                                                               CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
            public static extern int ConsultarNumeroComprobanteUltimo(string tipo_de_comprobante, StringBuilder respuesta, int respuesta_largo_maximo);
            [System.Runtime.InteropServices.DllImport("EpsonFiscalInterface.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi,
                                                                               CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
            public static extern int ConsultarNumeroComprobanteActual(StringBuilder respuesta, int respuesta_largo_maximo);
            [System.Runtime.InteropServices.DllImport("EpsonFiscalInterface.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi,
                                                                               CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
            public static extern int ConsultarTipoComprobanteActual(StringBuilder respuesta, int respuesta_largo_maximo);
            [System.Runtime.InteropServices.DllImport("EpsonFiscalInterface.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi,
                                                                               CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
            public static extern int ConsultarSubTotalBrutoComprobanteActual(StringBuilder respuesta, int respuesta_largo_maximo);
            [System.Runtime.InteropServices.DllImport("EpsonFiscalInterface.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi,
                                                                               CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
            public static extern int ConsultarSubTotalNetoComprobanteActual(StringBuilder respuesta, int respuesta_largo_maximo);
            [System.Runtime.InteropServices.DllImport("EpsonFiscalInterface.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi,
                                                                               CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
            public static extern int ConsultarEstado(int id_consulta,ref int respuesta);

        /* Set/Get Settings */
        
            [System.Runtime.InteropServices.DllImport("EpsonFiscalInterface.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi,
                                                                           CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
            public static extern int EstablecerEncabezado(int numero_encabezado, string descripcion);
            [System.Runtime.InteropServices.DllImport("EpsonFiscalInterface.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi,
                                                                              CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
            public static extern int ConsultarEncabezado(int numero_encabezado, StringBuilder respuesta, int respuesta_largo_maximo);
            [System.Runtime.InteropServices.DllImport("EpsonFiscalInterface.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi,
                                                                               CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
            public static extern int EstablecerCola(int numero_cola, string descripcion);
            [System.Runtime.InteropServices.DllImport("EpsonFiscalInterface.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi,
                                                                                        CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
            public static extern int ConsultarCola(int numero_cola, StringBuilder respuesta, int respuesta_largo_maximo);
            [System.Runtime.InteropServices.DllImport("EpsonFiscalInterface.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi,
                                                                               CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
            public static extern int EstablecerFechaHora(string fecha_hora);
            [System.Runtime.InteropServices.DllImport("EpsonFiscalInterface.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi,
                                                                               CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
            public static extern int ConsultarFechaHora(StringBuilder respuesta, int respuesta_largo_maximo);
        
        /* Audit/Download */
            
            [System.Runtime.InteropServices.DllImport("EpsonFiscalInterface.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi,
                                                                                   CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
            public static extern int ImprimirAuditoria(int id_modificador, string desde, string hasta);
            [System.Runtime.InteropServices.DllImport("EpsonFiscalInterface.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi,
                                                                              CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
            public static extern int Descargar(string desde, string hasta, string directorio_de_descarga);
            [System.Runtime.InteropServices.DllImport("EpsonFiscalInterface.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi,
                                                                               CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
            public static extern int DescargarPeriodoPendiente(string directorio_de_descarga);
            [System.Runtime.InteropServices.DllImport("EpsonFiscalInterface.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi,
                                                                                        CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
            public static extern int ConfirmarDescarga(string hasta);
            [System.Runtime.InteropServices.DllImport("EpsonFiscalInterface.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi,
                                                                               CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
            public static extern int ConsultarFechaPrimerJornadaPendiente(StringBuilder respuesta_fecha_pendiente, int respuesta_fecha_pendiente_largo_maximo);
            [System.Runtime.InteropServices.DllImport("EpsonFiscalInterface.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi,
                                                                               CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
            public static extern int ConsultarDescargasSinConfirmar(StringBuilder respuesta_fecha, int respuesta_fecha_largo_maximo, StringBuilder respuesta_cierre_z, int respuesta_cierre_z_largo_maximo);
        
        /* Sales */
        
            [System.Runtime.InteropServices.DllImport("EpsonFiscalInterface.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi,
                                                                                       CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
            public static extern int CargarDatosCliente(string nombre_o_razon_social1, string nombre_o_razon_social2,
                                                           string domicilio1, string domicilio2, string domicilio3,
                                                           int id_tipo_documento, string numero_documento, int id_responsabilidad_iva);
            [System.Runtime.InteropServices.DllImport("EpsonFiscalInterface.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi,
                                                                              CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
            public static extern int CargarComprobanteAsociado(string descripcion);
            [System.Runtime.InteropServices.DllImport("EpsonFiscalInterface.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi,
                                                                               CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
            public static extern int AbrirComprobante(int id_tipo_documento);
            [System.Runtime.InteropServices.DllImport("EpsonFiscalInterface.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi,
                                                                                        CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
            public static extern int CargarTextoExtra(string descripcion);
            [System.Runtime.InteropServices.DllImport("EpsonFiscalInterface.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi,
                                                                               CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
            public static extern int ImprimirItem(int id_modificador, string descripcion, string cantidad, string precio, int id_tasa_iva,
                                                     int ii_id, string ii_valor, int id_codigo, string codigo, string codigo_unidad_matrix,
                                                     int codigo_unidad_medida);
            [System.Runtime.InteropServices.DllImport("EpsonFiscalInterface.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi,
                                                                               CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
            public static extern int ImprimirTextoLibre(string descripcion);
            [System.Runtime.InteropServices.DllImport("EpsonFiscalInterface.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi,
                                                                                       CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
            public static extern int CargarAjuste(int id_modificador, string descripcion, string monto,
                                                     int id_tasa_iva, string codigo_interno);
            [System.Runtime.InteropServices.DllImport("EpsonFiscalInterface.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi,
                                                                              CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
            public static extern int CargarOtrosTributos(int codigo_otros_tributos, string descripcion, string monto, int id_tasa_iva);
            [System.Runtime.InteropServices.DllImport("EpsonFiscalInterface.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi,
                                                                               CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
            public static extern int CargarPago(int id_modificador, int codigo_forma_pago, int cantidad_cuotas, string monto,
                                                   string descripcion_de_cupones, string descripcion,
                                                   string descripcion_extra1, string descripcion_extra2);
            [System.Runtime.InteropServices.DllImport("EpsonFiscalInterface.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi,
                                                                                        CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
            public static extern int ImprimirSubTotal();
            [System.Runtime.InteropServices.DllImport("EpsonFiscalInterface.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi,
                                                                               CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
            public static extern int CerrarComprobante();



        /* Journal */
            [System.Runtime.InteropServices.DllImport("EpsonFiscalInterface.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi,
                                                                                       CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
            public static extern int ImprimirCierreX();
            [System.Runtime.InteropServices.DllImport("EpsonFiscalInterface.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi,
                                                                              CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
            public static extern int ImprimirCierreZ();

        /* User logo */

            [System.Runtime.InteropServices.DllImport("EpsonFiscalInterface.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi,
                                                                                       CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
            public static extern int CargarLogo(string nombre_de_archivo);
            [System.Runtime.InteropServices.DllImport("EpsonFiscalInterface.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi,
                                                                              CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
            public static extern int EliminarLogo();

        /* Configuration */
        /*     *** undocumented ***      */
            [System.Runtime.InteropServices.DllImport("EpsonFiscalInterface.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi,
                                                                                       CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
            public static extern int ConfigurarRetardoAlEnviarComando(int milisegundos);
            /*  The value is in miliseconds. */
            /*        -1  is disables.       */
            /*      1000  is one second.     */

        /* Generic (low level extended protocol) */

            [System.Runtime.InteropServices.DllImport("EpsonFiscalInterface.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi,
                                                                                       CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
            public static extern int EnviarComando(string comando);
            [System.Runtime.InteropServices.DllImport("EpsonFiscalInterface.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi,
                                                                              CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
            public static extern int ObtenerRespuesta(StringBuilder buffer_salida, int largo_buffer_salida, ref int largo_final_buffer_salida);
            [System.Runtime.InteropServices.DllImport("EpsonFiscalInterface.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi,
                                                                               CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
            public static extern int ObtenerCodigoRetorno();
            [System.Runtime.InteropServices.DllImport("EpsonFiscalInterface.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi,
                                                                                        CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
            public static extern int ObtenerEstadoFiscal();
            [System.Runtime.InteropServices.DllImport("EpsonFiscalInterface.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi,
                                                                               CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
            public static extern int ObtenerEstadoImpresora();
            [System.Runtime.InteropServices.DllImport("EpsonFiscalInterface.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi,
                                                                               CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
            public static extern int ObtenerCantidadCamposRespuestaExtendida();
            [System.Runtime.InteropServices.DllImport("EpsonFiscalInterface.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi,
                                                                               CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
            public static extern int ObtenerRespuestaExtendida(int numero_campo, String buffer_salida, int largo_buffer_salida, ref int largo_final_buffer_salida);
    }
}
