class Program
{
    static void Main()
    {
        // Crear un empleado individual
        Console.WriteLine("Ingrese el nombre del primer empleado:");
        string nombreEmp1 = Console.ReadLine();
        ComponenteEmpleado emp1 = new Empleado(nombreEmp1);

        // Crear grupos de empleados
        GrupoEmpleado departamento1 = new GrupoEmpleado("Departamento 1");
        departamento1.AgregarEmpleado(emp1);

        Console.WriteLine("Ingrese el nombre del segundo empleado:");
        string nombreEmp2 = Console.ReadLine();
        ComponenteEmpleado emp2 = new Empleado(nombreEmp2);

        departamento1.AgregarEmpleado(emp2);

        GrupoEmpleado division = new GrupoEmpleado("División");
        division.AgregarEmpleado(departamento1);

        // Mostrar la estructura completa
        division.Mostrar();
    }
}