// Clase compuesta para grupos de empleados (departamentos y divisiones)
public class GrupoEmpleado : ComponenteEmpleado
{
    private List<ComponenteEmpleado> empleados = new List<ComponenteEmpleado>();

    public GrupoEmpleado(string nombre)
    {
        Nombre = nombre;
    }

    public void AgregarEmpleado(ComponenteEmpleado empleado)
    {
        empleados.Add(empleado);
    }

    public void QuitarEmpleado(ComponenteEmpleado empleado)
    {
        empleados.Remove(empleado);
    }

    public override void Mostrar()
    {
        Console.WriteLine($"Grupo: {Nombre}");
        foreach (var empleado in empleados)
        {
            empleado.Mostrar();
        }
    }
}
