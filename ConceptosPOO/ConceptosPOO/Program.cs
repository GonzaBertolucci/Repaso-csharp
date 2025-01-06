namespace ConceptosPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Llamada de funcion
            //realizarTarea();

            //Clase anonima. Ejemplos
            var miVariable = new { Nombre = "Gonzalo", Edad = 24 };

            Console.WriteLine(miVariable.Nombre + " " + miVariable.Edad);
            //Dos objetos que pertenecen a la misma clase. Porque en funcion de la cantidad de campos, de cada tipo y orden
            //Determina si se trata de la misma clase o no
            //https://learn.microsoft.com/es-es/dotnet/csharp/fundamentals/types/anonymous-types
            var miOtraVariable = new { Nombre = "Ana", Edad = 25 };

            miVariable = miOtraVariable;
        }

        static void realizarTarea()
        {
            //Instanciacion del objeto punto
            Punto origen = new Punto();
            Punto destino = new Punto(150,90);

            double distancia = origen.DistanciaHasta(destino);

            Console.WriteLine($"La distancia entre los puntos es de: {distancia}");

            Console.WriteLine($"Numero de objetos creados: {Punto.ContadorDeObjetos()}");

            
        }
    }
}
