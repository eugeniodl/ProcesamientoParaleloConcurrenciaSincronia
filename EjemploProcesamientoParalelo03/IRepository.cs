



public interface IRepository<T>
{
    List<T> GetAll();
    void Copy(T sourcePath, T destinationPath);
    string GetDestinationFolder();
}

