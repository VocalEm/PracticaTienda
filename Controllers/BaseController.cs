using Data;
using Microsoft.AspNetCore.Mvc;

namespace PracticaTienda.Controllers
{
    public class BaseController : Controller
    {
      public readonly ApplicationDbContext _context;    
      public BaseController(ApplicationDbContext context)
      {
        _context = context; 
      } //CON ESTAS LINEAS DE CODIGO HACEMOS QUE NUESTRO CONTROLADOR PUEDA ACCEDRE A NUESTRO CONETXTO OSEA A LA BASE DE DATOS
    }
}