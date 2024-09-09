namespace RepasoPruebaTecnica.Models{
public class Asignacion
{
    public int AsignacionId { get; set; }
    public int EmpleadoId { get; set; }
    public Empleado Empleado { get; set; }
    public int ProyectoId { get; set; }
    public Proyecto Proyecto { get; set; }
}
}