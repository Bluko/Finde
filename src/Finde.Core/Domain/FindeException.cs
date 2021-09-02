using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finde.Core.Domain
{
    public abstract class FindeException : Exception
    {
        public string Code { get; }

        protected FindeException() 
        {
        }

        protected FindeException(string code)
        {
            Code = code;
        }

        protected FindeException(string message, params object[] args) : this(string.Empty, message, args)
        {
        }

        protected FindeException(string code, string message, params object[] args) : this(null, code, message, args)
        {
        }

        protected FindeException(Exception innerException, string message, params object[] args)
            : this(innerException, string.Empty, message, args)
        {
        }

        protected FindeException(Exception innerException, string code, string message, params object[] args)
            : base(string.Format(message, args), innerException)
        {
            Code = code;
        }
    }
}
