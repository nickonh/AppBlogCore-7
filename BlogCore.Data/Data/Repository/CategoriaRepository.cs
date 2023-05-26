using AppBlogCore_7.Data;
using BlogCore.Data.Data.Repository.IRepository;
using BlogCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using static System.Net.Mime.MediaTypeNames;

namespace BlogCore.Data.Data.Repository
{
    internal class CategoriaRepository : Repository<Categoria>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;

        public CategoriaRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public IEnumerable<SelectListItem> GetListaCategoria()
        {
            return _db.Categorias.Select(i => new SelectListItem()
                {
                    Text = i.Nombre,
                    Value = i.IdCategoria.ToString()
                });
        }

        public void Update(Categoria categoria)
        {
            var objDesdeDb = _db.Categorias.FirstOrDefault(s => s.IdCategoria == categoria.IdCategoria);
            objDesdeDb.Nombre = categoria.Nombre;
            objDesdeDb.Orden = categoria.Orden;

            _db.SaveChanges();
        }
    }
}
