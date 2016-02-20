using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contabilidad/*.UTILS.Generators*/
{
    public class UUIDGenerator
    {
        public static string Uuid()
        {
            string _uuid = "";
           
            _uuid = Guid.NewGuid().ToString();            

            return _uuid;
        }
        
    }
}
