



public class StringRepository : IRepository<string>
{
    private List<string> _string = new List<string>();

    public StringRepository(int count, int length)
    {
        GenerateRandomStrings(count, length);
    }

    private void GenerateRandomStrings(int count, int length)
    {
        var random = new Random();
        var characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

        for (var i = 0; i < count; i++)
        {
            char[] stringChars = new char[length];
            for (int j = 0; j < length; j++)
            {
                stringChars[j] = 
                    characters[random.Next(characters.Length)];
            }
            _string.Add(new string(stringChars));
        }
    }

    public void Add(string item)
    {
        _string.Add(item);
    }

    public List<string> GetAll()
    {
        return _string;
    }
}

