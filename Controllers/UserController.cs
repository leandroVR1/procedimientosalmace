using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RepasoPruebaTecnica.Models;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using System.Data;
namespace RepasoPruebaTecnica.Controllers
{
[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    private readonly IConfiguration _configuration;
    
    public UsersController(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    [HttpGet]
    public async Task<IActionResult> GetUsers()
    {
        using (var connection = new MySqlConnection(_configuration.GetConnectionString("MySqlConnection")))
        {
            var users = await connection.QueryAsync<User>("GetUsers", commandType: CommandType.StoredProcedure);
            return Ok(users);
        }
    }

    [HttpPost]
    public async Task<IActionResult> CreateUser([FromBody] User user)
    {
        using (var connection = new MySqlConnection(_configuration.GetConnectionString("MySqlConnection")))
        {
            var parameters = new DynamicParameters();
            parameters.Add("Name", user.Name);
            parameters.Add("Email", user.Email);
            await connection.ExecuteAsync("InsertUser", parameters, commandType: CommandType.StoredProcedure);
            return Ok();
        }
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateUser(int id, [FromBody] User user)
    {
        using (var connection = new MySqlConnection(_configuration.GetConnectionString("MySqlConnection")))
        {
            var parameters = new DynamicParameters();
            parameters.Add("Id", id);
            parameters.Add("Name", user.Name);
            parameters.Add("Email", user.Email);
            await connection.ExecuteAsync("UpdateUser", parameters, commandType: CommandType.StoredProcedure);
            return Ok();
        }
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteUser(int id)
    {
        using (var connection = new MySqlConnection(_configuration.GetConnectionString("MySqlConnection")))
        {
            var parameters = new DynamicParameters();
            parameters.Add("Id", id);
            await connection.ExecuteAsync("DeleteUser", parameters, commandType: CommandType.StoredProcedure);
            return Ok();
        }
    }
}
}