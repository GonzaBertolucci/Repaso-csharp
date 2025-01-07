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
            Console.WriteLine(coche1.getExtras());
            //Instanciacion de objeto coche con valores por constructor.
            //Diferente estado inicial
            Console.WriteLine("\n");

            Coche coche3 = new Coche(1500.8, 0.500);
            Console.WriteLine(coche3.getInfoCoche());
            coche3.setExtras(true, "cuero");
            Console.WriteLine(coche3.getExtras());
            

        }
    }
    //C# permite dividir mis clases. Se debe colocar "partial" al inicio
    //Ejemplo: partial class Coche
    //luego cerrar las llaves donde quiero dividir la clase
    class Coche
    {
        //Constructor, sirve para dar un estado inicial
        public Coche()
        {
            ruedas = 4;
            largo = 2300.5;
            ancho = 0.800;
            tapiceria = "tela";
        }
        //Sobrecarga de constructor
        public Coche(double largoCoche, double anchoCoche)
        {
            ruedas = 4;

            largo = largoCoche;

            ancho = anchoCoche;

            tapiceria = "tela";
        }


        //Getter
        public String getInfoCoche()
        {
            return "Informacion del coche \n" + "Ruedas: " + ruedas + "\nLargo: " + largo+ "\nAncho: " + ancho;
        }
        //Setter
        public void setExtras(bool climatizador, String tapiceria)
        {
            //Si se genera un problema de ambiguedad y el nombre de mis parametros son iguales a los de mis propiedades
            //Utilizo el 'this' el cual hace referencia a este campo de clase. Donde me encuentro actualmente y no la propiedad.
            this.climatizador = climatizador;

            this.tapiceria = tapiceria; 
        }
        
        public String getExtras()
        {
            return "Extras del coche\n" + "Tapiceria: " + tapiceria + "\nClimatizador: " + climatizador;
        }

        private int ruedas;

        private double largo;

        private double ancho;

        private bool climatizador;

        private String tapiceria;
    }
}
