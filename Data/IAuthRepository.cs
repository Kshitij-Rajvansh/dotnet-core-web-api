using System.Threading.Tasks;
using DotnetWebApi.Models;

namespace DotnetWebApi.Data
{
    public interface IAuthRepository
    {
         Task<ServiceResponse<int>> Register(User newUser, string password);
         Task<ServiceResponse<string>> Login(string userName, string password);
         Task<bool> UserExists(string userName);
    }
}