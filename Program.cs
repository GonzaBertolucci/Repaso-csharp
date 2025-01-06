namespace PracticaPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circulo miCirculo = new Circulo(); //Creacion de objeto de tipo ciruclo. Iniciacion de variable/objeto.

            Console.WriteLine(miCirculo.calculoArea(5));

            Circulo miCirculo2 = new Circulo();

            Console.WriteLine(miCirculo2.calculoArea(9));

        }
    }
}


class Circulo
{

    private const double pi = 3.1416; //Propiedad de la clase circulo

    public double calculoArea(int radio) //Metodo de clase.
    {
        return pi * radio * radio;
    }
}
