﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giua_6
{
    public class ReparacionFrenos : Servicio
    {
        public override void RealizarServicio()
        {
            Console.WriteLine("Realizando reparacion de frenos.");
        }
        public override double CalcularCosto()
        {
            return 100.0;
        }
    }
}
