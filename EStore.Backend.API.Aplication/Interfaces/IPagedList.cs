using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EStore.Backend.API.Aplication.Interfaces
{
    public interface IPagedList<T>
    {
        List<T> GetAll(int pageIndex);
       // T FirstRecord() => GetAll().FirstOrDefault();
       // object GetAll();
    }
}
