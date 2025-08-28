using FuncionesLambda;
using System;
using System.Runtime.InteropServices;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Expresión lambda como función");



        //Func<int, int> b = (a) => a * 2;
        //// tipo     nombre   recibe    hace 

        //int resultado = b(4);

        //Console.WriteLine("El resultado es: " + resultado);


        //Func<int, int, int > suma  = (a,b) => a + b;

        //int resultadoSuma = suma(4, 6);

        //Console.WriteLine("El resultado de la suma es: " + resultadoSuma);

        //Func<int, int, int > mayor = (a, b) => 
        //{
        //    if (a > b)
        //    {
        //        return a;
        //    }

        //    else
        //    {
        //        return b;
        //    }

        //};
            
        //int resultadoMayor = mayor(45, 20);

        //Console.WriteLine("El número mayor es: " + resultadoMayor);



        var numeros = new List<int> {8, 5, 9, 34, 2, 26, 8};

        Func<int, bool> ObtenerPares = (num) => num%2 == 0;

        //var pares = numeros.Where(ObtenerPares);
        var pares = numeros.Where((num) => num % 2 == 0);

        Console.WriteLine("Hola"); 



















        //persona pers = new persona();
        //int edad = 18;        
        //edad++;
        //edad++;      
        //GCHandle direc = GCHandle.Alloc(edad, GCHandleType.Pinned);
        //IntPtr pObj = direc.AddrOfPinnedObject();
        //Console.WriteLine("El valor de la variable es: " + edad);              
        //Console.WriteLine($"La dirección de memoria es: {pObj.ToString()}");


        //Console.ReadKey();
    }
}