using BlogCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace BlogCore.Data.Data.Repository.IRepository
{
    public interface ICategoryRepository : IRepository<Categoria>
    {
        IEnumerable<SelectListItem> GetListaCategoria();

        void Update(Categoria categoria);
    }
}
