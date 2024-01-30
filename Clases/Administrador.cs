public class Administrador : Docente
{
    protected override void EjecutarEspecialidad()
    {
    base.EjecutarTarea();
    Console.WriteLine("Administrando el ITLA...");
    }
}