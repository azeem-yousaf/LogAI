namespace DBInterface;

public class DbDbConnectionString : IDbConnectionString
{
    public string ConnectionString { get; init; } = string.Empty;
}