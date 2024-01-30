public abstract class MiembroDeLaComunidad
{
    public string Nombre { get; set; } = null!;
    public string Sexo { get; set; } = null!;
    public abstract void EjecutarTarea();
}