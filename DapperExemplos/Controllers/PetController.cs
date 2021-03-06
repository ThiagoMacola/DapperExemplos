using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DapperExemplos.Domain.Entities;
using DapperExemplos.Infra.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace DapperExemplos.Controllers
{
	[Route(template: "/api/pets")]
	public class PetController : ControllerBase
	{
		private readonly IPetRepository _repository;

		public PetController(IPetRepository repository)
		{
			_repository = repository;
		}


		[HttpPost]
		public async Task<IActionResult> AddAsync([FromBody] Pet pet)
		{
			await _repository.AddAsync(pet);
			return Created(uri: $"/api/pets/{pet.Id}", pet); //Created
		}

		[HttpGet(template: "id")]
		public async Task<IActionResult> GetBydIdAsync(Guid id)
		{
			var pet = await _repository.GetByIdAsync(id);
			return Ok(pet); //200

		}
		[HttpPut(template: "id")]
		public async Task<IActionResult> PutByIdAsync(Guid id, [FromBody] Pet pet)
		{
			pet.Id = id;
			await _repository.PutByIdAsync(pet);
			return Ok(pet);
		}

		[HttpGet]
		public async Task<IActionResult> GetAsync()
		{
			var pets = await _repository.GetAsync();
			return Ok(pets);
		
		}
		[HttpDelete(template: "id")]
		public async Task<IActionResult> DeleteAsync(Guid id)
		{
			var sucess =  await _repository.DeleteByAsync(id);
			if (sucess)
				return Ok();
			
			return BadRequest();
		}
	}
}
