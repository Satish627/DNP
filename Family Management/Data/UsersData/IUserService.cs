using Family_Management.Models;

namespace Family_Management.Data.UsersData
{
    public interface IUserService
    {
        User ValidateUser(string UserName, string Password);
    }
}