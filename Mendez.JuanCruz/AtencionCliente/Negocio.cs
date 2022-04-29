using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtencionCliente
{
    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private String nombre;

        private Negocio()
        {
            this.clientes = new Queue<Cliente>();
            this.caja = new PuestoAtencion(Puesto.Caja1);
        }

        public Negocio(String nombre) : this()
        {
            this.nombre = nombre;
        }

        public Cliente Cliente
        {
            get { return this.clientes.Dequeue(); } //dequeue devuelve y quita del listado el elemento..
            set { bool ret = this + value; }
        }

        public Int32 ClientesPendientes
        {
            get { return this.clientes.Count; }
        }

        public static bool operator +(Negocio neg, Cliente cl)
        {
            bool ret = false;

            if (!(neg is null) && !(cl is null))
            {
                if(neg != cl)
                {
                    neg.clientes.Enqueue(cl);
                    ret = true;
                }
            }
            return ret;
        }

        public static bool operator ==(Negocio neg, Cliente cl)
        {
            bool ret = true;

            if (!(neg is null) && !(cl is null))
            {
                ret = false;
                foreach (Cliente cli in neg.clientes)
                {
                    if (cli == cl)
                    {
                        ret = true;
                        break;
                    }
                }
            }
            return ret;
        }

        public static bool operator !=(Negocio neg, Cliente cl)
        {
            return !(neg == cl);
        }

        public static bool operator ~(Negocio neg)
        {
            bool ret = false;

            if(!(neg is null) && neg.ClientesPendientes > 0)
            {
                ret = neg.caja.AtenderCliente(neg.Cliente); //invoco a la caja que esta siendo usada en el neg
            }                                               //de esa caja llamo al metodo atender y atiendo al proximo
                                                            //cliente de la lista que me devuelve la prop Cliente de neg.
            return ret;
        }
    }
}
