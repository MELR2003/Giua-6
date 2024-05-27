using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giua_6
{
    public class Vehiculo
    {
        public virtual void RealizarMantenimiento()
        {
            Console.WriteLine("Realizar mantenimiento general del vehiculo.");
        } 
        public virtual double ObtenerCostoMantenimiento()
        {
            return 50.0;
        }

        public void Lavar()
        {
            Console.WriteLine("Lavando el vehiculo.");
        }
     //PARTE DE INDEPENDIENTE 
        public virtual double CalcularTiempoServicio()
        {
            return 1.0;
        }
    }

}
