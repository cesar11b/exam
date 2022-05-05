using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IModel<T>
    {

        T Extraccion(string t);
        void Add(T t);

        List<T> Read();
    }
}
