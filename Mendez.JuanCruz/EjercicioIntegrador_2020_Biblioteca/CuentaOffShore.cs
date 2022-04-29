using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerIntegrador
{
    public class CuentaOffShore
    {
        private Cliente _dueño;
        private Int32 _numeroCuenta;
        private double _saldo;

        public Cliente Dueño
        {
            get { return this._dueño; }
        }

        public double Saldo
        {
            get { return this._saldo; }
            set { this._saldo = value; }
        }

        //dueño cuenta saldo
        public CuentaOffShore(Cliente cliente , Int32 cuenta , double saldo)
        {
            this._dueño = cliente;
            this._numeroCuenta = cuenta;
            this.Saldo = saldo;
        }

        public CuentaOffShore(String nombre, eTipoCliente tipo, Int32 numeroCuenta, Double saldoInicial)
            : this(new Cliente(tipo, nombre), numeroCuenta, saldoInicial)
        {
        }

        public static explicit operator Int32(CuentaOffShore cos)
        {
            return cos._numeroCuenta;
        }

        public static bool operator ==(CuentaOffShore cos1 , CuentaOffShore cos2)
        {
            bool ret = false;
            if(!(cos1 is null) && !(cos2 is null))
            {
                if(cos1._numeroCuenta == cos2._numeroCuenta && cos1._dueño.GetAlias() == cos2._dueño.GetAlias())
                {
                    ret = true;
                }
            }
            return ret;
        }

        public static bool operator !=(CuentaOffShore cos1 , CuentaOffShore cos2)
        {
            return !(cos1 == cos2);
        }

        public override bool Equals(object obj)
        {
            bool ret = false;
            if(obj is CuentaOffShore && (CuentaOffShore)obj == this)
            {
                ret = true;
            }
            return ret;
        }
    }
}
