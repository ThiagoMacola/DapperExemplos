using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DapperExemplos.Domain.Entities;

namespace DapperExemplos.Infra.Contracts
{
	public interface IPetRepository
	{
		Task AddAsync(Pet pet);
		Task<Pet> GetByIdAsync(Guid id);
		Task<Pet> PutByIdAsync(Pet pet);
		Task<IEnumerable<Pet>> GetAsync();
		Task<bool> DeleteByAsync(Guid id);
	}
}
