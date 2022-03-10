// Javier de Mena Asenjo
using System;
using System.IO;
using System.Text;

namespace Prueba
{
    class Program
    {
        class Microprocesador {
            private string modelo;
            private int nucleos;
            private float frecuencia;

            public Microprocesador(string modelo, int nucleos, float frecuencia){
                this.modelo = modelo;
                this.nucleos = nucleos;
                this.frecuencia = frecuencia;
            }
            public string ToString() {
                return "Modelo: "+modelo+"\nNucleos: " + nucleos +"\nFrecuencia: "+frecuencia;

            }
            public string ACSV(){
                return modelo+";"+nucleos+";"+frecuencia;
            }
        }
        static void Main(string[] args)
        {
            

        }
    }
}


// Javier de Mena Asenjo
