// Clase hija 2
class Gato : Animal
{
    // Atributos adicionales
    private bool esDomestico;

    // Constructor
    public Gato(string nombre, int edad, bool esDomestico) : base(nombre, edad, "Gato")
    {
        this.esDomestico = esDomestico;
    }

    // Implementación de métodos abstractos
    public override void EmitirSonido()
    {
        Console.WriteLine("Miau Miau");
    }

    public override void Moverse()
    {
        Console.WriteLine("Saltando");
    }

    public override void MostrarInformacion()
    {
        Console.WriteLine($"Nombre: {nombre}");
        Console.WriteLine($"Edad: {edad} años");
        Console.WriteLine($"Tipo: {tipo}");
        Console.WriteLine($"Es Domestico: {esDomestico}");
        Console.WriteLine();
    }
}
