// Javier de Mena Asenjo
using System;

namespace PROYECTO
{
    enum Color {
        Marron,
        Blanco,
        Negro,
        Beige
    }
    class Mueble {
        private Color color;
        private readonly float peso;
        private readonly Dimensiones dimensiones;
        private readonly string fabricante;
        private float precio;

        
        public Mueble(Color color, float peso, Dimensiones dim, string fabricante, float precio){
            this.color = color;
            this.peso = peso;
            dimensiones = dim;
            this.fabricante = fabricante;
            this.precio = precio;
        }
        public Mueble(Mueble m){
            color = m.color;
            peso = m.peso;
            dimensiones = m.dimensiones;
            fabricante = m.fabricante;
            precio = m.precio;
        }
    }
    class Silla:Mueble {  
        private readonly int longitudRespaldo;
    }

    class Mesa:Mueble {
        private readonly string tipoMadera;
    }

    class Sofa:Mueble {
        private string tela;
        private readonly bool abatible;
    }
    struct Dimensiones {
        public readonly int ancho;
        public readonly int alto;
        public readonly int largo;

        public Dimensiones(in int ancho, in int alto, in int largo){
            this.ancho = ancho;
            this.alto = alto;
            this.largo = largo;
        }
    }
    
    
    public class Program
    {
        static void Main(string[] args)
        { 
            
        } 
    }
            
}
// Javier de Mena Asenjo