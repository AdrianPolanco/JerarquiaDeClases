public class Administrativo : Empleado
{
    protected sealed override void EjecutarEspecialidad()
    {
    base.EjecutarTarea();
    Console.WriteLine("Ejerciendo burocracia...");
    }
}