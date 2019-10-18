namespace PdnMvc.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class HelloWorldController : Controller
    {
        // GET: /HelloWorld/
        public string Index()
        {
            return "Default 'Hello'.";
        }

        // GET: /HelloWorld/Welcome/ 
        public string Welcome()
        {
            return "Hello and welcome!";
        }
    }
}