using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contabilidad.FRWK.INTERFACES
{
    public interface ISQLService
    {
        System.Data.SqlClient.SqlConnection getService();
        void closeService(System.Data.SqlClient.SqlConnection _conn);
    }
}
