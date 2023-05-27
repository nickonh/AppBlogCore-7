using AppBlogCore_7.Data;
using BlogCore.Data.Data.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace AppBlogCore_7.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoriasController : Controller
    {
        private readonly IContenedorTrabajo _containerwork;
        private readonly ApplicationDbContext _context;

        public CategoriasController(IContenedorTrabajo containerwork, ApplicationDbContext context)
        {
            _containerwork = containerwork;
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        #region Llamadas a la API
        public IActionResult GetAll() 
        {
            return Json(new {data= _containerwork.RCategoria.GetAll()});
        }

        #endregion
    }
}
