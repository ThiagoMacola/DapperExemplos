using System.Data;


namespace DapperExemplos.Infra.Contracts
{
	public interface ISqlConnectionFactory
	{
		IDbConnection Connection();
	}
}
