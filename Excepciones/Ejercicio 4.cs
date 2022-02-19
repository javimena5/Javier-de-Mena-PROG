// Javier de Mena Asenjo
using System;
using System.Text.RegularExpressions;
// using System.Text.RegularExpressions;

namespace PROYECTO
{
    class Program   
    {
        class SaldoInsuficienteException : Exception {
            public SaldoInsuficienteException() : base() {}

            public SaldoInsuficienteException(string message) : base(message){} 
        }
        class NumeroCuentaIncorrectoException : Exception {
            public NumeroCuentaIncorrectoException() : base() {}

            public NumeroCuentaIncorrectoException(string message) : base(message){} 
        }

        public class Cuenta {
            
            private string titular;
            private double saldo;

            private NumeroCuenta numeroCuenta;

            public Cuenta(in string numero, in string titular){
                saldo = 0;
                this.titular = titular;
                numeroCuenta = new NumeroCuenta(numero);
            }
            public void Ingreso(in double cantidad){
                saldo += cantidad;
            }

            public void Reintegro(in double cantidad){
                if (cantidad < saldo){
                    saldo -= cantidad;
                }else {
                    throw new SaldoInsuficienteException("ERROR. Saldo insuficiente.");
                }
            }

            public override string ToString(){
                return " Numero de cuenta: " + numeroCuenta.ToString() + "\n Titular: " + titular
                +"\n Saldo: " + saldo + "\n";
            }
        }

        public class NumeroCuenta {
            private string entidad;
            private string sucursal;
            private string dcEntSuc;
            private string dcNumero;
            private string cuenta;
            public NumeroCuenta(in string numero){
                int[] ponderacionesControl = new int[8] {4,8,5,10,9,7,3,6};
                int[] ponderacionesNum = new int[10] {1,2,4,8,5,10,9,7,3,6};
                
                String stringPatron = @"(?<ent>\d{4})\s?(?<suc>\d{4})\s?(?<ctrl>\d{2})\s?(?<num>\d{10})";
                Regex patron = new Regex("^"+stringPatron+"$",RegexOptions.Compiled | RegexOptions.IgnoreCase);
                bool expresionValida = patron.IsMatch(numero);
                if(!expresionValida){
                    throw new NumeroCuentaIncorrectoException("ERROR. Formato del numero de cuenta incorrecto.");
                }
                Group digitosControl = patron.Match(numero).Groups["ctrl"];
                Group digitosEnt = patron.Match(numero).Groups["ent"];
                Group digitosSuc = patron.Match(numero).Groups["suc"];
                Group digitosNum = patron.Match(numero).Groups["num"];

                entidad = digitosEnt.Value;
                sucursal = digitosSuc.Value;
                cuenta = digitosNum.Value;
                dcEntSuc = digitosControl.Value[0].ToString();
                dcNumero = digitosControl.Value[1].ToString();
                
                bool entSucCorrecto = dcCorrecto(dcEntSuc,entidad+sucursal,ponderacionesControl);
                bool numCorrecto = dcCorrecto(dcNumero,cuenta,ponderacionesNum);
                if(!entSucCorrecto){
                    throw new NumeroCuentaIncorrectoException("ERROR. Digito de control (entidad/sucursal) incorrecto.");
                }
                if(!numCorrecto){
                    throw new NumeroCuentaIncorrectoException("ERROR. Digito de control (numero de cuenta) incorrecto.");
                }
                
            }
            private bool dcCorrecto(in string dc, in string digitos, in int[] ponderaciones){ 
                int res = 0;
                bool digitoCorrecto = false;
                for(int i = 0; i<ponderaciones.Length;i++){
                    res = res + int.Parse(digitos[i].ToString()) * ponderaciones[i];
                }
                int dcValue = 11 - (res % 11) ;
                if(dcValue == 10){
                    dcValue = 1;
                }
                if(dcValue == 11){
                    dcValue = 0;
                }

                if(int.Parse(dc) == dcValue){
                    digitoCorrecto = true;
                }
                return digitoCorrecto; 
            }

            public override string ToString(){
                return entidad + " " + sucursal + " " + dcEntSuc + dcNumero + " " + cuenta;
            }
            
        }
        
        static void Main(string[] args)
        {   
            try {
                Cuenta cuenta1 = new Cuenta("2085 0103 92 0300731702","Javier de Mena Asenjo");
                Console.WriteLine(cuenta1.ToString()); // correcto -> se imprime

                Console.WriteLine("Ingreso de 23000");
                cuenta1.Ingreso(23000);
                Console.WriteLine(cuenta1.ToString());
                Console.WriteLine("Reintegro de 250");
                cuenta1.Reintegro(250);
                Console.WriteLine(cuenta1.ToString());
                Console.WriteLine("Reintegro de 250000"); // incorrecto insuficiente saldo
                cuenta1.Reintegro(25000);
                Console.WriteLine(cuenta1.ToString());
            }catch(SaldoInsuficienteException e){
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);
            }catch(NumeroCuentaIncorrectoException e){
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);
            }

            try {
                Cuenta cuenta2 = new Cuenta("0049 0345 51 2710611698","Manuel Gomez Lopez"); // incorrecto digito entSuc
                
            }catch(SaldoInsuficienteException e){
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);
            }catch(NumeroCuentaIncorrectoException e){
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);
            }

            try {
                Cuenta cuenta3 = new Cuenta("2100 0811 72 0200947329","Maria Dolores Saavedra Martinez"); // incorrecto digito numCuenta
                
            }catch(SaldoInsuficienteException e){
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);
            }catch(NumeroCuentaIncorrectoException e){
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);
            }
            
            Console.ReadKey();
        }
        
    }
            
}


// Javier de Mena Asenjo
