using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioStock.Interfaces
{
    public interface IRepositorio<T>
    {
        List<T> ObtenerTodos();

        void Guardar(T objeto);

        bool Eliminar(string codigo);
    }
}
  
