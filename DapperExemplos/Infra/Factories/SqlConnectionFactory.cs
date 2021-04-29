using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using DapperExemplos.Infra.Contracts;
using Microsoft.Data.SqlClient;

namespace DapperExemplos.Infra.Factories
{
	public class SqlConnectionFactory : ISqlConnectionFactory
	{
		public IDbConnection Connection() => new SqlConnection("Data Source=DESKTOP-27K1BRC\\SQLEXPRESS;Initial Catalog=DapperExemplos;Integrated Security=True;");

	}
}
