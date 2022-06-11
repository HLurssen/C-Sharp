using Microsoft.AspNetCore.Mvc; // Service that brings in our MVC functionality 
namespace DojoSurvey.Controllers;     //be sure to use your own project's namespace!
public class HelloController : Controller   //remember inheritance??
{

    //for each route this controller is to handle:
    [HttpGet]       //type of request
    [Route("")]     //associated route string (exclude the leading /)
    public ViewResult Index(string Name)
    {
        ViewBag.Name = Name;
        return View();
    }


    [HttpPost("process")]
    public IActionResult Process(string Name, string Location, string Language, string Comment)
    {
        Console.WriteLine($"Name : {Name}");
        Console.WriteLine($"Location : {Location}");
        Console.WriteLine($"Language : {Language}");
        Console.WriteLine($"Comment : {Comment}");
        ViewBag.Name = Name;
        ViewBag.Location = Location;
        ViewBag.Language = Language;
        ViewBag.Comment = Comment;
        return View ("Success");
    }

    [HttpGet("success")]
    public ViewResult Success()
    {
        return View();
    }
}


