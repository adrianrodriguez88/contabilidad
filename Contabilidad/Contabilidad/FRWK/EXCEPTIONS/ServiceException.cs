using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contabilidad.FRWK.EXCEPTIONS
{
    public class ServiceException : System.Exception
    {
        private string _msg = null;

        public ServiceException (string _message)
        {
            this._msg = _message;
        }

        public string getMessage
        {
            get { return _msg; }
        }
    }
}
