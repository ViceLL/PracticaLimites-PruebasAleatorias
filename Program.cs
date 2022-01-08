public class Identificacion
{
    static void Limites_EntradaAleatoria(string nombre, string apellido, int edad)
    {
        Console.WriteLine("Porfavor ingrese nombre: ");
        nombre = Console.ReadLine();

        Console.WriteLine("Porfavor ingrese apellido: ");
        apellido = Console.ReadLine();

        Console.WriteLine("Porfavor ingrese edad: ");
        edad = int.Parse(Console.ReadLine());

        while (nombre.Length < 2 || nombre.Length > 64)
        {
            Console.WriteLine("Entrada invalida");
            Console.WriteLine("");
        }

        while (apellido.Length < 2 || apellido.Length > 128)
        {
            Console.WriteLine("Entrada invalida");
            Console.WriteLine("");
        }

        while (edad < 18 || edad > 120)
        {
            Console.WriteLine("Entrada invalida");
            Console.WriteLine("");
        }

        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Apellido: " + apellido);
        Console.WriteLine("Edad: " + edad);
    }


    static void Main(string[] args)
    {
        Console.Write("Nombre, Apellido y Edad :-\n----------------------------\n\n");
        Identificacion.Limites_EntradaAleatoria("Vicente", "Vargas", 20);
        Console.ReadLine();

    }
}
