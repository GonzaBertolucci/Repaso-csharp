namespace ArraysRepaso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Array implicito

            var datos = new[] { "Gonzalo", "Bertolucci", "Argentina" };

            var valores = new[] {15, 28, 35, 75.4, 30.31 };

            Empleados Ana = new Empleados("Ana", 20);

            //Array de objetos
            Empleados[] arrayEmpleados = new Empleados[2];
            //Crear objeto mientras lo almaceno
            arrayEmpleados[0] = new Empleados("Sara", 37);
            //Almaceno uno ya creado
            arrayEmpleados[1] = Ana;

            //Array de tipos o clases anonimas
            var personas = new[]
            {
                new{Nombre = "Juan", Edad = 19},
                new{Nombre = "Maria", Edad = 20},
                new{Nombre = "Diana", Edad = 35}
            };

            Console.WriteLine(personas[1]);
        }

        class Empleados
        {
            public Empleados(string nombre, int edad)
            {
                this.nombre = nombre;
                this.edad = edad;
            }

            string nombre;
            int edad;
        }

    }
}
