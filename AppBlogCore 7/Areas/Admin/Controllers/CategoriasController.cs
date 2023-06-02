using AppBlogCore_7.Data;
using BlogCore.Data.Data.Repository.IRepository;
using BlogCore.Models;
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

        [HttpGet]
        public IActionResult Create() 
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Categoria categoria)
        {
            if (ModelState.IsValid) 
            {
                _containerwork.RCategoria.Add(categoria);
                _containerwork.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(categoria); 
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Categoria categoria = new Categoria();
            categoria = _containerwork .RCategoria.Get(id);
            if(categoria == null) 
            {
                return NotFound();
            }
            return View(categoria);
        }

        #region Llamadas a la API
        [HttpGet]
        public JsonResult GetAll() 
        {
            return Json(new {data= _containerwork.RCategoria.GetAll()});
        }

        #endregion
    }
}
