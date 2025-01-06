namespace Constructores_ejemplo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Coche coche1 = new Coche(); //Crear objeto de tipo coche.
            //Dar un estado inicial a nuestro coche.

            Coche coche2 = new Coche();

            Console.WriteLine(coche1.getInfoCoche());
            //Instanciacion de objeto coche con valores por constructor.
            //Diferente estado inicial
            Coche coche3 = new Coche(1500.8, 0.500);

            Console.WriteLine(coche3.getInfoCoche());

            
        }
    }

    class Coche
    {
        //Constructor, sirve para dar un estado inicial
        public Coche()
        {
            ruedas = 4;
            largo = 2300.5;
            ancho = 0.800;
        }
        //Sobrecarga de constructor
        public Coche(double largoCoche, double anchoCoche)
        {
            ruedas = 4;

            largo = largoCoche;

            ancho = anchoCoche;
        }


        //Getter
        public String getInfoCoche()
        {
            return "Informacion del coche \n" + "Ruedas: " + ruedas + "\nLargo: " + largo+ "\nAncho: " + ancho;
        }

        private int ruedas;

        private double largo;

        private double ancho;

        private bool climatizador;

        private String tapiceria;
    }
}
