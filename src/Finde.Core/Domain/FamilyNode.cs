using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finde.Core.Domain
{
    public class FamilyNode
    {
        public Node Node { get; protected set; }
        public Family Family { get; protected set; }

        protected FamilyNode()
        {
        }

        protected FamilyNode(Node node, Family family)
        {
            Node = node;
            Family = family;
        }

        public static FamilyNode Create(Node node, Family family)
            => new FamilyNode(node, family);
    }
}
