// Javier de Mena Asenjo
using System;
// using System.Text.RegularExpressions;

namespace PROYECTO
{
    
    abstract class Humano {
        private string nombre;
        private int edad;
        private int peso;
        private readonly string sexo;
        private int inteligencia;
        private int fuerza;
        private int destreza;
        private int energia;
        public Humano(in string nombre, in int edad, in string sexo, in int peso){
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = sexo;
            this.peso = peso;
            GeneraStats();
        }
        public Humano(Humano h){
            Random rnd = new Random();
            this.nombre = h.nombre;
            this.edad = h.edad;
            this.sexo = h.sexo;
            this.peso = h.peso;
            GeneraStats();
            
        }
        public void GeneraStats(){
            Random rnd = new Random();
            this.inteligencia = rnd.Next(1,11);
            this.fuerza = rnd.Next(1,11);
            this.destreza = rnd.Next(1,11);
            this.energia = rnd.Next(1,11);
        }
        public void SetNombre(in string nombre){
            this.nombre = nombre;
        }
        public void SetEdad(in int edad){
            this.edad = edad;
        }
        override public string ToString(){
            string str = "";
            str += " NOMBRE: "+nombre+"\n";
            str += " EDAD: "+edad+"\n";
            str += " SEXO: "+sexo+"\n";
            str += " ESTADISTICAS \n";
            str += "          Inteligencia: "+inteligencia+" | Fuerza: "+fuerza+"\n";
            str += "          Destreza: "+destreza+" | Energia: "+energia+"\n";
            return str;
        }
    }
    class Guerrero:Humano {
        public enum Arma {
            Espada, Trabuco, Escopeta, Lanza, Arco
        }
        public enum Armadura { 
            Tela, Cuero, Hierro, Oro
        }
        private Arma tipoArma;
        private Armadura tipoArmadura;
        public Guerrero(in Arma tipoArma, in Armadura tipoArmadura, in string nombre, in int edad, in string sexo, in int peso):base(nombre,edad,sexo,peso){
            this.tipoArma = tipoArma;
            this.tipoArmadura = tipoArmadura;
        }
        public Guerrero(in Arma tipoArma, in Armadura tipoArmadura, Humano h):base(h){
            this.tipoArma = tipoArma;
            this.tipoArmadura = tipoArmadura;
        }
        public override string ToString()
        {
            string str = "";
            str +=  "+---------------------------------------------+\n";
            str +=  " [ GUERRERO ]                                 |\n";
            str +=  "+---------------------------------------------+\n";
            str +=  base.ToString();
            str += " ARMA: " + tipoArma + "\n";
            str += " ARMADURA: " + tipoArmadura + "\n";
            str +=  "+---------------------------------------------+\n";
            return str;
        }
    }
    class Mago:Humano {
        public enum LibroHechizos {
            MagiaNegra, MagiaBlanca, Agua, Viento, Fuego, Tierra
        }
        public enum Tunica {
            Larga, Corta, LargaConCapucha, CortaConCapucha
        }
        private LibroHechizos tipoLibroHechizos;
        private Tunica tipoTunica;
        public Mago(in LibroHechizos tipoLibroHechizos, in Tunica tipoTunica, in string nombre, in int edad, in string sexo, in int peso):base(nombre,edad,sexo,peso){
            this.tipoLibroHechizos = tipoLibroHechizos;
            this.tipoTunica = tipoTunica;
        }
        public Mago(in LibroHechizos tipoLibroHechizos, in Tunica tipoTunica, Humano h):base(h){
            this.tipoLibroHechizos = tipoLibroHechizos;
            this.tipoTunica = tipoTunica;
        }
        public override string ToString()
        {
            string str;
            str =  "+---------------------------------------------+\n";
            str += " [ MAGO ]                                     |\n";
            str += "+---------------------------------------------+\n";
            str +=  base.ToString();
            str += " LIBRO: " + this.tipoLibroHechizos.ToString() + "\n";
            str += " TUNICA: " + this.tipoTunica.ToString() + "\n";
            str += "+---------------------------------------------+\n";
            return str;
        }
    }
    class Program
    {
        static void Main(string[] args)
        { 
            Mago mago1 = new Mago(Mago.LibroHechizos.Fuego,Mago.Tunica.LargaConCapucha,"Merlin",194,"Hombre",51);
            Guerrero guerrero1 = new Guerrero(Guerrero.Arma.Trabuco,Guerrero.Armadura.Oro,"Giovanni",26,"Helicoptero",84);
            Console.WriteLine();
            Console.WriteLine(mago1.ToString());
            Console.WriteLine();
            Console.WriteLine(guerrero1.ToString());
            Console.ReadKey();
        }
        
    }
            
}
// Javier de Mena Asenjo