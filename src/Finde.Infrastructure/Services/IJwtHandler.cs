using Finde.Infrastructure.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finde.Infrastructure.Services
{
    public interface IJwtHandler
    {
        JwtDTO CreateToken(Guid userId, string role);
    }
}
