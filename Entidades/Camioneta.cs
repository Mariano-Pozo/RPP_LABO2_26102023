using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Camioneta : Vehiculo
    {
        private bool cabinaSimple;
        public Camioneta(EPropulsion propulsion, bool cabinaSimple) :base (propulsion)
        {
            this.cabinaSimple = cabinaSimple;
            base.esAWD = true;
            this.propulsion = propulsion;
        }

        protected override string Tipo 
        {
            get
            {
                return "Camioneta";
            }
        }

        protected string GetInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.GetInfo());
            sb.Append(", con cabina: ");
            if (cabinaSimple)
            {
                sb.Append("Simple (true)");
            }
            else
            {
                sb.Append("Doble (false)");
            }
            return sb.ToString();
        }
    }
}
