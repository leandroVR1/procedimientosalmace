using RepasoPruebaTecnica.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore;

public class BaseContext : DbContext{

    public BaseContext(DbContextOptions options) : base(options) { }

    public DbSet<User> Users { get; set; }
    public DbSet<Empleado> Empleados {get; set;}
    public DbSet<Departamento> Departamentos {get; set;}
    public DbSet<Proyecto> Proyectos {get; set;}
    public DbSet<Asignacion> Asignaciones {get; set;}

     public List<User> GetUsers()
    {
        return Users.FromSqlRaw("EXEC GetUsers").ToList();
    }

    // Call stored procedure to insert a new user
    public void InsertUser(string name, string email)
    {
        Database.ExecuteSqlRaw("EXEC InsertUser @p0, @p1", name, email);
    }

    // Call stored procedure to update a user
    public void UpdateUser(int id, string name, string email)
    {
        Database.ExecuteSqlRaw("EXEC UpdateUser @p0, @p1, @p2", id, name, email);
    }

    // Call stored procedure to delete a user
    public void DeleteUser(int id)
    {
        Database.ExecuteSqlRaw("EXEC DeleteUser @p0", id);
    }

}

