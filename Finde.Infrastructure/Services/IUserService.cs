using Finde.Infrastructure.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finde.Infrastructure.Services
{
    public interface IUserService
    {
        Task<UserDTO> GetAsync(string email);
        Task<IEnumerable<UserDTO>> BrowseAsync();
        Task RegisterAsync(Guid userId, string email, string username, string password);
        Task LoginAsync(string email, string password);
    }
}
