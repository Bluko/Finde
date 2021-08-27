using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finde.Infrastructure.Commands.Family
{
    public class AddUserToFamily : ICommand
    {
        public Guid UserId { get; set; }
    }
}
