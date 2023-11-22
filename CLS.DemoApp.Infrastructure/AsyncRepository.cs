using CLS.DemoApp.Application.Contracts.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLS.DemoApp.Infrastructure
{
	public class AsyncRepository<t>: IAsyncRepository<t> where t : class
	{

		CLSAppContext DbContext;
		public AsyncRepository(CLSAppContext DbContext)
		{
			this.DbContext = DbContext;
		}

		public async Task<t> AddAsync(t Obj)
		{
			await DbContext.Set<t>().AddAsync(Obj);
			await DbContext.SaveChangesAsync();
			return Obj;
		}

		public async Task<t> DeleteAsync(t Obj)
		{
			DbContext.Set<t>().Remove(Obj);
			await DbContext.SaveChangesAsync();
			return Obj;
		}

		public async Task<t> DeleteAsync(int ID)
		{
			t Obj = await DbContext.Set<t>().FindAsync(ID);
			DbContext.Remove(Obj);
			await DbContext.SaveChangesAsync();
			return Obj;
		}

		public async Task<List<t>> GetAllAsync()
		{
			return await DbContext.Set<t>().ToListAsync();
		}

		public async Task<t> GetByID(int ID)
		{
			return await DbContext.Set<t>().FindAsync(ID);
		}

		public Task<t> GetByIDAsync(int ID)
		{
			throw new NotImplementedException();
		}

	

		public async Task<t> UpdateAsync(t Obj)
		{
			DbContext.Entry(Obj).State = EntityState.Modified;
			await DbContext.SaveChangesAsync();
			return Obj;
		}

		
	}
}
