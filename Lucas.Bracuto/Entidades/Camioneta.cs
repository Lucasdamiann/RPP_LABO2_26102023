using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class Camioneta : Vehiculo
    {
        private bool cabinaSimple;

        public Camioneta(EPropulsion propulsion, bool cabinaSimple) : base(propulsion, true)
        {
            this.cabinaSimple = cabinaSimple;
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
            sb.Append(GetInfo());
            sb.Append(string.Format(", con cabina: Simple{0} o Doble {1}", cabinaSimple, !cabinaSimple));
            return sb.ToString();
        }
    }
}
