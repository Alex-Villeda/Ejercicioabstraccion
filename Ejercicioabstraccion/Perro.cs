// Clase hija 1
class Perro : Animal
{
    // Atributos adicionales
    private string raza;

    // Constructor
    public Perro(string nombre, int edad, string raza) : base(nombre, edad, "Perro")
    {
        this.raza = raza;
    }

    // Implementación de métodos abstractos
    public override void EmitirSonido()
    {
        Console.WriteLine("Guau Guau");
    }

    public override void Moverse()
    {
        Console.WriteLine("Corriendo");
    }

    public override void MostrarInformacion()
    {
        Console.WriteLine($"Nombre: {nombre}");
        Console.WriteLine($"Edad: {edad} años");
        Console.WriteLine($"Tipo: {tipo}");
        Console.WriteLine($"Raza: {raza}");
        Console.WriteLine();
    }
}