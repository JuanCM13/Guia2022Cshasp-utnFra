using System;
using System.Text;
namespace EjerIntegrador
{
    public class Cliente
    {
        private String _aliasParaIncognito;
        private String _nombre;
        private eTipoCliente _tipoDeCliente;

        private Cliente()
        {
            this._aliasParaIncognito = "Sin alias";
            this._nombre = "NN";
            this._tipoDeCliente = eTipoCliente.SinTipo;
        }

        public Cliente(eTipoCliente tipo) :this()
        {
            this._tipoDeCliente = tipo;
        }

        public Cliente(eTipoCliente tipo , String nombre) :this(tipo)
        {
            this._nombre = nombre;
        }

        private void CrearAlias()
        {
            Random numRandom = new Random();
            Int32 auxNumAlias = numRandom.Next(1000 , 90000);
            StringBuilder str = new StringBuilder();

            str.Append($"{auxNumAlias}{Enum.GetName(this._tipoDeCliente)}");
            this._aliasParaIncognito = str.ToString();
        }

        public String GetAlias()
        {
            if(this._aliasParaIncognito == "Sin alias")
            {
                this.CrearAlias();
            }

            return this._aliasParaIncognito;
        }

        private String RetornarDatos()
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine($"Tipo Cliente: {Enum.GetName(this._tipoDeCliente)}\nNombre: {this._nombre}\nAlias Incognito: {this.GetAlias()}");

            return str.ToString();
        }

        public static string RetornarDatos(Cliente c)
        {
            return c.RetornarDatos();
        }
    }
}
