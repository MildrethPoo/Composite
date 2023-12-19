// Clase abstracta que implementa IEmpleado y contiene métodos comunes
public abstract class ComponenteEmpleado : IEmpleado
{
    public string Nombre { get; set; }

    public abstract void Mostrar();
}