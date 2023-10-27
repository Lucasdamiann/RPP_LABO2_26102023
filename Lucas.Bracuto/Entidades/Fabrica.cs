using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class Fabrica
    {
        private int capacidad;
        private List<Vehiculo> vehiculos;

        private Fabrica()
        {
            this.vehiculos = new List<Vehiculo>();
        }

        public Fabrica(int capacidad)
        {
            this.capacidad = capacidad;
        }

        public List<Vehiculo> Vehiculos
        {
            get 
            { 
                return vehiculos; 
            }
        }

        public static Fabrica operator -(Fabrica fabrica, Vehiculo vehiculo)
        {
            foreach (Vehiculo nave in fabrica.Vehiculos)
            {
                if (vehiculo == nave)
                {
                    fabrica.Vehiculos.Remove(nave);
                }
            }
                return fabrica;
        }

        public static Fabrica operator +(Fabrica fabrica, Vehiculo vehiculo)
        { 
            if (fabrica.capacidad > fabrica.Vehiculos.Count())
            {
                fabrica.vehiculos.Add(vehiculo);
            }
            return fabrica;
        }

    }
}
