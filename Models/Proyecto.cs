namespace RepasoPruebaTecnica.Models{
public class Proyecto
{
    public int ProyectoId { get; set; }
    public string Nombre { get; set; }
    public List<Asignacion> Asignaciones { get; set; }
}
}