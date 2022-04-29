using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerIntegrador
{
    public class ParaisoFiscal
    {
        private List<CuentaOffShore> _listadoCuentas;
        private eParaisosFiscales _lugar;
        private static Int32 cantidadCuentas;
        private static DateTime fechaInicioActividades;

        static ParaisoFiscal()
        {
            ParaisoFiscal.cantidadCuentas = 0;
            ParaisoFiscal.fechaInicioActividades = DateTime.Now;
        }

        private ParaisoFiscal()
        {
            this._listadoCuentas = new List<CuentaOffShore>();
        }

        private ParaisoFiscal(eParaisosFiscales lugar) :this()
        {
            this._lugar = lugar;
        }

        public String MostrarParaiso()
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine($"Fecha inicio actividades: {ParaisoFiscal.fechaInicioActividades}\nLocacion: {this._lugar}" +
                $"\nCantidad Cuentas: {ParaisoFiscal.cantidadCuentas}\n\n");

            if(this._listadoCuentas.Count > 0)
            {
                foreach (CuentaOffShore cuenta in this._listadoCuentas)
                {
                    str.AppendLine($"{Cliente.RetornarDatos(cuenta.Dueño)}Numero Cuenta: {(Int32)cuenta}\nSaldo: {cuenta.Saldo}\n");
                }
            }
            else
            {
                str.AppendLine("No hay Cuentas ingresadas...");
            }
            return str.ToString();
        }
        
        public static implicit operator ParaisoFiscal(eParaisosFiscales paraiso)
        {
            return new ParaisoFiscal(paraiso);
        }

        public static bool operator ==(ParaisoFiscal paraiso , CuentaOffShore cuenta)
        {
            bool ret = false;
            if(!(paraiso is null) && !(cuenta is null))
            {
                if((paraiso._listadoCuentas.Contains(cuenta)))
                {
                    ret = true;
                }
            }
            return ret;
        }

        public static bool operator !=(ParaisoFiscal paraiso, CuentaOffShore cuenta)
        {
            return !(paraiso == cuenta);
        }

        public static ParaisoFiscal operator +(ParaisoFiscal paraiso , CuentaOffShore cuenta)
        {
            if(!(paraiso is null) && !(cuenta is null))
            {
                if(paraiso != cuenta)
                {
                    paraiso._listadoCuentas.Add(cuenta);
                    ParaisoFiscal.cantidadCuentas++;
                    Console.WriteLine("Cargado.."); //ya se que no se hace, pero nose como chotahacerlo sin modificar el main
                }
                else
                {
                    foreach(CuentaOffShore cuen in paraiso._listadoCuentas)
                    {
                        if(cuen == cuenta)
                        {
                            cuen.Saldo += cuenta.Saldo;
                            Console.WriteLine("Saldo actualizado");
                            break;
                        }
                    }
                }
            }
            return paraiso;
        }

        public static ParaisoFiscal operator -(ParaisoFiscal paraiso, CuentaOffShore cuenta)
        {
            if (!(paraiso is null) && !(cuenta is null))
            {
                if (paraiso == cuenta)
                {
                    paraiso._listadoCuentas.Remove(cuenta);
                    ParaisoFiscal.cantidadCuentas--;
                    Console.WriteLine("Eliminado.."); //ya se que no se hace, pero nose como chotahacerlo sin modificar el main
                }
                else
                {
                    Console.WriteLine("No existe esa cuenta..");
                }
            }
            return paraiso;
        }





    }
}
