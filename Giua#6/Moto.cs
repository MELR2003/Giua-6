using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giua_6
{
    public class Moto : Vehiculo
    {
        public override void RealizarMantenimiento()
        {
            Console.WriteLine("Realizar mantenimiento de la moto: Lubricacion de cadena y revision de neumaticos");
        }
        public override double ObtenerCostoMantenimiento()
        {
            return 100.0;
        }
        //PARTE DE INDEPENDIENTE 
        public override double CalcularTiempoServicio()
        {
            return 1.5;
        }
    }
}
