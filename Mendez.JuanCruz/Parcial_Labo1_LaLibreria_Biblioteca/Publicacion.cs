using System;
using System.Text;

namespace ParcialLibreria
{
    public abstract class Publicacion
    {
        protected Single importe;
        protected String nombre;
        protected Int32 stock;

        public Publicacion(String nombre)
        {
            this.nombre = nombre;
            this.importe = 0;
            this.stock = 0;
        }

        public Publicacion(String nombre , Int32 stock) : this(nombre)
        {
            this.Stock = stock;
        }

        public Publicacion(String nombre , Int32 stock , Single importe) :this(nombre , stock)
        {
            this.importe = importe;
        }

        protected abstract bool EsColor { get; }

        public virtual bool HayStock
        {
            get 
            {
                if(this.stock > 0 && this.importe > 0)
                {
                    return true;
                }

                return false;
            }
        }

        public Single Importe
        {
            get { return this.importe; }
        }

        public Int32 Stock
        {
            get { return this.stock; }
            set
            {
                if(value >= 0) //si o si tenia que ponerle >= 0, sino al ir vendiendo y restando siempre me queda seteado en 1
                {               //y nunca deja agotar el stock...
                    this.stock = value;
                }
            }
        }

        public override string ToString()
        {
            return this.nombre;
        }

        public String ObtenerInformacion()
        {
            StringBuilder str = new StringBuilder();

            String valorColor = this.EsColor == true ? "SI" : "NO";

            str.AppendLine($"Nombre: {this.nombre}");
            str.Append($"Stock: {this.Stock}\n");
            str.AppendFormat("Es color: {0}\n", valorColor);
            str.AppendLine($"Valor: {this.Importe}");

            return str.ToString();
        }

    }
}
