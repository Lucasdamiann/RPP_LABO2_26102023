using System.Text;

namespace Entidades
{
    abstract class Vehiculo
    {
        protected bool esAWD;
        protected Guid numeroDeChasis;
        protected EPropulsion propulsion;

        public Vehiculo()
        {
            Guid numeroDeChasis = Guid.NewGuid();
        }

        protected Vehiculo(EPropulsion propulsion) : base()
        {
            this.propulsion = propulsion;
        }

        protected Vehiculo(EPropulsion propulsion, bool esAWD) : this(propulsion)
        {
            this.esAWD = false;
        }

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
            StringBuilder sb = new StringBuilder();
            return string.Format("{0} con propulsión a {1}, {2} es AWD, numero de chasis {3}", Tipo, Propulsion, esAWD, numeroDeChasis);
        }

        public string ToString()
        {
            return GetInfo();
        }

        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }

        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            if (v1.GetType() == v2.GetType() && v1.numeroDeChasis.ToString() == v2.numeroDeChasis.ToString())
            {
                return true;
            }
            return false;
        }
    }
    enum EPropulsion
    {
        Combustion,
        Hibrida,
        Electrica
    }
}