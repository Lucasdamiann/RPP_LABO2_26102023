using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class Automovil : Vehiculo
    {
        public Automovil()
        {
            base.propulsion = EPropulsion.Hibrida;
        }
        protected override string Tipo
        {
            get               
            {
                return "Automovil";
            }
        }
    }
}
