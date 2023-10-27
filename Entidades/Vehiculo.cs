using System.Text;

namespace Entidades
{
    public abstract class Vehiculo
    {
        protected Vehiculo(EPropulsion propulsion, bool esAWD)
        {

            this.esAWD = esAWD;
            this.propulsion = propulsion;
            this.numeroDeChasis = Guid.NewGuid();
        }
        protected Vehiculo(EPropulsion propulsion) : this(propulsion, false) 
        { 
        }
        

        protected bool esAWD;
        protected Guid numeroDeChasis;
        protected EPropulsion propulsion;

        //propiedades
        public EPropulsion Propulsion
        {
            get
            {
                return this.propulsion;
            }
        }
        protected abstract string Tipo 
        {  
            get;
        }

        protected string GetInfo()
        {
            string esAWDString;
            if (esAWD)
            {
                esAWDString = "SI";
            }
            else
            {
                esAWDString = "NO";
            }
            return string.Format("{0} con propulsion a {1}, {2} es AWD, numero de chasis {3}.",
                Tipo, Propulsion, esAWDString, numeroDeChasis);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"tipo: {Tipo.ToString()}");
            sb.Append($"propulsion: {Propulsion.ToString()}");
            sb.Append($"nro chasis: {this.numeroDeChasis.ToString()}");
            return sb.ToString();
        }

        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            if (v1 is null || v2 is null)
            {
                return false; // Si uno de los objetos es nulo, considerados diferentes
            }
            return (v1.Tipo == v2.Tipo && v1.numeroDeChasis == v2.numeroDeChasis);
        }

        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }



    }
}