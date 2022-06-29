namespace linq2db_3632_problem;

/// <summary>
/// Test service (not suitable for production), which gives values for timeout commands in the database.
/// </summary>
public interface IFooService
{
    int GetCommandTimeout();
}

public class FooService : IFooService
{
    public FooService() { }

    public int GetCommandTimeout()
    {
        return 30;
    }
}
