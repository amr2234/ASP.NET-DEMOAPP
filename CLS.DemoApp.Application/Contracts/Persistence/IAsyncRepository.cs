using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLS.DemoApp.Application.Contracts.Persistence
{
	public interface IAsyncRepository<T>
	{
		public Task<List<T>> GetAllAsync();
		public Task<T> GetByIDAsync(int ID);
		public Task<T> AddAsync(T Obj);
		public Task<T> UpdateAsync(T Obj);
		public Task<T> DeleteAsync(T Obj);
		public Task<T> DeleteAsync(int ID);
	}
}
