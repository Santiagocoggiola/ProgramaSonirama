using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Fiscal
{
    public partial class PrinterErr
    {
        public static string EpsonErrores(int error)
        {
            string err = "";
            if (error == 0)
            {
                err = "Sin error o sin inconvenientes detectados";
            }
            else
            {
                if (error > 1 && error < 65535)
                {
                    err = "Errores relacionados con el controlador fiscal";
                }
                else
                {
                    if (error == 16777217)
                    {
                        err = "El puerto se encuentra en uso";
                    }
                    else
                    {
                        if (error == 16777218)
                        {
                            err = "Puerto inválido";
                        }
                        else
                        {
                            if (error == 16777219)
                            {
                                err = "El puerto ya se encuentra abierto";
                            }
                            else
                            {
                                if (error == 16777220)
                                {
                                    err = "El puerto ya se encuentra cerrado";
                                }
                                else
                                {
                                    if (error == 16777221)
                                    {
                                        err = "Error de inicializacion";
                                    }
                                    else
                                    {
                                        if (error == 16777222)
                                        {
                                            err = "Puerto Cerrado";
                                        }
                                        else
                                        {
                                            if (error == 16777223)
                                            {
                                                err = "Longitud Maxima Alcanzada";
                                            }
                                            else
                                            {
                                                if (error == 16777224)
                                                {
                                                    err = "Campo de datos no inválido";
                                                }
                                                else
                                                {
                                                    if (error == 16777225)
                                                    {
                                                        err = "Operación en progreso";
                                                    }
                                                    else
                                                    {
                                                        if (error == 16777226)
                                                        {
                                                            err = " Error de escritura";
                                                        }
                                                        else
                                                        {
                                                            if (error == 16777227)
                                                            {
                                                                err = "Error de tiempo de espera (Timeout).";
                                                            }
                                                            else
                                                            {
                                                                if (error == 16777228)
                                                                {
                                                                    err = "Byte 0x15 recibido (NAK)";
                                                                }
                                                                else
                                                                {
                                                                    if (error == 16777229)
                                                                    {
                                                                        err = "Índice inválido";
                                                                    }
                                                                    else
                                                                    {
                                                                        if (error == 83886081)
                                                                        {
                                                                            err = "Tabla de texto extra llena";
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }

                        }
                    }
                }
            }
            return err;
        }

    }
}
