internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("Complejidad de algoritmos\n");

        //Console.WriteLine("Complejidad Big O(1)");

        //var nombres = new List<string> { "Ileny", "Alondra", "Jose", "Juan", "Alejrando" };

        //var primero = (List<string> arreglo ) => arreglo != null && arreglo.Count>0 ?
        //                arreglo[0] : "lista vacía";

        //Console.WriteLine(primero(nombres));


        //Console.ReadKey();

        Console.WriteLine("Complejidad de algoritmos\n");

        Console.WriteLine("Complejidad Big O(n)");
        
        var numeros = new List<int> { 45,22,53,500,2000,10000,0,1};

        var numeromayor = (List<int> arreglo) =>
        {
            if (arreglo == null || arreglo.Count == 0)
            {
                return 0;
            }
            else
            {
                int mayor = arreglo[0];
                for(int i = 0; i < arreglo.Count; i++)
                {
                    if(arreglo[i] > mayor)
                    {
                        mayor = arreglo[i];
                    }
                }
                return mayor;
            }

        };

        int may = numeromayor(numeros);

        Console.WriteLine("El numero mayor es: " + may);
    }
}