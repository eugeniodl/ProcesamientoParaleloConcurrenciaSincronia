




public class StringProcessor
{
    private readonly IRepository<string> _repository;

    public StringProcessor(IRepository<string> repository)
    {
        _repository = repository;
    }

    public List<string> FilterStrings() =>
        _repository.GetAll().AsParallel()
        .Where(s => s.Contains('W')).ToList();
}

