using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;
using Portafolio.Servicios;
using System.Diagnostics;

namespace Portafolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        //Agrego el repositorio como campo
        private readonly RepositorioProyecto repositorioProyectos;

        public HomeController(ILogger<HomeController> logger, RepositorioProyecto repositorioProyectos)
        {
            _logger = logger;
            this.repositorioProyectos = repositorioProyectos;
        }

        public IActionResult Index()
        {
           
            var proyectos = repositorioProyectos.ObtenerProyectos().Take(3).ToList();
            var modelo = new HomeIndexViewModel() { Projectos = proyectos };
            return View(modelo);
        }

        

        
    

      public IActionResult Proyecto ()
        {
            var proyectos = repositorioProyectos.ObtenerProyectos();

            return View(proyectos);
        }

        [HttpGet]
        public IActionResult Contacto()
        {
            
            return View();
            
        }

      
        //Creo la accion de HTTPPost para poder enviar un Email
        [HttpPost] //realiza la accion 
        public IActionResult Contacto(ContactoVM contactoVM)
        {
            //se puede restornar una vista pero hay q controlar el post para que el mensaje no se envie muchas veces
            //en caso de un compra se puede realizar muchas veces la compra solo con refrescar la pagina
            return RedirectToAction("Gracias");
           
        }

        public IActionResult Gracias()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
