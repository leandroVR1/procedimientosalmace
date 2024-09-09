namespace RepasoPruebaTecnica.Models{

public class Empleado
{
    public int EmpleadoId { get; set; }
    public string Nombre { get; set; }
    public string Correo { get; set; }
    public decimal Salario { get; set; }
    public int DepartamentoId { get; set; }
    public Departamento Departamento { get; set; }
    public List<Asignacion> Asignaciones { get; set; }
}
}