using Microsoft.AspNetCore.Mvc;


namespace MVCApp2.Controllers;

public class HelloWorldController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Welcome(string name, int numTimes = 1)
    {
        ViewData["Message"] = "Hello " + name;
        ViewData["NumTimes"] = numTimes;
        return View();
    }

    //public string Index()
    //{
    //    Console.WriteLine("Hello World!");
    //    return "this is my default action...";
    //}

    ////get: /HelloWorld/Welcome/
    //public string Welcome(string name, int ID = 1, int numetimes = 1)
    //{
    //    //return "This is the Welcome action method...";
    //    return HtmlEncoder.Default.Encode($"Hello {name}, numtimes is: {numetimes}");
    //}


}
