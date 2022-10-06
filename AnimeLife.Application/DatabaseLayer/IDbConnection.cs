namespace AnimeLife.Application.DatabaseLayer;

public interface IDbConnection
{
    /// <summary>
    /// opens connection to DB
    /// </summary>
    public void OpenConnection();

    public void CloseDbConnection(IDbConnection connection);
}