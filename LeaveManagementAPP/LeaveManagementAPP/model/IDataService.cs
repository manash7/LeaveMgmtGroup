using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagementAPP.model
{
    public interface IDataservice<T> // called as entity all table are entity #crud operation
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> Get(int id);
        Task<T> Create(T entity);
        Task<bool> Delete(T entity);
        Task<T> Update(T entity);



    }
}
