using System;

// Clase abstracta padre
abstract class Animal
{
    // Atributos
    protected string nombre;
    protected int edad;
    protected string tipo;

    // Constructor
    public Animal(string nombre, int edad, string tipo)
    {
        this.nombre = nombre;
        this.edad = edad;
        this.tipo = tipo;
    }

    // Métodos abstractos
    public abstract void EmitirSonido();
    public abstract void Moverse();
    public abstract void MostrarInformacion();
}