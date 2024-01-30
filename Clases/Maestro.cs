public class Maestro : Docente
{
    protected override void EjecutarEspecialidad()
    {
        base.EjecutarTarea();
        Console.WriteLine("Dando clases en el ITLA...");
    }
}