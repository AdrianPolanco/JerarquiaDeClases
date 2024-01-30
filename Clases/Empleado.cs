public abstract class Empleado: MiembroDeLaComunidad
{
    public override void EjecutarTarea(){
    Console.WriteLine("Trabajando...");
    }
    protected abstract void EjecutarEspecialidad();
}