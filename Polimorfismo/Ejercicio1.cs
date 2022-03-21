using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace Ejercicio02
{
    public static class Taxi
    {
        const float BAJADA_BANDERA = 1.82F;
        const float CARRERA_MINIMA = 3.63F;
        const float COSTE_KM = 0.9F;
        const float ESPERA_POR_HORA = 18.77F;
        const short PORCENTAJE_NOCTURNO = 30;

        public static float CosteCarrera(float kilometros, float minutosEspera){
            return BAJADA_BANDERA + kilometros*COSTE_KM + minutosEspera*(ESPERA_POR_HORA/60);
        }
        public static float CosteCarrera(float kilometros, float minutosEspera, bool nocturno){
            float costeCarrera = CosteCarrera(kilometros,minutosEspera);
            if(nocturno){
                costeCarrera += costeCarrera/PORCENTAJE_NOCTURNO;
            }
            return costeCarrera;
        }
        public static float CosteCarrera(float kilometros, float minutosEspera, bool nocturno,int festivo){
            float costeCarrera = CosteCarrera(kilometros,minutosEspera);
            float costeCarreraNoc = CosteCarrera(kilometros,minutosEspera,nocturno);

            float incrementoFestivo = costeCarrera * festivo/100;
            float costeCarreraFest = costeCarrera + incrementoFestivo;

            costeCarrera = costeCarreraFest > costeCarreraNoc ? costeCarreraFest : costeCarreraNoc;

            return costeCarrera;
        }

        public static float CosteCarrera(float kilometros, float minutosEspera, bool nocturno,int festivo, int ocupacion){
            float costeCarrera = CosteCarrera(kilometros,minutosEspera,nocturno,festivo);
            costeCarrera += ocupacion;
            return costeCarrera;
        }
        
    }
    class Program
    {
        static void Main()
        {
            Console.WriteLine($"Coste carrera lunes mañana -> "
                            + $"{Taxi.CosteCarrera(20, 5):f2}");
            Console.WriteLine($"Coste carrera lunes noche -> "
                            + $"{Taxi.CosteCarrera(20, 5, true):f2}");
            Console.WriteLine($"Coste carrera lunes con mi mascota Dogo -> "
                            + $"{Taxi.CosteCarrera(20, 5, false, 0, 1):f2}");
            Console.WriteLine($"Coste carrera Domingo de Ramos -> "
                            + $"{Taxi.CosteCarrera(20, 5, false, 40):f2}");
            Console.WriteLine($"Coste carrera Domingo noche -> "
                            + $"{Taxi.CosteCarrera(20, 5, true, 20):f2}");
            Console.WriteLine($"Coste carrera Domingo de Ramos noche con Dogo y Minina -> "
                            + $"{Taxi.CosteCarrera(20, 5, true, 40, 2):f2}");
            Console.ReadKey();
        }
    }
}