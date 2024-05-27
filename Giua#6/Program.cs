using Giua_6;
using System;

internal class Program
{
    static void Main(string[] args)
    {
        Vehiculo miCoche = new Coche();
        miCoche.RealizarMantenimiento();
        Console.WriteLine("Costo de mantenimiento del coche: $" + miCoche.ObtenerCostoMantenimiento());

        Vehiculo miMoto = new Moto();
        miMoto.RealizarMantenimiento();
        Console.WriteLine("Costo de mantenimiento de la moto: $" + miMoto.ObtenerCostoMantenimiento());


        miCoche.Lavar();
        Coche miCocheReal = new Coche();
        miCocheReal.Lavar();


        Servicio servicioAceite = new CambioAceite();
        servicioAceite.RealizarServicio();
        Console.WriteLine("Costo de mantenimiento del coche: $" + servicioAceite.CalcularCosto);

        Servicio servicioFrenos = new ReparacionFrenos();
        servicioFrenos.RealizarServicio();
        Console.WriteLine("Costo de mantenimiento del coche: $" + servicioFrenos.CalcularCosto);


        //INDEPENDIENTE
        Vehiculo miCoche1 = new Coche();
        double tiempoCoche = miCoche.CalcularTiempoServicio();
        Console.WriteLine("Tiempo de servicio para el coche en horas:"+ tiempoCoche);
        
        Vehiculo miMoto1 = new Moto();
        double tiempoMoto = miCoche.CalcularTiempoServicio();
        Console.WriteLine("Tiempo de servicio para la moto en horas:"+ tiempoMoto);
        
        Servicio cambioAceite = new CambioAceite();
        double tiempoCambioAceite = cambioAceite.CalcularTiempoServicio();
        Console.WriteLine("Tiempo para cambio de aceite:"+ tiempoCambioAceite);
        
        Servicio reparacionFrenos = new ReparacionFrenos();
        double tiempoReparacionFrenos = reparacionFrenos.CalcularTiempoServicio();
        Console.WriteLine("Tiempo para reparacion de frenos:"+ tiempoReparacionFrenos);

        double tiempoTotalServicios = tiempoCoche + tiempoReparacionFrenos + tiempoCambioAceite;
        double tiempoTotalServicios1 = tiempoMoto + tiempoReparacionFrenos + tiempoCambioAceite;
        Console.WriteLine("Tiempo total de los servicios para el coche en horas:"+ tiempoTotalServicios );
        Console.WriteLine("Tiempo total de los servicios para la moto en horas:"+ tiempoTotalServicios1 );
    }

}