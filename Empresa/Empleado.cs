public class Empleado : ComponenteEmpleado
{
    public Empleado(string nombre)
    {
        Nombre = nombre;
    }

    public override void Mostrar()
    {
        Console.WriteLine($"Empleado: {Nombre}");
    }
}