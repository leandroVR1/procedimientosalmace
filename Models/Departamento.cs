namespace RepasoPruebaTecnica.Models{

public class Departamento
{
    public int DepartamentoId { get; set; }
    public string Nombre { get; set; }
    public List<Empleado> Empleados { get; set; }
}
}