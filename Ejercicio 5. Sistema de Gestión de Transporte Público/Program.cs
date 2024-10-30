// See https://aka.ms/new-console-template for more information

using Bond;
using DocumentFormat.OpenXml.Bibliography;
using NHibernate.Mapping;

using System;
using System.Collections.Generic;

// Clase para representar una Ruta
public class Ruta
{
    public int Id { get; set; }
    public string Origen { get; set; }
    public string Destino { get; set; }
    public double Distancia { get; set; }
    public List<string> HorariosSalida { get; set; }
    public List<string> PuntosParada { get; set; }
}

// Clase para representar un Vehículo
public class Vehiculo
{
    public string NumeroPlaca { get; set; }
    public string Modelo { get; set; }
    public int CapacidadPasajeros { get; set; }
    public bool Disponibilidad { get; set; }
}

// Clase para representar un Conductor
public class Conductor
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string LicenciaConducir { get; set; }
    public List<Ruta> RutasAsignadas { get; set; }
}

// Clase para representar un Pasajero
public class Pasajero
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public List<Ruta> RutasCompradas { get; set; }
}

// Clase principal del sistema
public class SistemaTransporte
{
    public List<Ruta> Rutas { get; set; }
    public List<Vehiculo> Vehiculos { get; set; }
    public List<Conductor> Conductores { get; set; }
    public List<Pasajero> Pasajeros { get; set; }

    // Método para agregar una nueva ruta al sistema
    public void AgregarRuta(Ruta nuevaRuta)
    {
        Rutas.Add(nuevaRuta);
    }

    // Método para registrar un nuevo vehículo en el sistema
    public void RegistrarVehiculo(Vehiculo nuevoVehiculo)
    {
        Vehiculos.Add(nuevoVehiculo);
    }

    // Método para registrar un nuevo conductor en el sistema y asignarlo a rutas específicas
    public void RegistrarConductor(Conductor nuevoConductor)
    {
        Conductores.Add(nuevoConductor);
    }

    // Método para que un pasajero compre boletos para rutas disponibles
    public void ComprarBoletos(Pasajero pasajero, List<Ruta> rutasCompradas)
    {
        pasajero.RutasCompradas.AddRange(rutasCompradas);
    }
}