using Finde.Infrastructure.Commands;
using Finde.Infrastructure.Commands.Users;
using Finde.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finde.Infrastructure.Handlers.Users
{
    class ChangeUserPasswordHandler : ICommandHandler<ChangeUserPassword>
    {
        private readonly IUserService _userService;

        public ChangeUserPasswordHandler(IUserService userService)
        {
            _userService = userService;
        }
        public Task HandleAsync(ChangeUserPassword command)
        {
            throw new NotImplementedException();
        }
    }
}
