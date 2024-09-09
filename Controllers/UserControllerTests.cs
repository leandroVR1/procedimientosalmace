/*using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RepasoPruebaTecnica.Models;


namespace RepasoPruebaTecnica.Controllers
{
    [Route("[controller]")]
   public class UserControllerTests
{
    private readonly BaseContext _context;
    private readonly UserController _controller;

    public UserControllerTests()
    {
        _context = new BaseContext(); // Mock context
        _controller = new UserController(_context);
    }

    [Fact]
    public void Index_Returns_ViewResult_With_ListOfUsers()
    {
        // Act
        var result = _controller.Index();

        // Assert
        var viewResult = Assert.IsType<ViewResult>(result);
        var model = Assert.IsAssignableFrom<IEnumerable<User>>(viewResult.Model);
        Assert.NotNull(model);
    }
}

}*/