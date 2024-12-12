using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem.Application.IRepositories.Command.Base
{
    public interface ICommandRepository<T>  where T : class
    {
        Task<T> AddAsync(T entity);

        Task ExecuteInTransactionAsync(Func<Task> action);
    }
}
