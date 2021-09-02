using Finde.Infrastructure.Commands;
using Finde.Infrastructure.Commands.Family;
using Finde.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finde.Infrastructure.Handlers.Family
{
    public class AddUserToFamilyHandler : ICommandHandler<AddUserToFamily>
    {
        private readonly IUserService _userService;

        public AddUserToFamilyHandler(IUserService service)
        {
            _userService= service;
        }

        public async Task HandleAsync(AddUserToFamily command)
        {
            await Task.CompletedTask;
        }
    }
}
