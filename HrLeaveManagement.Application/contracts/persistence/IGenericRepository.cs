using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrLeaveManagement.Application.contracts.persistence
{
    public interface IGenericRepository<T> where T : class
    {
        Task<List<T>> GetAsync();
        Task<List<T>> GetByIdAsync(int id);

        Task<List<T>> CreateAsync(T entity);

        Task<List<T>> UpdateAsync(T entity);

        Task<List<T>> DeleteAsync (T entity);
    }

}
