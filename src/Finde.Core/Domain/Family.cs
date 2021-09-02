using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finde.Core.Domain
{
    public class Family
    {
        public Guid FamilyId { get; protected set; }
        public Guid UserId {  get; protected set; }
        public Node Address { get; protected set;  }
    }
}
