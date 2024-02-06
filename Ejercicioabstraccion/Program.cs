using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    static void Main()
    {
        // Crear instancias de las clases hijas
        Perro miPerro = new Perro("Max", 3, "Labrador");
        Gato miGato = new Gato("Whiskers", 2, true);

        // Llamar a los métodos abstractos
        miPerro.EmitirSonido();
        miPerro.Moverse();
        miGato.EmitirSonido();
        miGato.Moverse();

        // Mostrar información en la consola
        miPerro.MostrarInformacion();
        miGato.MostrarInformacion();
    }
}