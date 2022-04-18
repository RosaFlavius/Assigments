using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.Interfaces
{
    public interface IAdd<T>
    {
        void Add(T item);
    }
}
