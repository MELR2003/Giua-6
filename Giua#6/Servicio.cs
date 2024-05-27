using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giua_6
{
    public abstract class Servicio
    {
        public abstract void RealizarServicio();
        public abstract double CalcularCosto();

        //PARTE DE INDEPENDIENTE
        public virtual double CalcularTiempoServicio()
        {
            return 0.5;
        }
        
    }
}
