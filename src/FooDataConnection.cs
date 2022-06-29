using LinqToDB.Configuration;
using LinqToDB.Data;

namespace linq2db_3632_problem;

public class FooDataConnection : DataConnection
{
    private readonly IFooService _fooService;

    public FooDataConnection(IFooService fooService, LinqToDBConnectionOptions<FooDataConnection> options) : base(options)
    {
        _fooService = fooService;

        //This is just an example of what some services may require inside the DataConnection constructor.
        CommandTimeout = _fooService.GetCommandTimeout();
    }
}
