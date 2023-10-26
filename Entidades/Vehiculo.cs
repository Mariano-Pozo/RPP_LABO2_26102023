namespace Entidades
{
    public abstract class Vehiculo
    {
        protected Vehiculo(EPropulsion propulsion)
        {
            
        }
        protected Vehiculo(EPropulsion propulsion, bool esAWD)
        {

        }

        protected bool esAWD;
        protected Guid numeroDeChasis;
        protected EPropulsion propulsion;

        //propiedades
        public EPropulsion Propulsion 
        { 
            get;
        }
        public abstract string Tipo 
        {  
            get;
        }

        protected string GetInfo()
        {
            return "";
        }

        public override string ToString()
        {
            return Tipo; //?
        }

        
    }
}