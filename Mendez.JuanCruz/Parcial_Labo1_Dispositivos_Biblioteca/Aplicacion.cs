using System;
using System.Text;
using System.Collections.Generic;

namespace DispositivosBiblioteca
{
    public abstract class Aplicacion
    {
        protected String nombre;
        protected SistemaOperativo sistemaOperativo;
        protected Int32 tamanioMb;

        public SistemaOperativo SistemaOperativo
        {
            get { return this.sistemaOperativo; }
        }

        public abstract Int32 Tamanio { get; }

        public Aplicacion(String nombre, SistemaOperativo sis, Int32 tam)
        {
            this.nombre = nombre;
            sistemaOperativo = sis;
            tamanioMb = tam;
        }

        public static implicit operator Aplicacion(List<Aplicacion> lista)
        {
            Int32 auxTam = 0;
            Int32 cont = 0;
            Aplicacion retorno = null;

            if (!(lista is null) && lista.Count > 0)
            {
                foreach (Aplicacion app in lista)
                {
                    if (cont == 0 || auxTam < app.Tamanio)
                    {
                        auxTam = app.Tamanio;
                        retorno = app;
                    }
                    cont++;
                }
            }

            return retorno;
        }

        public virtual String ObtenerInformacionApp()
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine($"Nombre App: {this.nombre}\nPeso de la app: {this.Tamanio}\nSistema Operativo: {Enum.GetName(this.SistemaOperativo)}");

            return str.ToString();
        }

        public override string ToString()
        {
            return this.nombre;
        }

        public static bool operator ==(List<Aplicacion> aplicaciones, Aplicacion app)
        {
            bool ret = false;
            if (!(aplicaciones is null) && !(app is null))
            {
                if (aplicaciones.Count > 0)
                {
                    foreach (Aplicacion item in aplicaciones)
                    {
                        if (item.nombre == app.nombre)
                        {
                            ret = true;
                            break;
                        }
                    }
                }
            }
            return ret;
        }

        public static bool operator !=(List<Aplicacion> aplicaciones, Aplicacion app)
        {
            return !(aplicaciones == app);
        }

        public static bool operator +(List<Aplicacion> aplicaciones, Aplicacion app)
        {
            bool ret = false;
            if(!(aplicaciones is null) && !(app is null))
            {
                if(aplicaciones != app)
                {
                    aplicaciones.Add(app);
                    ret = true;                
                }
            }
            return ret;
        }
    }
}
