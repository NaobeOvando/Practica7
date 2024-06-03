using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public interface IDatos<T>
    {
        List<T> GetAll();
        T FindById(int id);
        bool Add(T item);
        bool Update(T item);
        bool Remove(int id);
    }
}
