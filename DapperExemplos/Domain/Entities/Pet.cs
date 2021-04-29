using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using DapperExemplos.Domain.Fixed;

namespace DapperExemplos.Domain.Entities
{
	[Table(tableName:"[dbo].[Pets]")]
	public class Pet
	{
		[ExplicitKey]
		public Guid Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public TypePet Type { get; set; }
	}
}
