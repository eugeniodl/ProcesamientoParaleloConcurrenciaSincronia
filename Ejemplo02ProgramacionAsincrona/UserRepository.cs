

public class UserRepository : IUserRepository
{
    List<User> _users = new List<User>();
    public async Task AddUserAsync(User user)
    {
        await Task.Delay(100);
        _users.Add(user);
    }

    public async Task DeleteUserAsync(int userId)
    {
        await Task.Delay(100);
        var userRemove = await GetByIdAsync(userId);

        if (userRemove != null)
            _users.Remove(userRemove);
    }

    public async Task<IEnumerable<User>> GetAllAsync()
    {
        await Task.Delay(100);
        return _users;
    }

    public async Task<User> GetByIdAsync(int userId)
    {
        await Task.Delay(100);
        return _users.FirstOrDefault(u => u.Id == userId);
    }

    public async Task UpdateUserAsync(User user)
    {
        await Task.Delay(100);
        var existingUser = await GetByIdAsync(user.Id);
        if (existingUser != null)
        {
            existingUser.Name = user.Name;
            existingUser.Email = user.Email;
        }
    }
}

