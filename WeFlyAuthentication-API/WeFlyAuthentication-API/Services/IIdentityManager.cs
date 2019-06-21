using System.Threading.Tasks;
using WeFlyAuthentication_API.Models;

namespace WeFlyAuthentication_API.Services
{
    public interface IIdentityManager
    {
        Task<dynamic> AddUserAsync(clsUser user);

        string ValidateUser(clsAuthenticate user);
    }
}
