// Javier de Mena Asenjo
using System;
using Microsoft.VisualBasic;
using System.Text.RegularExpressions;

namespace PROYECTO
{
    enum tipoArma {
        Espada, Trabuco, Escopeta, Lanza, Arco
    }
    enum tipoArmadura { 
        Tela, Cuero, Hierro, Oro
    }
    enum tipoLibroHechizos {
        MagiaNegra, MagiaBlanca, Agua, Viento, Fuego
    }
    enum tipoTunica {
        Larga, Corta, LargaCapucha, CortaCapucha
    }
    class Humano {
        private string nombre;
        private int edad;
        private int peso;
        private readonly string sexo;
        private readonly int inteligencia;
        private readonly int fuerza;
        private readonly int destreza;
        private readonly int energia;
        public Humano(in string nombre, in int edad, in string sexo){
            Random rnd = new Random();
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = sexo;
            this.inteligencia = rnd.Next(0,11);
            this.fuerza = rnd.Next(0,11);
            this.destreza = rnd.Next(0,11);
            this.energia = rnd.Next(0,11);
        }
        public Humano(Humano h){
            Random rnd = new Random();
            this.nombre = h.nombre;
            this.edad = h.edad;
            this.sexo = h.sexo;
            this.inteligencia = rnd.Next(0,11);
            this.fuerza = rnd.Next(0,11);
            this.destreza = rnd.Next(0,11);
            this.energia = rnd.Next(0,11);
        }
        public void SetNombre(in string nombre){
            this.nombre = nombre;
        }
        public void SetEdad(in int edad){
            this.edad = edad;
        }
        public void MostrarInformacion(){

        }
    }
    class Guerrero:Humano {
        private tipoArma tipoArma;
        private tipoArmadura tipoArmadura;
        public Guerrero(in tipoArma tipoArma, in tipoArmadura tipoArmadura, in string nombre, in int edad, in string sexo):base(nombre,edad,sexo){
            this.tipoArma = tipoArma;
            this.tipoArmadura = tipoArmadura;
        }
        public Guerrero(in tipoArma tipoArma, in tipoArmadura tipoArmadura, Humano h):base(h){
            this.tipoArma = tipoArma;
            this.tipoArmadura = tipoArmadura;
        }
    }
    class Mago:Humano {
        private tipoLibroHechizos tipoLibroHechizos;
        private tipoTunica tipoTunica;
        public Mago(in tipoLibroHechizos tipoLibroHechizos, in tipoTunica tipoTunica, in string nombre, in int edad, in string sexo):base(nombre,edad,sexo){
            this.tipoLibroHechizos = tipoLibroHechizos;
            this.tipoTunica = tipoTunica;
        }
        public Mago(in tipoLibroHechizos tipoLibroHechizos, in tipoTunica tipoTunica, Humano h):base(h){
            this.tipoLibroHechizos = tipoLibroHechizos;
            this.tipoTunica = tipoTunica;
        }
    }
    class Program
    {
        static void Main(string[] args)
        { 
            Console.ReadKey();
        }
        
    }
            
}
// Javier de Mena Asenjo