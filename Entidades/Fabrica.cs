using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class Fabrica
    {
        private int capacidad;
        private List <Vehiculo> vehiculos;

        private Fabrica()
        {
            vehiculos = new List <Vehiculo>();
        }
        public Fabrica(int capacidad)
        {

        }

        public List <Vehiculo> Vehiculos
        {
            get
            {
                return vehiculos;
            }
        }


        public static Fabrica operator +(Fabrica fabrica, Vehiculo vehiculo)
        {
            if (fabrica.Vehiculos.Count < fabrica.capacidad)
            {
                fabrica.Vehiculos.Add(vehiculo);
            }
            return fabrica;
        }

        public static Fabrica operator -(Fabrica fabrica, Vehiculo vehiculo)
        {
            Vehiculo vehiculoARemover = fabrica.Vehiculos.FirstOrDefault(v => v.GetType() == vehiculo.GetType());
            if (vehiculoARemover != null)
            {
                fabrica.Vehiculos.Remove(vehiculoARemover);
            }
            return fabrica;
        }

    }
}
