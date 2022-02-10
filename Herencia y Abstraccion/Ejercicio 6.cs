// Javier de Mena Asenjo
using System;
// using System.Text.RegularExpressions;

namespace PROYECTO
{
    abstract class TablaEnteros {
        private int[] enteros;
        public TablaEnteros(int n){
            this.enteros = new int[n];
        }
        public virtual string DevuelveTabla(){

            return "";
        }

        public int SumaPropia(){

            return 0;
        }
        public abstract void GuardarNumerosenTabla();
    }
    class TablaImpares:TablaEnteros {
        TablaImpares(in int n):base(n){}
        override public void GuardarNumerosenTabla(){

        }
    }

    class TablaPares:TablaEnteros {
        TablaPares(in int n):base(n){}
        override public void GuardarNumerosenTabla(){
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        { 

        }
        
    }
            
}
// Javier de Mena Asenjo