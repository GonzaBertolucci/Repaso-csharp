﻿namespace ConceptosPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Llamada de funcion
            realizarTarea();
        }

        static void realizarTarea()
        {
            //Instanciacion del objeto punto
            Punto origen = new Punto();
            Punto destino = new Punto(150,90);
        }
    }
}