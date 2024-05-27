using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giua_6
{
    public class Coche : Vehiculo
    {
        public override void RealizarMantenimiento()
        {
            Console.WriteLine("Realizar mantenimiento del coche: Cambio de aceite y revision de frenos");
        }
        public override double ObtenerCostoMantenimiento()
        {
            return 150.0;
        }
        public new void Lavar()
        {
            Console.WriteLine("Lavando el coche con cera y shampoo especial.");
        }
        //PARTE DE INDEPENDIENTE 
        public override double CalcularTiempoServicio()
        {
            return 2.0;
        }

    }
}
