// Javier de Mena Asenjo
using System;
// using System.Text.RegularExpressions;

namespace PROYECTO
{
    abstract class TablaEnteros {
        protected int[] enteros;
        public TablaEnteros(int n){
            this.enteros = new int[n];
        }
        public virtual string DevuelveTabla(){
            string tabla = "";
            foreach (int n in enteros){
                tabla += n + " ";
            }
            return tabla;
        }

        public int SumaPropia(){
            int devuelve;
            int sumaNegativos = 0; int sumaPositivos = 0;
            int numPositivos = 0; int numNegativos = 0;
            foreach (int n in enteros){
                if(n > 0) {
                    numPositivos++;
                    sumaPositivos += n;
                }
                else if (n < 0){
                    numNegativos++;
                    sumaNegativos += n;
                }
            }
            if(numNegativos > numPositivos) devuelve = sumaNegativos;
            else devuelve = sumaPositivos;
            return devuelve;
        }
        public abstract void GuardarNumerosenTabla(int[] nums);
    }
    class TablaImpares:TablaEnteros {
        private int[] impares;
        public TablaImpares(in int n):base(n){
        }
        override public void GuardarNumerosenTabla(int[] nums){
            int i = 0;
            int cantidad = 0;
            foreach (int n in nums){
                if(n % 2 != 0 && n != 0){
                    cantidad++;
                }
            }
            impares = new int[cantidad];
            foreach (int n in nums){
                if(n % 2 != 0){
                    enteros[i] = n;
                    impares[i] = n;
                    i++;
                }
            }
        }
        public override string DevuelveTabla()
        {
            string tabla = "";
            foreach (int n in impares){
                tabla += n + " ";
            }
            return tabla;
        }
    }

    class TablaPares:TablaEnteros {
        private int[] pares;
        public TablaPares(in int n):base(n){
        }
        override public void GuardarNumerosenTabla(int[] nums){
            int i = 0;
            int cantidad = 0;
            foreach (int n in nums){
                if(n % 2 == 0 && n != 0){
                    cantidad++;
                }
            }
            pares = new int[cantidad];
            foreach (int n in nums){
                if(n % 2 == 0 && n != 0){
                    enteros[nums.Length - cantidad + i] = n;
                    pares[i] = n;
                    i++;
                }
            }
        }
        public override string DevuelveTabla()
        {
            string tabla = "";
            foreach (int n in pares){
                tabla += n + " ";
            }
            return tabla;
        }
    }
    class Program
    {
        static void Main(string[] args)
        { 
            int[] numeros = new int[10];

            TablaPares pares = new TablaPares(10);
            TablaImpares impares = new TablaImpares(10);

            for(int i = 0; i < 10; i++){
                Random rnd = new Random();
                numeros[i] = rnd.Next(-99,100);
            }

            pares.GuardarNumerosenTabla(numeros);
            impares.GuardarNumerosenTabla(numeros);

            Console.Write("\n\n\n");
            Console.WriteLine("  Tabla de pares -> "+pares.DevuelveTabla());
            Console.WriteLine("  Tabla de impares -> "+impares.DevuelveTabla());
            Console.WriteLine("  Suma propia pares = "+pares.SumaPropia());
            Console.WriteLine("  Suma propia impares = "+impares.SumaPropia());

            Console.ReadKey();
        }
        
    }
            
}
// Javier de Mena Asenjo