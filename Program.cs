namespace PracticaPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circulo miCirculo = new Circulo(); //Creacion de objeto de tipo ciruclo. Iniciacion de variable/objeto.

            Console.WriteLine(miCirculo.CalculoArea(5));

            Circulo miCirculo2 = new Circulo();

            Console.WriteLine(miCirculo2.CalculoArea(9));

            conversorDolarPesos obj = new conversorDolarPesos();

            obj.cambiarValorDolar(1080);

            Console.WriteLine(obj.convierte(50));
            Console.ReadLine();
        }
    }
}


class Circulo
{

    private const double pi = 3.1416; //Propiedad de la clase circulo

    public double CalculoArea(int radio) //Metodo de clase.
    {
        return pi * radio * radio;
    }
}

class conversorDolarPesos
{
    //Propiedad encapsulada.
    private double dolar = 1015;

    public double convierte(double cantidad)
    {
        return dolar * cantidad;
    }
    //Si necesito cambiar el valor de un dato encapsulado lo mejor seria hacer esto.
    public void cambiarValorDolar(double nuevoValor)
    {
        if(nuevoValor > 0)
        {
            dolar = nuevoValor;
        }
        else
        {
            Console.WriteLine("Error. Debe introducir un numero positivo");
        }
        
    }
}