



public interface IFileRepository
{
    void SaveFile(FileData fileData);
    FileData ReadFile(string fileName);
}

