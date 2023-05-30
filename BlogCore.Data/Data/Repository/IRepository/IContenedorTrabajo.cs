using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogCore.Data.Data.Repository.IRepository
{
    public interface IContenedorTrabajo : IDisposable
    {
        ICategoryRepository RCategoria { get; }
        //Aqui se agregan los diferentes respositorios

        void Save();
    }
}
